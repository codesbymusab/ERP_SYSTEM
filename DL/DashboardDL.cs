using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ERP_System.BLL;

namespace ERP_System.DLL
{
    public class DashboardDL
    {
        // Get total revenue and change percentage
        public static DashboardStatsDTO GetDashboardStats()
        {
            DashboardStatsDTO stats = new DashboardStatsDTO();
            DBConnection dbConn = new DBConnection();

            string query = @"
                -- Current month revenue
                DECLARE @CurrentMonthRevenue DECIMAL(18,2);
                DECLARE @LastMonthRevenue DECIMAL(18,2);
                DECLARE @CurrentMonthOrders INT;
                DECLARE @LastMonthOrders INT;
                DECLARE @CurrentMonthCustomers INT;
                DECLARE @LastMonthCustomers INT;

                -- Revenue
                SELECT @CurrentMonthRevenue = ISNULL(SUM(total_amount), 0)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(GETDATE()) 
                AND YEAR([date]) = YEAR(GETDATE())
                AND status = 'paid';

                SELECT @LastMonthRevenue = ISNULL(SUM(total_amount), 0)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                AND YEAR([date]) = YEAR(DATEADD(MONTH, -1, GETDATE()))
                AND status = 'paid';

                -- Orders
                SELECT @CurrentMonthOrders = COUNT(*)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(GETDATE()) 
                AND YEAR([date]) = YEAR(GETDATE());

                SELECT @LastMonthOrders = COUNT(*)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                AND YEAR([date]) = YEAR(DATEADD(MONTH, -1, GETDATE()));

                -- Unique customers
                SELECT @CurrentMonthCustomers = COUNT(DISTINCT customer_name)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(GETDATE()) 
                AND YEAR([date]) = YEAR(GETDATE());

                SELECT @LastMonthCustomers = COUNT(DISTINCT customer_name)
                FROM dbo.sales
                WHERE MONTH([date]) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                AND YEAR([date]) = YEAR(DATEADD(MONTH, -1, GETDATE()));

                SELECT 
                    @CurrentMonthRevenue AS TotalRevenue,
                    CASE WHEN @LastMonthRevenue > 0 
                        THEN ((@CurrentMonthRevenue - @LastMonthRevenue) / @LastMonthRevenue) * 100 
                        ELSE 0 END AS RevenueChange,
                    @CurrentMonthOrders AS TotalOrders,
                    CASE WHEN @LastMonthOrders > 0 
                        THEN (CAST(@CurrentMonthOrders AS DECIMAL) - @LastMonthOrders) / @LastMonthOrders * 100 
                        ELSE 0 END AS OrdersChange,
                    @CurrentMonthCustomers AS ActiveCustomers,
                    CASE WHEN @LastMonthCustomers > 0 
                        THEN (CAST(@CurrentMonthCustomers AS DECIMAL) - @LastMonthCustomers) / @LastMonthCustomers * 100 
                        ELSE 0 END AS CustomersChange,
                    (SELECT COUNT(*) FROM dbo.products WHERE stock > 0) AS TotalProducts,
                    0 AS ProductsChange;";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dbConn.Con);
                dbConn.Con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Safe reading with null checks and type conversion
                        stats.TotalRevenue = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        stats.RevenueChange = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader.GetValue(1));
                        stats.TotalOrders = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                        stats.OrdersChange = reader.IsDBNull(3) ? 0 : Convert.ToDecimal(reader.GetValue(3));
                        stats.ActiveCustomers = reader.IsDBNull(4) ? 0 : reader.GetInt32(4);
                        stats.CustomersChange = reader.IsDBNull(5) ? 0 : Convert.ToDecimal(reader.GetValue(5));
                        stats.TotalProducts = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                        stats.ProductsChange = reader.IsDBNull(7) ? 0 : Convert.ToDecimal(reader.GetValue(7));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching dashboard stats: " + ex.Message + " | InnerException: " + ex.InnerException?.Message);
            }
            finally
            {
                if (dbConn.Con.State == ConnectionState.Open)
                    dbConn.Con.Close();
            }

            return stats;
        }

        // Get recent sales (last 4)
        public static List<RecentSaleDTO> GetRecentSales()
        {
            List<RecentSaleDTO> sales = new List<RecentSaleDTO>();
            DBConnection dbConn = new DBConnection();

            string query = @"
                SELECT TOP 4 
                    id, customer_name, total_amount, status, [date]
                FROM dbo.sales
                ORDER BY [date] DESC, id DESC;";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dbConn.Con);
                dbConn.Con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sales.Add(new RecentSaleDTO
                        {
                            SaleId = reader.GetInt32(0),
                            CustomerName = reader.IsDBNull(1) ? "Unknown" : reader.GetString(1),
                            TotalAmount = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                            Status = reader.IsDBNull(3) ? "draft" : reader.GetString(3),
                            Date = reader.IsDBNull(4) ? DateTime.Now : reader.GetDateTime(4)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching recent sales: " + ex.Message);
            }
            finally
            {
                if (dbConn.Con.State == ConnectionState.Open)
                    dbConn.Con.Close();
            }

            return sales;
        }

        // Get low stock alerts (top 4)
        public static List<LowStockAlertDTO> GetLowStockAlerts()
        {
            List<LowStockAlertDTO> alerts = new List<LowStockAlertDTO>();
            DBConnection dbConn = new DBConnection();

            string query = @"
                SELECT TOP 4 
                    sku, name, stock, low_stock_threshold
                FROM dbo.products
                WHERE stock < low_stock_threshold
                ORDER BY (low_stock_threshold - stock) DESC;";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dbConn.Con);
                dbConn.Con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alerts.Add(new LowStockAlertDTO
                        {
                            SKU = reader.IsDBNull(0) ? "N/A" : reader.GetString(0),
                            ProductName = reader.IsDBNull(1) ? "Unknown Product" : reader.GetString(1),
                            CurrentStock = reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                            LowStockThreshold = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching low stock alerts: " + ex.Message);
            }
            finally
            {
                if (dbConn.Con.State == ConnectionState.Open)
                    dbConn.Con.Close();
            }

            return alerts;
        }

        // Get revenue data for last 5 months
        public static List<RevenueDataDTO> GetRevenueData()
        {
            List<RevenueDataDTO> revenueData = new List<RevenueDataDTO>();
            DBConnection dbConn = new DBConnection();

            string query = @"
                WITH MonthlyData AS (
                    SELECT 
                        DATEADD(MONTH, -4, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)) AS MonthDate
                    UNION ALL
                    SELECT DATEADD(MONTH, -3, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                    UNION ALL
                    SELECT DATEADD(MONTH, -2, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                    UNION ALL
                    SELECT DATEADD(MONTH, -1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                    UNION ALL
                    SELECT DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
                )
                SELECT 
                    FORMAT(md.MonthDate, 'MMM yyyy') AS Month,
                    ISNULL(SUM(s.total_amount), 0) AS Revenue,
                    ISNULL(SUM(p.total_amount), 0) AS Expenses
                FROM MonthlyData md
                LEFT JOIN dbo.sales s ON 
                    YEAR(s.[date]) = YEAR(md.MonthDate) AND 
                    MONTH(s.[date]) = MONTH(md.MonthDate) AND
                    s.status = 'paid'
                LEFT JOIN dbo.purchases p ON 
                    YEAR(p.[date]) = YEAR(md.MonthDate) AND 
                    MONTH(p.[date]) = MONTH(md.MonthDate)
                GROUP BY md.MonthDate
                ORDER BY md.MonthDate;";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dbConn.Con);
                dbConn.Con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        revenueData.Add(new RevenueDataDTO
                        {
                            Month = reader.IsDBNull(0) ? "" : reader.GetString(0),
                            Revenue = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1),
                            Expenses = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching revenue data: " + ex.Message);
            }
            finally
            {
                if (dbConn.Con.State == ConnectionState.Open)
                    dbConn.Con.Close();
            }

            return revenueData;
        }

        // Get sales by category for doughnut chart
        public static List<SalesByCategoryDTO> GetSalesByCategory()
        {
            List<SalesByCategoryDTO> categoryData = new List<SalesByCategoryDTO>();
            DBConnection dbConn = new DBConnection();

            string query = @"
                SELECT 
                    ISNULL(p.category, 'Uncategorized') AS Category,
                    SUM(si.total_price) AS TotalSales,
                    COUNT(DISTINCT p.id) AS ProductCount
                FROM dbo.sale_items si
                INNER JOIN dbo.products p ON si.product_id = p.id
                INNER JOIN dbo.sales s ON si.sale_id = s.id
                WHERE s.status = 'paid'
                GROUP BY p.category
                ORDER BY TotalSales DESC;";

            try
            {
                SqlCommand cmd = new SqlCommand(query, dbConn.Con);
                dbConn.Con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryData.Add(new SalesByCategoryDTO
                        {
                            Category = reader.IsDBNull(0) ? "Uncategorized" : reader.GetString(0),
                            TotalSales = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1),
                            ProductCount = reader.IsDBNull(2) ? 0 : reader.GetInt32(2)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching sales by category: " + ex.Message);
            }
            finally
            {
                if (dbConn.Con.State == ConnectionState.Open)
                    dbConn.Con.Close();
            }

            return categoryData;
        }
    }
}