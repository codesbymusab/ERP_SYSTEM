namespace ERP_System.GUI.Pages
{
    partial class DashboardPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.cardRevenue = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblRevenueChange = new System.Windows.Forms.Label();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.cardOrders = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblOrdersChange = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.cardCustomers = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblCustomersChange = new System.Windows.Forms.Label();
            this.lblCustomersValue = new System.Windows.Forms.Label();
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.cardProducts = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblProductsChange = new System.Windows.Forms.Label();
            this.lblProductsValue = new System.Windows.Forms.Label();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlRecentOrders = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblRecentOrdersTitle = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnlLowStock = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblLowStockTitle = new System.Windows.Forms.Label();
            this.dgvLowStock = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pnlSalesChart = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartSales = new LiveCharts.WinForms.PieChart();
            this.lblSalesChartTitle = new System.Windows.Forms.Label();
            this.pnlRevenueChart = new Bunifu.UI.WinForms.BunifuPanel();
            this.chartRevenue = new LiveCharts.WinForms.CartesianChart();
            this.lblRevenueChartTitle = new System.Windows.Forms.Label();
            this.pnlCharts = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.cardOrders.SuspendLayout();
            this.cardCustomers.SuspendLayout();
            this.cardProducts.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.pnlLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.pnlSalesChart.SuspendLayout();
            this.pnlRevenueChart.SuspendLayout();
            this.pnlCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.White;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.cardRevenue);
            this.pnlMain.Controls.Add(this.cardOrders);
            this.pnlMain.Controls.Add(this.cardCustomers);
            this.pnlMain.Controls.Add(this.cardProducts);
            this.pnlMain.Controls.Add(this.pnlCharts);
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackgroundColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlHeader.BorderRadius = 8;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Location = new System.Drawing.Point(3, 2);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1533, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(1213, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 30);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Saturday, November 29, 2025";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageTitle.Location = new System.Drawing.Point(19, 23);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(129, 32);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackgroundColor = System.Drawing.Color.White;
            this.cardRevenue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardRevenue.BackgroundImage")));
            this.cardRevenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardRevenue.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardRevenue.BorderRadius = 8;
            this.cardRevenue.BorderThickness = 1;
            this.cardRevenue.Controls.Add(this.lblRevenueChange);
            this.cardRevenue.Controls.Add(this.lblRevenueValue);
            this.cardRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardRevenue.Location = new System.Drawing.Point(35, 95);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.ShowBorders = true;
            this.cardRevenue.Size = new System.Drawing.Size(240, 170);
            this.cardRevenue.TabIndex = 1;
            // 
            // lblRevenueChange
            // 
            this.lblRevenueChange.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenueChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblRevenueChange.Location = new System.Drawing.Point(20, 110);
            this.lblRevenueChange.Name = "lblRevenueChange";
            this.lblRevenueChange.Size = new System.Drawing.Size(200, 50);
            this.lblRevenueChange.TabIndex = 2;
            this.lblRevenueChange.Text = "↗ 12.5% from last month";
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(20, 55);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.Size = new System.Drawing.Size(200, 50);
            this.lblRevenueValue.TabIndex = 1;
            this.lblRevenueValue.Text = "$328,000";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueTitle.Location = new System.Drawing.Point(20, 20);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(200, 30);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Total Revenue";
            // 
            // cardOrders
            // 
            this.cardOrders.BackgroundColor = System.Drawing.Color.White;
            this.cardOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardOrders.BackgroundImage")));
            this.cardOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardOrders.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardOrders.BorderRadius = 8;
            this.cardOrders.BorderThickness = 1;
            this.cardOrders.Controls.Add(this.lblOrdersChange);
            this.cardOrders.Controls.Add(this.lblOrdersValue);
            this.cardOrders.Controls.Add(this.lblOrdersTitle);
            this.cardOrders.Location = new System.Drawing.Point(310, 95);
            this.cardOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardOrders.Name = "cardOrders";
            this.cardOrders.ShowBorders = true;
            this.cardOrders.Size = new System.Drawing.Size(240, 170);
            this.cardOrders.TabIndex = 2;
            // 
            // lblOrdersChange
            // 
            this.lblOrdersChange.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrdersChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblOrdersChange.Location = new System.Drawing.Point(20, 110);
            this.lblOrdersChange.Name = "lblOrdersChange";
            this.lblOrdersChange.Size = new System.Drawing.Size(200, 50);
            this.lblOrdersChange.TabIndex = 2;
            this.lblOrdersChange.Text = "↗ 8.2% from last month";
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOrdersValue.Location = new System.Drawing.Point(20, 55);
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(200, 50);
            this.lblOrdersValue.TabIndex = 1;
            this.lblOrdersValue.Text = "1,284";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblOrdersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(200, 30);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Total Orders";
            // 
            // cardCustomers
            // 
            this.cardCustomers.BackgroundColor = System.Drawing.Color.White;
            this.cardCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardCustomers.BackgroundImage")));
            this.cardCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardCustomers.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardCustomers.BorderRadius = 8;
            this.cardCustomers.BorderThickness = 1;
            this.cardCustomers.Controls.Add(this.lblCustomersChange);
            this.cardCustomers.Controls.Add(this.lblCustomersValue);
            this.cardCustomers.Controls.Add(this.lblCustomersTitle);
            this.cardCustomers.Location = new System.Drawing.Point(585, 95);
            this.cardCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.ShowBorders = true;
            this.cardCustomers.Size = new System.Drawing.Size(240, 170);
            this.cardCustomers.TabIndex = 3;
            // 
            // lblCustomersChange
            // 
            this.lblCustomersChange.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCustomersChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblCustomersChange.Location = new System.Drawing.Point(20, 110);
            this.lblCustomersChange.Name = "lblCustomersChange";
            this.lblCustomersChange.Size = new System.Drawing.Size(200, 50);
            this.lblCustomersChange.TabIndex = 2;
            this.lblCustomersChange.Text = "↘ 3.1% from last month";
            // 
            // lblCustomersValue
            // 
            this.lblCustomersValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomersValue.Location = new System.Drawing.Point(20, 55);
            this.lblCustomersValue.Name = "lblCustomersValue";
            this.lblCustomersValue.Size = new System.Drawing.Size(200, 50);
            this.lblCustomersValue.TabIndex = 1;
            this.lblCustomersValue.Text = "3,456";
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblCustomersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(200, 30);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Active Customers";
            // 
            // cardProducts
            // 
            this.cardProducts.BackgroundColor = System.Drawing.Color.White;
            this.cardProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardProducts.BackgroundImage")));
            this.cardProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardProducts.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardProducts.BorderRadius = 8;
            this.cardProducts.BorderThickness = 1;
            this.cardProducts.Controls.Add(this.lblProductsChange);
            this.cardProducts.Controls.Add(this.lblProductsValue);
            this.cardProducts.Controls.Add(this.lblProductsTitle);
            this.cardProducts.Location = new System.Drawing.Point(860, 95);
            this.cardProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardProducts.Name = "cardProducts";
            this.cardProducts.ShowBorders = true;
            this.cardProducts.Size = new System.Drawing.Size(240, 170);
            this.cardProducts.TabIndex = 4;
            // 
            // lblProductsChange
            // 
            this.lblProductsChange.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblProductsChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblProductsChange.Location = new System.Drawing.Point(20, 110);
            this.lblProductsChange.Name = "lblProductsChange";
            this.lblProductsChange.Size = new System.Drawing.Size(200, 50);
            this.lblProductsChange.TabIndex = 2;
            this.lblProductsChange.Text = "↗ 15.3% from last month";
            // 
            // lblProductsValue
            // 
            this.lblProductsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblProductsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductsValue.Location = new System.Drawing.Point(20, 55);
            this.lblProductsValue.Name = "lblProductsValue";
            this.lblProductsValue.Size = new System.Drawing.Size(200, 50);
            this.lblProductsValue.TabIndex = 1;
            this.lblProductsValue.Text = "892";
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblProductsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(200, 30);
            this.lblProductsTitle.TabIndex = 0;
            this.lblProductsTitle.Text = "Total Products";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBottom.BackgroundImage")));
            this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBottom.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBottom.BorderRadius = 0;
            this.pnlBottom.BorderThickness = 0;
            this.pnlBottom.Controls.Add(this.pnlRecentOrders);
            this.pnlBottom.Controls.Add(this.pnlLowStock);
            this.pnlBottom.Location = new System.Drawing.Point(35, 595);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.ShowBorders = false;
            this.pnlBottom.Size = new System.Drawing.Size(1065, 230);
            this.pnlBottom.TabIndex = 6;
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.pnlRecentOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRecentOrders.BackgroundImage")));
            this.pnlRecentOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRecentOrders.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRecentOrders.BorderRadius = 8;
            this.pnlRecentOrders.BorderThickness = 1;
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrdersTitle);
            this.pnlRecentOrders.Controls.Add(this.dgvRecentOrders);
            this.pnlRecentOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlRecentOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.ShowBorders = true;
            this.pnlRecentOrders.Size = new System.Drawing.Size(520, 230);
            this.pnlRecentOrders.TabIndex = 0;
            // 
            // lblRecentOrdersTitle
            // 
            this.lblRecentOrdersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRecentOrdersTitle.Location = new System.Drawing.Point(20, 12);
            this.lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            this.lblRecentOrdersTitle.Size = new System.Drawing.Size(200, 30);
            this.lblRecentOrdersTitle.TabIndex = 0;
            this.lblRecentOrdersTitle.Text = "Recent Orders";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.AllowCustomTheming = false;
            this.dgvRecentOrders.AllowUserToAddRows = false;
            this.dgvRecentOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRecentOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentOrders.ColumnHeadersHeight = 40;
            this.dgvRecentOrders.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvRecentOrders.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRecentOrders.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRecentOrders.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvRecentOrders.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRecentOrders.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvRecentOrders.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvRecentOrders.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvRecentOrders.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvRecentOrders.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentOrders.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvRecentOrders.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRecentOrders.CurrentTheme.Name = null;
            this.dgvRecentOrders.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentOrders.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvRecentOrders.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRecentOrders.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvRecentOrders.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentOrders.EnableHeadersVisualStyles = false;
            this.dgvRecentOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvRecentOrders.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvRecentOrders.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvRecentOrders.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRecentOrders.Location = new System.Drawing.Point(15, 50);
            this.dgvRecentOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.ReadOnly = true;
            this.dgvRecentOrders.RowHeadersVisible = false;
            this.dgvRecentOrders.RowHeadersWidth = 53;
            this.dgvRecentOrders.RowTemplate.Height = 40;
            this.dgvRecentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentOrders.Size = new System.Drawing.Size(490, 165);
            this.dgvRecentOrders.TabIndex = 1;
            this.dgvRecentOrders.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackgroundColor = System.Drawing.Color.White;
            this.pnlLowStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLowStock.BackgroundImage")));
            this.pnlLowStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLowStock.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLowStock.BorderRadius = 8;
            this.pnlLowStock.BorderThickness = 1;
            this.pnlLowStock.Controls.Add(this.lblLowStockTitle);
            this.pnlLowStock.Controls.Add(this.dgvLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(545, 0);
            this.pnlLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.ShowBorders = true;
            this.pnlLowStock.Size = new System.Drawing.Size(520, 230);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lblLowStockTitle
            // 
            this.lblLowStockTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLowStockTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLowStockTitle.Location = new System.Drawing.Point(20, 12);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(200, 30);
            this.lblLowStockTitle.TabIndex = 0;
            this.lblLowStockTitle.Text = "Low Stock Alerts";
            // 
            // dgvLowStock
            // 
            this.dgvLowStock.AllowCustomTheming = false;
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvLowStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLowStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvLowStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLowStock.ColumnHeadersHeight = 40;
            this.dgvLowStock.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvLowStock.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLowStock.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLowStock.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLowStock.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLowStock.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLowStock.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLowStock.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvLowStock.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLowStock.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvLowStock.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLowStock.CurrentTheme.Name = null;
            this.dgvLowStock.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLowStock.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLowStock.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLowStock.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvLowStock.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLowStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLowStock.EnableHeadersVisualStyles = false;
            this.dgvLowStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvLowStock.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvLowStock.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvLowStock.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLowStock.Location = new System.Drawing.Point(15, 50);
            this.dgvLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowHeadersWidth = 53;
            this.dgvLowStock.RowTemplate.Height = 40;
            this.dgvLowStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(490, 165);
            this.dgvLowStock.TabIndex = 1;
            this.dgvLowStock.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // pnlSalesChart
            // 
            this.pnlSalesChart.BackgroundColor = System.Drawing.Color.White;
            this.pnlSalesChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSalesChart.BackgroundImage")));
            this.pnlSalesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSalesChart.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSalesChart.BorderRadius = 8;
            this.pnlSalesChart.BorderThickness = 1;
            this.pnlSalesChart.Controls.Add(this.lblSalesChartTitle);
            this.pnlSalesChart.Controls.Add(this.chartSales);
            this.pnlSalesChart.Location = new System.Drawing.Point(730, 2);
            this.pnlSalesChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSalesChart.Name = "pnlSalesChart";
            this.pnlSalesChart.ShowBorders = true;
            this.pnlSalesChart.Size = new System.Drawing.Size(335, 290);
            this.pnlSalesChart.TabIndex = 1;
            // 
            // chartSales
            // 
            this.chartSales.BackColor = System.Drawing.Color.White;
            this.chartSales.Location = new System.Drawing.Point(15, 50);
            this.chartSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSales.Name = "chartSales";
            this.chartSales.Size = new System.Drawing.Size(305, 225);
            this.chartSales.TabIndex = 1;
            // 
            // lblSalesChartTitle
            // 
            this.lblSalesChartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalesChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSalesChartTitle.Location = new System.Drawing.Point(20, 15);
            this.lblSalesChartTitle.Name = "lblSalesChartTitle";
            this.lblSalesChartTitle.Size = new System.Drawing.Size(300, 30);
            this.lblSalesChartTitle.TabIndex = 0;
            this.lblSalesChartTitle.Text = "Sales by Category";
            // 
            // pnlRevenueChart
            // 
            this.pnlRevenueChart.BackgroundColor = System.Drawing.Color.White;
            this.pnlRevenueChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRevenueChart.BackgroundImage")));
            this.pnlRevenueChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRevenueChart.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlRevenueChart.BorderRadius = 8;
            this.pnlRevenueChart.BorderThickness = 1;
            this.pnlRevenueChart.Controls.Add(this.lblRevenueChartTitle);
            this.pnlRevenueChart.Controls.Add(this.chartRevenue);
            this.pnlRevenueChart.Location = new System.Drawing.Point(0, 2);
            this.pnlRevenueChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRevenueChart.Name = "pnlRevenueChart";
            this.pnlRevenueChart.ShowBorders = true;
            this.pnlRevenueChart.Size = new System.Drawing.Size(700, 290);
            this.pnlRevenueChart.TabIndex = 0;
            // 
            // chartRevenue
            // 
            this.chartRevenue.BackColor = System.Drawing.Color.White;
            this.chartRevenue.Location = new System.Drawing.Point(15, 50);
            this.chartRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartRevenue.Name = "chartRevenue";
            this.chartRevenue.Size = new System.Drawing.Size(670, 225);
            this.chartRevenue.TabIndex = 1;
            // 
            // lblRevenueChartTitle
            // 
            this.lblRevenueChartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenueChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenueChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevenueChartTitle.Location = new System.Drawing.Point(20, 15);
            this.lblRevenueChartTitle.Name = "lblRevenueChartTitle";
            this.lblRevenueChartTitle.Size = new System.Drawing.Size(300, 30);
            this.lblRevenueChartTitle.TabIndex = 0;
            this.lblRevenueChartTitle.Text = "Revenue vs Expenses";
            // 
            // pnlCharts
            // 
            this.pnlCharts.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlCharts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCharts.BackgroundImage")));
            this.pnlCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCharts.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCharts.BorderRadius = 0;
            this.pnlCharts.BorderThickness = 0;
            this.pnlCharts.Controls.Add(this.pnlRevenueChart);
            this.pnlCharts.Controls.Add(this.pnlSalesChart);
            this.pnlCharts.Location = new System.Drawing.Point(35, 285);
            this.pnlCharts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCharts.Name = "pnlCharts";
            this.pnlCharts.ShowBorders = false;
            this.pnlCharts.Size = new System.Drawing.Size(1065, 290);
            this.pnlCharts.TabIndex = 5;
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "DashboardPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardOrders.ResumeLayout(false);
            this.cardCustomers.ResumeLayout(false);
            this.cardProducts.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlRecentOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.pnlLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.pnlSalesChart.ResumeLayout(false);
            this.pnlRevenueChart.ResumeLayout(false);
            this.pnlCharts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardRevenue;
        private System.Windows.Forms.Label lblRevenueChange;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardOrders;
        private System.Windows.Forms.Label lblOrdersChange;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Label lblOrdersTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardCustomers;
        private System.Windows.Forms.Label lblCustomersChange;
        private System.Windows.Forms.Label lblCustomersValue;
        private System.Windows.Forms.Label lblCustomersTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardProducts;
        private System.Windows.Forms.Label lblProductsChange;
        private System.Windows.Forms.Label lblProductsValue;
        private System.Windows.Forms.Label lblProductsTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlBottom;
        private Bunifu.UI.WinForms.BunifuPanel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrdersTitle;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvRecentOrders;
        private Bunifu.UI.WinForms.BunifuPanel pnlLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvLowStock;
        private Bunifu.UI.WinForms.BunifuPanel pnlCharts;
        private Bunifu.UI.WinForms.BunifuPanel pnlRevenueChart;
        private System.Windows.Forms.Label lblRevenueChartTitle;
        private LiveCharts.WinForms.CartesianChart chartRevenue;
        private Bunifu.UI.WinForms.BunifuPanel pnlSalesChart;
        private System.Windows.Forms.Label lblSalesChartTitle;
        private LiveCharts.WinForms.PieChart chartSales;
    }
}