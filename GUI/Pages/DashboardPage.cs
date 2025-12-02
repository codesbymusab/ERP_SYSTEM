using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ERP_System.BLL;
using Bunifu.Charts.WinForms;

namespace ERP_System.GUI.Pages
{
    public partial class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
            // Don't load data in constructor - use Load event instead
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Only load data once when the control is first displayed
            if (!DesignMode)
            {
                LoadDashboardData();
            }
        }

        // Main method to load all dashboard data
        private void LoadDashboardData()
        {
            try
            {
                // Show loading cursor
                this.Cursor = Cursors.WaitCursor;

                // Get all dashboard data
                DashboardDataDTO data = DashboardBL.GetDashboardData();

                // Update UI components
                UpdateStatsCards(data.Stats);
                UpdateRecentSales(data.RecentSales);
                UpdateLowStockAlerts(data.LowStockAlerts);
                UpdateRevenueChart(data.RevenueData);
                UpdateCategoryChart(data.SalesByCategory);
                UpdateDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message + "\n\nStack Trace: " + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        // Update the stats cards
        private void UpdateStatsCards(DashboardStatsDTO stats)
        {
            // Debug output
            Console.WriteLine($"Updating stats - Revenue: {stats.TotalRevenue}, Orders: {stats.TotalOrders}");

            // Revenue Card
            lblRevenueValue.Text = DashboardBL.FormatCurrency(stats.TotalRevenue);
            lblRevenueChange.Text = DashboardBL.FormatPercentageChange(stats.RevenueChange);
            lblRevenueChange.ForeColor = stats.RevenueChange >= 0 ?
                Color.FromArgb(34, 197, 94) : Color.FromArgb(239, 68, 68);

            // Orders Card
            lblOrdersValue.Text = stats.TotalOrders.ToString("#,0");
            lblOrdersChange.Text = DashboardBL.FormatPercentageChange(stats.OrdersChange);
            lblOrdersChange.ForeColor = stats.OrdersChange >= 0 ?
                Color.FromArgb(34, 197, 94) : Color.FromArgb(239, 68, 68);

            // Customers Card
            lblCustomersValue.Text = stats.ActiveCustomers.ToString("#,0");
            lblCustomersChange.Text = DashboardBL.FormatPercentageChange(stats.CustomersChange);
            lblCustomersChange.ForeColor = stats.CustomersChange >= 0 ?
                Color.FromArgb(34, 197, 94) : Color.FromArgb(239, 68, 68);

            // Products Card
            lblProductsValue.Text = stats.TotalProducts.ToString("#,0");
            lblProductsChange.Text = DashboardBL.FormatPercentageChange(stats.ProductsChange);
            lblProductsChange.ForeColor = stats.ProductsChange >= 0 ?
                Color.FromArgb(34, 197, 94) : Color.FromArgb(239, 68, 68);
        }

        // Update recent sales list
        private void UpdateRecentSales(List<RecentSaleDTO> sales)
        {
            // Debug output
            Console.WriteLine($"Updating recent sales - Count: {sales.Count}");

            // Reset all labels first
            HideSalesLabels();

            // Update visible sales
            for (int i = 0; i < Math.Min(sales.Count, 4); i++)
            {
                RecentSaleDTO sale = sales[i];
                Console.WriteLine($"Sale {i + 1}: {sale.SaleId} - {sale.CustomerName} - {sale.TotalAmount}");

                switch (i)
                {
                    case 0:
                        l_sid1.Text = $"SAL-{sale.SaleId:D4}";
                        l_cname1.Text = sale.CustomerName;
                        l_t1.Text = $"{sale.TotalAmount:C0}";
                        l_status1.Text = CapitalizeFirst(sale.Status);
                        l_status1.ForeColor = DashboardBL.GetStatusColor(sale.Status);
                        ShowSalesLabels(1);
                        break;
                    case 1:
                        l_sid2.Text = $"SAL-{sale.SaleId:D4}";
                        l_cname2.Text = sale.CustomerName;
                        l_t2.Text = $"{sale.TotalAmount:C0}";
                        l_status2.Text = CapitalizeFirst(sale.Status);
                        l_status2.ForeColor = DashboardBL.GetStatusColor(sale.Status);
                        ShowSalesLabels(2);
                        break;
                    case 2:
                        l_sid3.Text = $"SAL-{sale.SaleId:D4}";
                        l_cname3.Text = sale.CustomerName;
                        l_t3.Text = $"{sale.TotalAmount:C0}";
                        l_status3.Text = CapitalizeFirst(sale.Status);
                        l_status3.ForeColor = DashboardBL.GetStatusColor(sale.Status);
                        ShowSalesLabels(3);
                        break;
                    case 3:
                        l_sid4.Text = $"SAL-{sale.SaleId:D4}";
                        l_cname4.Text = sale.CustomerName;
                        l_t4.Text = $"{sale.TotalAmount:C0}";
                        l_status4.Text = CapitalizeFirst(sale.Status);
                        l_status4.ForeColor = DashboardBL.GetStatusColor(sale.Status);
                        ShowSalesLabels(4);
                        break;
                }
            }
        }

        // Update low stock alerts
        private void UpdateLowStockAlerts(List<LowStockAlertDTO> alerts)
        {
            // Debug output
            Console.WriteLine($"Updating low stock alerts - Count: {alerts.Count}");

            // Reset all labels first
            HideStockLabels();

            // Update visible alerts
            for (int i = 0; i < Math.Min(alerts.Count, 4); i++)
            {
                LowStockAlertDTO alert = alerts[i];
                Console.WriteLine($"Alert {i + 1}: {alert.SKU} - {alert.ProductName} - Stock: {alert.CurrentStock}/{alert.LowStockThreshold}");

                switch (i)
                {
                    case 0:
                        l_iname1.Text = alert.SKU;
                        l_icode1.Text = TruncateText(alert.ProductName, 30);
                        l_qty1.Text = $"{alert.CurrentStock} units";
                        l_thres1.Text = $"Min: {alert.LowStockThreshold}";
                        ShowStockLabels(1);
                        break;
                    case 1:
                        l_iname2.Text = alert.SKU;
                        l_icode2.Text = TruncateText(alert.ProductName, 30);
                        l_qty2.Text = $"{alert.CurrentStock} units";
                        l_thres2.Text = $"Min: {alert.LowStockThreshold}";
                        ShowStockLabels(2);
                        break;
                    case 2:
                        l_iname3.Text = alert.SKU;
                        l_icode3.Text = TruncateText(alert.ProductName, 30);
                        l_qty3.Text = $"{alert.CurrentStock} units";
                        l_thres3.Text = $"Min: {alert.LowStockThreshold}";
                        ShowStockLabels(3);
                        break;
                    case 3:
                        l_iname4.Text = alert.SKU;
                        l_icode4.Text = TruncateText(alert.ProductName, 30);
                        l_qty4.Text = $"{alert.CurrentStock} units";
                        l_thres4.Text = $"Min: {alert.LowStockThreshold}";
                        ShowStockLabels(4);
                        break;
                }
            }
        }

        // Update revenue chart (line chart)
        private void UpdateRevenueChart(List<RevenueDataDTO> revenueData)
        {
            try
            {
                // Clear existing data from the line chart
                bunifuLineChart1.Data.Clear();

                // Prepare labels array
                List<string> monthLabels = new List<string>();

                // Add data points
                foreach (var data in revenueData)
                {
                    monthLabels.Add(data.Month);
                    bunifuLineChart1.Data.Add(Convert.ToDouble(data.Revenue));
                }

                // Update canvas labels
                bunifuChartCanvas1.Labels = monthLabels.ToArray();

                // Refresh the chart
                bunifuChartCanvas1.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating revenue chart: " + ex.Message);
            }
        }

        // Update category chart (doughnut chart)
        private void UpdateCategoryChart(List<SalesByCategoryDTO> categoryData)
        {
            try
            {
                // Clear existing data from the doughnut chart
                bunifuDoughnutChart1.Data.Clear();
                bunifuDoughnutChart1.BackgroundColor.Clear();

                // Prepare labels list
                List<string> categoryLabels = new List<string>();

                // Define colors for categories
                var colors = new List<Color>
                {
                    Color.FromArgb(99, 102, 241),   // Indigo
                    Color.FromArgb(139, 92, 246),   // Purple
                    Color.FromArgb(236, 72, 153),   // Pink
                    Color.FromArgb(251, 146, 60),   // Orange
                    Color.FromArgb(34, 197, 94),    // Green
                    Color.FromArgb(59, 130, 246)    // Blue
                };

                // Add data
                for (int i = 0; i < categoryData.Count; i++)
                {
                    categoryLabels.Add(categoryData[i].Category);
                    bunifuDoughnutChart1.Data.Add(Convert.ToDouble(categoryData[i].TotalSales));
                    bunifuDoughnutChart1.BackgroundColor.Add(colors[i % colors.Count]);
                }

                // Update canvas labels
                bunifuChartCanvas2.Labels = categoryLabels.ToArray();

                // Refresh the chart
                bunifuChartCanvas2.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating category chart: " + ex.Message);
            }
        }

        // Update date display
        private void UpdateDate()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        // Helper methods
        private void HideSalesLabels()
        {
            l_sid1.Visible = l_cname1.Visible = l_t1.Visible = l_status1.Visible = false;
            l_sid2.Visible = l_cname2.Visible = l_t2.Visible = l_status2.Visible = false;
            l_sid3.Visible = l_cname3.Visible = l_t3.Visible = l_status3.Visible = false;
            l_sid4.Visible = l_cname4.Visible = l_t4.Visible = l_status4.Visible = false;
        }

        private void ShowSalesLabels(int index)
        {
            switch (index)
            {
                case 1:
                    l_sid1.Visible = l_cname1.Visible = l_t1.Visible = l_status1.Visible = true;
                    break;
                case 2:
                    l_sid2.Visible = l_cname2.Visible = l_t2.Visible = l_status2.Visible = true;
                    break;
                case 3:
                    l_sid3.Visible = l_cname3.Visible = l_t3.Visible = l_status3.Visible = true;
                    break;
                case 4:
                    l_sid4.Visible = l_cname4.Visible = l_t4.Visible = l_status4.Visible = true;
                    break;
            }
        }

        private void HideStockLabels()
        {
            l_iname1.Visible = l_icode1.Visible = l_qty1.Visible = l_thres1.Visible = false;
            l_iname2.Visible = l_icode2.Visible = l_qty2.Visible = l_thres2.Visible = false;
            l_iname3.Visible = l_icode3.Visible = l_qty3.Visible = l_thres3.Visible = false;
            l_iname4.Visible = l_icode4.Visible = l_qty4.Visible = l_thres4.Visible = false;
        }

        private void ShowStockLabels(int index)
        {
            switch (index)
            {
                case 1:
                    l_iname1.Visible = l_icode1.Visible = l_qty1.Visible = l_thres1.Visible = true;
                    break;
                case 2:
                    l_iname2.Visible = l_icode2.Visible = l_qty2.Visible = l_thres2.Visible = true;
                    break;
                case 3:
                    l_iname3.Visible = l_icode3.Visible = l_qty3.Visible = l_thres3.Visible = true;
                    break;
                case 4:
                    l_iname4.Visible = l_icode4.Visible = l_qty4.Visible = l_thres4.Visible = true;
                    break;
            }
        }

        private string TruncateText(string text, int maxLength)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return text.Length <= maxLength ? text : text.Substring(0, maxLength) + "...";
        }

        private string CapitalizeFirst(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }

        // Refresh button click event
        private void button1_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard refreshed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}