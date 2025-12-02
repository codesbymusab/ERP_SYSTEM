using System;
using System.Collections.Generic;
using ERP_System.DLL;

namespace ERP_System.BLL
{
    public class DashboardBL
    {
        // Get all dashboard data in one call
        public static DashboardDataDTO GetDashboardData()
        {
            try
            {
                DashboardDataDTO dashboardData = new DashboardDataDTO();

                // Fetch all data from data layer
                dashboardData.Stats = DashboardDL.GetDashboardStats();
                dashboardData.RecentSales = DashboardDL.GetRecentSales();
                dashboardData.LowStockAlerts = DashboardDL.GetLowStockAlerts();
                dashboardData.RevenueData = DashboardDL.GetRevenueData();
                dashboardData.SalesByCategory = DashboardDL.GetSalesByCategory();

                return dashboardData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading dashboard data: " + ex.Message);
            }
        }

        // Get only stats (for quick refresh)
        public static DashboardStatsDTO GetStats()
        {
            try
            {
                return DashboardDL.GetDashboardStats();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading dashboard stats: " + ex.Message);
            }
        }

        // Get only recent sales
        public static List<RecentSaleDTO> GetRecentSales()
        {
            try
            {
                return DashboardDL.GetRecentSales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading recent sales: " + ex.Message);
            }
        }

        // Get only low stock alerts
        public static List<LowStockAlertDTO> GetLowStockAlerts()
        {
            try
            {
                return DashboardDL.GetLowStockAlerts();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading low stock alerts: " + ex.Message);
            }
        }

        // Get revenue chart data
        public static List<RevenueDataDTO> GetRevenueData()
        {
            try
            {
                return DashboardDL.GetRevenueData();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading revenue data: " + ex.Message);
            }
        }

        // Get category sales data
        public static List<SalesByCategoryDTO> GetSalesByCategory()
        {
            try
            {
                return DashboardDL.GetSalesByCategory();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading sales by category: " + ex.Message);
            }
        }

        // Format currency for display
        public static string FormatCurrency(decimal amount)
        {
            if (amount >= 1000000)
            {
                return $"${amount / 1000000:F1}M";
            }
            else if (amount >= 1000)
            {
                return $"${amount / 1000:F1}K";
            }
            else
            {
                return $"${amount:F0}";
            }
        }

        // Format percentage change
        public static string FormatPercentageChange(decimal change)
        {
            string arrow = change >= 0 ? "↗" : "↘";
            return $"{arrow} {Math.Abs(change):F1}% from last month";
        }

        // Get status color
        public static System.Drawing.Color GetStatusColor(string status)
        {
            switch (status.ToLower())
            {
                case "paid":
                case "received":
                    return System.Drawing.Color.LawnGreen;
                case "pending":
                case "draft":
                    return System.Drawing.Color.Crimson;
                case "cancelled":
                    return System.Drawing.Color.Gray;
                default:
                    return System.Drawing.Color.Black;
            }
        }
    }
}