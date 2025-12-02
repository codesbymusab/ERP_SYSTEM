using System;
using System.Collections.Generic;

namespace ERP_System.BLL
{
    // Main dashboard statistics
    public class DashboardStatsDTO
    {
        public decimal TotalRevenue { get; set; }
        public decimal RevenueChange { get; set; }
        public int TotalOrders { get; set; }
        public decimal OrdersChange { get; set; }
        public int ActiveCustomers { get; set; }
        public decimal CustomersChange { get; set; }
        public int TotalProducts { get; set; }
        public decimal ProductsChange { get; set; }
    }

    // Recent sales for the dashboard
    public class RecentSaleDTO
    {
        public int SaleId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }

    // Low stock alerts
    public class LowStockAlertDTO
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int CurrentStock { get; set; }
        public int LowStockThreshold { get; set; }
    }

    // Revenue data for line chart
    public class RevenueDataDTO
    {
        public string Month { get; set; }
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
    }

    // Sales by category for doughnut chart
    public class SalesByCategoryDTO
    {
        public string Category { get; set; }
        public decimal TotalSales { get; set; }
        public int ProductCount { get; set; }
    }

    // Complete dashboard data container
    public class DashboardDataDTO
    {
        public DashboardStatsDTO Stats { get; set; }
        public List<RecentSaleDTO> RecentSales { get; set; }
        public List<LowStockAlertDTO> LowStockAlerts { get; set; }
        public List<RevenueDataDTO> RevenueData { get; set; }
        public List<SalesByCategoryDTO> SalesByCategory { get; set; }

        public DashboardDataDTO()
        {
            Stats = new DashboardStatsDTO();
            RecentSales = new List<RecentSaleDTO>();
            LowStockAlerts = new List<LowStockAlertDTO>();
            RevenueData = new List<RevenueDataDTO>();
            SalesByCategory = new List<SalesByCategoryDTO>();
        }
    }
}