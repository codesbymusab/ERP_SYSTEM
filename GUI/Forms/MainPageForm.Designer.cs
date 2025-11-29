namespace ERP_System
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.ucEmployees = new ERP_System.GUI.Pages.EmployeesPage();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.ucProducts = new ERP_System.GUI.Pages.ProductPage();
            this.tabStockAdj = new System.Windows.Forms.TabPage();
            this.ucStockAdj = new ERP_System.GUI.Pages.StockAdjustmentPage();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.ucSuppliers = new ERP_System.GUI.Pages.SuppliersPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.ucHistory = new ERP_System.GUI.Pages.TransactionHistoryPage();
            this.tabPurchases = new System.Windows.Forms.TabPage();
            this.ucPurchases = new ERP_System.GUI.Pages.PurchasesPage();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.ucSales = new ERP_System.GUI.Pages.SalesPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.ucReports = new ERP_System.GUI.Pages.ReportsPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.ucProfile = new ERP_System.GUI.Pages.ProfilePage();
            this.pnlFooter = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.sideNavBar1 = new ERP_System.GUI.SideNavBar();
            this.bunifuPages1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.tabStockAdj.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabPurchases.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.bunifuPages1.AllowTransitions = false;
            this.bunifuPages1.Controls.Add(this.tabDashboard);
            this.bunifuPages1.Controls.Add(this.tabEmployees);
            this.bunifuPages1.Controls.Add(this.tabProducts);
            this.bunifuPages1.Controls.Add(this.tabStockAdj);
            this.bunifuPages1.Controls.Add(this.tabSuppliers);
            this.bunifuPages1.Controls.Add(this.tabHistory);
            this.bunifuPages1.Controls.Add(this.tabPurchases);
            this.bunifuPages1.Controls.Add(this.tabSales);
            this.bunifuPages1.Controls.Add(this.tabReports);
            this.bunifuPages1.Controls.Add(this.tabProfile);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(305, 0);
            this.bunifuPages1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabDashboard;
            this.bunifuPages1.PageIndex = 0;
            this.bunifuPages1.PageName = "tabDashboard";
            this.bunifuPages1.PageTitle = "DashBoard";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(1235, 818);
            this.bunifuPages1.TabIndex = 2;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Location = new System.Drawing.Point(4, 4);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(1206, 810);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "DashBoard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.ucEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 4);
            this.tabEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(1206, 800);
            this.tabEmployees.TabIndex = 1;
            this.tabEmployees.Text = "Employees";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // ucEmployees
            // 
            this.ucEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmployees.Location = new System.Drawing.Point(0, 0);
            this.ucEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.ucEmployees.Name = "ucEmployees";
            this.ucEmployees.Size = new System.Drawing.Size(1206, 800);
            this.ucEmployees.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.ucProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 4);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(4);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(1206, 800);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "ProductPage";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // ucProducts
            // 
            this.ucProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProducts.Location = new System.Drawing.Point(0, 0);
            this.ucProducts.Margin = new System.Windows.Forms.Padding(5);
            this.ucProducts.Name = "ucProducts";
            this.ucProducts.Size = new System.Drawing.Size(1206, 800);
            this.ucProducts.TabIndex = 0;
            // 
            // tabStockAdj
            // 
            this.tabStockAdj.Controls.Add(this.ucStockAdj);
            this.tabStockAdj.Location = new System.Drawing.Point(4, 4);
            this.tabStockAdj.Margin = new System.Windows.Forms.Padding(4);
            this.tabStockAdj.Name = "tabStockAdj";
            this.tabStockAdj.Size = new System.Drawing.Size(1206, 800);
            this.tabStockAdj.TabIndex = 3;
            this.tabStockAdj.Text = "StkAdjPage";
            this.tabStockAdj.UseVisualStyleBackColor = true;
            // 
            // ucStockAdj
            // 
            this.ucStockAdj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStockAdj.Location = new System.Drawing.Point(0, 0);
            this.ucStockAdj.Margin = new System.Windows.Forms.Padding(5);
            this.ucStockAdj.Name = "ucStockAdj";
            this.ucStockAdj.Size = new System.Drawing.Size(1206, 800);
            this.ucStockAdj.TabIndex = 0;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.ucSuppliers);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 4);
            this.tabSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1206, 800);
            this.tabSuppliers.TabIndex = 4;
            this.tabSuppliers.Text = "SupplierPage";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // ucSuppliers
            // 
            this.ucSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuppliers.Location = new System.Drawing.Point(0, 0);
            this.ucSuppliers.Margin = new System.Windows.Forms.Padding(5);
            this.ucSuppliers.Name = "ucSuppliers";
            this.ucSuppliers.Size = new System.Drawing.Size(1206, 800);
            this.ucSuppliers.TabIndex = 0;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.ucHistory);
            this.tabHistory.Location = new System.Drawing.Point(4, 4);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Size = new System.Drawing.Size(1206, 800);
            this.tabHistory.TabIndex = 5;
            this.tabHistory.Text = "HistoryPage";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // ucHistory
            // 
            this.ucHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHistory.Location = new System.Drawing.Point(0, 0);
            this.ucHistory.Margin = new System.Windows.Forms.Padding(5);
            this.ucHistory.Name = "ucHistory";
            this.ucHistory.Size = new System.Drawing.Size(1206, 800);
            this.ucHistory.TabIndex = 0;
            // 
            // tabPurchases
            // 
            this.tabPurchases.Controls.Add(this.ucPurchases);
            this.tabPurchases.Location = new System.Drawing.Point(4, 4);
            this.tabPurchases.Margin = new System.Windows.Forms.Padding(4);
            this.tabPurchases.Name = "tabPurchases";
            this.tabPurchases.Size = new System.Drawing.Size(1206, 800);
            this.tabPurchases.TabIndex = 6;
            this.tabPurchases.Text = "PurPage";
            this.tabPurchases.UseVisualStyleBackColor = true;
            // 
            // ucPurchases
            // 
            this.ucPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPurchases.Location = new System.Drawing.Point(0, 0);
            this.ucPurchases.Margin = new System.Windows.Forms.Padding(5);
            this.ucPurchases.Name = "ucPurchases";
            this.ucPurchases.Size = new System.Drawing.Size(1206, 800);
            this.ucPurchases.TabIndex = 0;
            // 
            // tabSales
            // 
            this.tabSales.Controls.Add(this.ucSales);
            this.tabSales.Location = new System.Drawing.Point(4, 4);
            this.tabSales.Margin = new System.Windows.Forms.Padding(4);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(1206, 800);
            this.tabSales.TabIndex = 7;
            this.tabSales.Text = "SalesPage";
            this.tabSales.UseVisualStyleBackColor = true;
            // 
            // ucSales
            // 
            this.ucSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSales.Location = new System.Drawing.Point(0, 0);
            this.ucSales.Margin = new System.Windows.Forms.Padding(5);
            this.ucSales.Name = "ucSales";
            this.ucSales.Size = new System.Drawing.Size(1206, 800);
            this.ucSales.TabIndex = 0;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.ucReports);
            this.tabReports.Location = new System.Drawing.Point(4, 4);
            this.tabReports.Margin = new System.Windows.Forms.Padding(4);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(1206, 800);
            this.tabReports.TabIndex = 8;
            this.tabReports.Text = "ReportsPage";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // ucReports
            // 
            this.ucReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports.Location = new System.Drawing.Point(0, 0);
            this.ucReports.Margin = new System.Windows.Forms.Padding(5);
            this.ucReports.Name = "ucReports";
            this.ucReports.Size = new System.Drawing.Size(1206, 800);
            this.ucReports.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.ucProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 4);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(4);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1206, 800);
            this.tabProfile.TabIndex = 9;
            this.tabProfile.Text = "UserProfile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // ucProfile
            // 
            this.ucProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucProfile.Location = new System.Drawing.Point(0, 0);
            this.ucProfile.Margin = new System.Windows.Forms.Padding(5);
            this.ucProfile.Name = "ucProfile";
            this.ucProfile.Size = new System.Drawing.Size(1206, 800);
            this.ucProfile.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.AutoSize = true;
            this.pnlFooter.BackgroundColor = System.Drawing.Color.White;
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.BorderColor = System.Drawing.Color.LightGray;
            this.pnlFooter.BorderRadius = 3;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.lblConnection);
            this.pnlFooter.Controls.Add(this.lblUserInfo);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 818);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.ShowBorders = true;
            this.pnlFooter.Size = new System.Drawing.Size(1540, 28);
            this.pnlFooter.TabIndex = 9;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblConnection.Location = new System.Drawing.Point(1371, 2);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnection.Size = new System.Drawing.Size(157, 21);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "Status: Connected";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserInfo.Location = new System.Drawing.Point(12, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserInfo.Size = new System.Drawing.Size(528, 28);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "User: admin@company.com | Role: Administrator";
            // 
            // sideNavBar1
            // 
            this.sideNavBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavBar1.Location = new System.Drawing.Point(0, 0);
            this.sideNavBar1.Margin = new System.Windows.Forms.Padding(0);
            this.sideNavBar1.Name = "sideNavBar1";
            this.sideNavBar1.Size = new System.Drawing.Size(305, 818);
            this.sideNavBar1.TabIndex = 1;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1540, 846);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.sideNavBar1);
            this.Controls.Add(this.pnlFooter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPageForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuPages1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.tabStockAdj.ResumeLayout(false);
            this.tabSuppliers.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabPurchases.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabEmployees;
        private ERP_System.GUI.Pages.EmployeesPage ucEmployees;
        private System.Windows.Forms.TabPage tabProducts;
        private ERP_System.GUI.Pages.ProductPage ucProducts;
        private System.Windows.Forms.TabPage tabStockAdj;
        private ERP_System.GUI.Pages.StockAdjustmentPage ucStockAdj;
        private System.Windows.Forms.TabPage tabSuppliers;
        private ERP_System.GUI.Pages.SuppliersPage ucSuppliers;
        private System.Windows.Forms.TabPage tabHistory;
        private ERP_System.GUI.Pages.TransactionHistoryPage ucHistory;
        private System.Windows.Forms.TabPage tabPurchases;
        private ERP_System.GUI.Pages.PurchasesPage ucPurchases;
        private System.Windows.Forms.TabPage tabSales;
        private ERP_System.GUI.Pages.SalesPage ucSales;
        private System.Windows.Forms.TabPage tabReports;
        private ERP_System.GUI.Pages.ReportsPage ucReports;
        private System.Windows.Forms.TabPage tabProfile;
        private ERP_System.GUI.Pages.ProfilePage ucProfile;
        private Bunifu.UI.WinForms.BunifuPanel pnlFooter;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserInfo;
        private GUI.SideNavBar sideNavBar1;
    }
}