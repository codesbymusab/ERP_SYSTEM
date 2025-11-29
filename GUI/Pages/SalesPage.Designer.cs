namespace ERP_System.GUI.Pages
{
    partial class SalesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.cardTotalSales = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSalesSub = new System.Windows.Forms.Label();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.cardTotalRevenue = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblRevenueValue = new System.Windows.Forms.Label();
            this.lblRevenueSub = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.cardPending = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.lblPendingSub = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.cardDrafts = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDraftsValue = new System.Windows.Forms.Label();
            this.lblDraftsSub = new System.Windows.Forms.Label();
            this.lblDraftsTitle = new System.Windows.Forms.Label();
            this.pnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            this.ddlFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblListHeader = new System.Windows.Forms.Label();
            this.dgvInvoices = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnNewSale = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cardTotalSales.SuspendLayout();
            this.cardTotalRevenue.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardDrafts.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.White;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.cardTotalSales);
            this.pnlMain.Controls.Add(this.cardTotalRevenue);
            this.pnlMain.Controls.Add(this.cardPending);
            this.pnlMain.Controls.Add(this.cardDrafts);
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1155, 687);
            this.pnlMain.TabIndex = 9;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.BackgroundColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlHeader.BorderRadius = 8;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Location = new System.Drawing.Point(220, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(916, 64);
            this.pnlHeader.TabIndex = 29;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(676, 19);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Saturday, November 22, 2025";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageTitle.Location = new System.Drawing.Point(14, 19);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(55, 25);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Sales";
            // 
            // cardTotalSales
            // 
            this.cardTotalSales.BackgroundColor = System.Drawing.Color.White;
            this.cardTotalSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardTotalSales.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardTotalSales.BorderRadius = 20;
            this.cardTotalSales.BorderThickness = 1;
            this.cardTotalSales.Controls.Add(this.lblTotalSalesValue);
            this.cardTotalSales.Controls.Add(this.lblTotalSalesSub);
            this.cardTotalSales.Controls.Add(this.lblTotalSalesTitle);
            this.cardTotalSales.Location = new System.Drawing.Point(256, 106);
            this.cardTotalSales.Margin = new System.Windows.Forms.Padding(2);
            this.cardTotalSales.Name = "cardTotalSales";
            this.cardTotalSales.ShowBorders = true;
            this.cardTotalSales.Size = new System.Drawing.Size(262, 127);
            this.cardTotalSales.TabIndex = 31;
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSalesValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSalesValue.Location = new System.Drawing.Point(19, 69);
            this.lblTotalSalesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSalesValue.Size = new System.Drawing.Size(96, 19);
            this.lblTotalSalesValue.TabIndex = 4;
            this.lblTotalSalesValue.Text = "5";
            // 
            // lblTotalSalesSub
            // 
            this.lblTotalSalesSub.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSalesSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalSalesSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesSub.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSalesSub.Location = new System.Drawing.Point(17, 97);
            this.lblTotalSalesSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSalesSub.Name = "lblTotalSalesSub";
            this.lblTotalSalesSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSalesSub.Size = new System.Drawing.Size(76, 22);
            this.lblTotalSalesSub.TabIndex = 3;
            this.lblTotalSalesSub.Text = "All Time";
            // 
            // lblTotalSalesTitle
            // 
            this.lblTotalSalesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSalesTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(18, 18);
            this.lblTotalSalesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            this.lblTotalSalesTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalSalesTitle.Size = new System.Drawing.Size(107, 19);
            this.lblTotalSalesTitle.TabIndex = 1;
            this.lblTotalSalesTitle.Text = "Total Sales";
            // 
            // cardTotalRevenue
            // 
            this.cardTotalRevenue.BackgroundColor = System.Drawing.Color.White;
            this.cardTotalRevenue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardTotalRevenue.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardTotalRevenue.BorderRadius = 20;
            this.cardTotalRevenue.BorderThickness = 1;
            this.cardTotalRevenue.Controls.Add(this.lblRevenueValue);
            this.cardTotalRevenue.Controls.Add(this.lblRevenueSub);
            this.cardTotalRevenue.Controls.Add(this.lblRevenueTitle);
            this.cardTotalRevenue.Location = new System.Drawing.Point(544, 106);
            this.cardTotalRevenue.Margin = new System.Windows.Forms.Padding(2);
            this.cardTotalRevenue.Name = "cardTotalRevenue";
            this.cardTotalRevenue.ShowBorders = true;
            this.cardTotalRevenue.Size = new System.Drawing.Size(262, 127);
            this.cardTotalRevenue.TabIndex = 33;
            // 
            // lblRevenueValue
            // 
            this.lblRevenueValue.BackColor = System.Drawing.Color.White;
            this.lblRevenueValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRevenueValue.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevenueValue.Location = new System.Drawing.Point(19, 69);
            this.lblRevenueValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueValue.Name = "lblRevenueValue";
            this.lblRevenueValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRevenueValue.Size = new System.Drawing.Size(96, 19);
            this.lblRevenueValue.TabIndex = 4;
            this.lblRevenueValue.Text = "$44108.27";
            // 
            // lblRevenueSub
            // 
            this.lblRevenueSub.BackColor = System.Drawing.Color.White;
            this.lblRevenueSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRevenueSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueSub.ForeColor = System.Drawing.Color.Gray;
            this.lblRevenueSub.Location = new System.Drawing.Point(17, 97);
            this.lblRevenueSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueSub.Name = "lblRevenueSub";
            this.lblRevenueSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRevenueSub.Size = new System.Drawing.Size(110, 22);
            this.lblRevenueSub.TabIndex = 3;
            this.lblRevenueSub.Text = "Paid Invoices";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.BackColor = System.Drawing.Color.White;
            this.lblRevenueTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRevenueTitle.Location = new System.Drawing.Point(18, 18);
            this.lblRevenueTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRevenueTitle.Size = new System.Drawing.Size(154, 19);
            this.lblRevenueTitle.TabIndex = 1;
            this.lblRevenueTitle.Text = "Total Revnue";
            // 
            // cardPending
            // 
            this.cardPending.BackgroundColor = System.Drawing.Color.White;
            this.cardPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardPending.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardPending.BorderRadius = 20;
            this.cardPending.BorderThickness = 1;
            this.cardPending.Controls.Add(this.lblPendingValue);
            this.cardPending.Controls.Add(this.lblPendingSub);
            this.cardPending.Controls.Add(this.lblPendingTitle);
            this.cardPending.Location = new System.Drawing.Point(833, 106);
            this.cardPending.Margin = new System.Windows.Forms.Padding(2);
            this.cardPending.Name = "cardPending";
            this.cardPending.ShowBorders = true;
            this.cardPending.Size = new System.Drawing.Size(262, 127);
            this.cardPending.TabIndex = 34;
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.BackColor = System.Drawing.Color.White;
            this.lblPendingValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPendingValue.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPendingValue.Location = new System.Drawing.Point(19, 69);
            this.lblPendingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPendingValue.Size = new System.Drawing.Size(96, 19);
            this.lblPendingValue.TabIndex = 4;
            this.lblPendingValue.Text = "1";
            // 
            // lblPendingSub
            // 
            this.lblPendingSub.BackColor = System.Drawing.Color.White;
            this.lblPendingSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPendingSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingSub.ForeColor = System.Drawing.Color.Gray;
            this.lblPendingSub.Location = new System.Drawing.Point(17, 97);
            this.lblPendingSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingSub.Name = "lblPendingSub";
            this.lblPendingSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPendingSub.Size = new System.Drawing.Size(126, 22);
            this.lblPendingSub.TabIndex = 3;
            this.lblPendingSub.Text = "Awaiting Paymnet";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.BackColor = System.Drawing.Color.White;
            this.lblPendingTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPendingTitle.Location = new System.Drawing.Point(18, 18);
            this.lblPendingTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPendingTitle.Size = new System.Drawing.Size(107, 19);
            this.lblPendingTitle.TabIndex = 1;
            this.lblPendingTitle.Text = "Pending";
            // 
            // cardDrafts
            // 
            this.cardDrafts.BackgroundColor = System.Drawing.Color.White;
            this.cardDrafts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardDrafts.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardDrafts.BorderRadius = 20;
            this.cardDrafts.BorderThickness = 1;
            this.cardDrafts.Controls.Add(this.lblDraftsValue);
            this.cardDrafts.Controls.Add(this.lblDraftsSub);
            this.cardDrafts.Controls.Add(this.lblDraftsTitle);
            this.cardDrafts.Location = new System.Drawing.Point(1124, 103);
            this.cardDrafts.Margin = new System.Windows.Forms.Padding(2);
            this.cardDrafts.Name = "cardDrafts";
            this.cardDrafts.ShowBorders = true;
            this.cardDrafts.Size = new System.Drawing.Size(262, 127);
            this.cardDrafts.TabIndex = 35;
            // 
            // lblDraftsValue
            // 
            this.lblDraftsValue.BackColor = System.Drawing.Color.White;
            this.lblDraftsValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDraftsValue.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDraftsValue.Location = new System.Drawing.Point(19, 69);
            this.lblDraftsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDraftsValue.Name = "lblDraftsValue";
            this.lblDraftsValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDraftsValue.Size = new System.Drawing.Size(96, 19);
            this.lblDraftsValue.TabIndex = 4;
            this.lblDraftsValue.Text = "5";
            // 
            // lblDraftsSub
            // 
            this.lblDraftsSub.BackColor = System.Drawing.Color.White;
            this.lblDraftsSub.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDraftsSub.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftsSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDraftsSub.Location = new System.Drawing.Point(17, 97);
            this.lblDraftsSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDraftsSub.Name = "lblDraftsSub";
            this.lblDraftsSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDraftsSub.Size = new System.Drawing.Size(76, 22);
            this.lblDraftsSub.TabIndex = 3;
            this.lblDraftsSub.Text = "Incomplete";
            // 
            // lblDraftsTitle
            // 
            this.lblDraftsTitle.BackColor = System.Drawing.Color.White;
            this.lblDraftsTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDraftsTitle.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraftsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDraftsTitle.Location = new System.Drawing.Point(16, 18);
            this.lblDraftsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDraftsTitle.Name = "lblDraftsTitle";
            this.lblDraftsTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDraftsTitle.Size = new System.Drawing.Size(138, 19);
            this.lblDraftsTitle.TabIndex = 1;
            this.lblDraftsTitle.Text = "Darfts";
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundColor = System.Drawing.Color.White;
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlContent.BorderRadius = 20;
            this.pnlContent.BorderThickness = 1;
            this.pnlContent.Controls.Add(this.ddlFilter);
            this.pnlContent.Controls.Add(this.lblListHeader);
            this.pnlContent.Controls.Add(this.dgvInvoices);
            this.pnlContent.Controls.Add(this.btnNewSale);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Location = new System.Drawing.Point(256, 247);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShowBorders = true;
            this.pnlContent.Size = new System.Drawing.Size(1130, 441);
            this.pnlContent.TabIndex = 32;
            // 
            // ddlFilter
            // 
            this.ddlFilter.BackColor = System.Drawing.Color.Transparent;
            this.ddlFilter.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ddlFilter.BorderColor = System.Drawing.Color.Gainsboro;
            this.ddlFilter.BorderRadius = 10;
            this.ddlFilter.Color = System.Drawing.Color.Gainsboro;
            this.ddlFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlFilter.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlFilter.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlFilter.FillDropDown = true;
            this.ddlFilter.FillIndicator = false;
            this.ddlFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlFilter.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddlFilter.FormattingEnabled = true;
            this.ddlFilter.Icon = null;
            this.ddlFilter.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlFilter.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlFilter.IndicatorThickness = 2;
            this.ddlFilter.IsDropdownOpened = false;
            this.ddlFilter.ItemBackColor = System.Drawing.Color.White;
            this.ddlFilter.ItemBorderColor = System.Drawing.Color.White;
            this.ddlFilter.ItemForeColor = System.Drawing.Color.Black;
            this.ddlFilter.ItemHeight = 40;
            this.ddlFilter.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlFilter.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlFilter.ItemTopMargin = 3;
            this.ddlFilter.Location = new System.Drawing.Point(1186, 68);
            this.ddlFilter.Margin = new System.Windows.Forms.Padding(2);
            this.ddlFilter.Name = "ddlFilter";
            this.ddlFilter.Size = new System.Drawing.Size(114, 46);
            this.ddlFilter.TabIndex = 19;
            this.ddlFilter.Text = "All";
            this.ddlFilter.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlFilter.TextLeftMargin = 5;
            // 
            // lblListHeader
            // 
            this.lblListHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblListHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListHeader.Location = new System.Drawing.Point(16, 20);
            this.lblListHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListHeader.Name = "lblListHeader";
            this.lblListHeader.Size = new System.Drawing.Size(145, 26);
            this.lblListHeader.TabIndex = 13;
            this.lblListHeader.Text = "Sales && Invoices";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowCustomTheming = false;
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.ColumnHeadersHeight = 40;
            this.dgvInvoices.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvInvoices.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInvoices.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInvoices.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvInvoices.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInvoices.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInvoices.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvInvoices.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInvoices.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvInvoices.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInvoices.CurrentTheme.Name = null;
            this.dgvInvoices.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvInvoices.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvInvoices.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvInvoices.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvInvoices.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoices.EnableHeadersVisualStyles = false;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvInvoices.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvInvoices.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvInvoices.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInvoices.Location = new System.Drawing.Point(22, 119);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.RowHeadersWidth = 53;
            this.dgvInvoices.RowTemplate.Height = 40;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1088, 301);
            this.dgvInvoices.TabIndex = 12;
            this.dgvInvoices.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnNewSale
            // 
            this.btnNewSale.AllowAnimations = true;
            this.btnNewSale.AllowMouseEffects = true;
            this.btnNewSale.AllowToggling = false;
            this.btnNewSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSale.AnimationSpeed = 200;
            this.btnNewSale.AutoGenerateColors = false;
            this.btnNewSale.AutoRoundBorders = false;
            this.btnNewSale.AutoSizeLeftIcon = true;
            this.btnNewSale.AutoSizeRightIcon = true;
            this.btnNewSale.BackColor = System.Drawing.Color.Transparent;
            this.btnNewSale.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewSale.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewSale.ButtonText = "+ New Sale";
            this.btnNewSale.ButtonTextMarginLeft = 0;
            this.btnNewSale.ColorContrastOnClick = 45;
            this.btnNewSale.ColorContrastOnHover = 45;
            this.btnNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNewSale.CustomizableEdges = borderEdges1;
            this.btnNewSale.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewSale.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNewSale.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNewSale.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNewSale.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNewSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewSale.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.IconLeft = null;
            this.btnNewSale.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSale.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSale.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNewSale.IconMarginLeft = 11;
            this.btnNewSale.IconPadding = 10;
            this.btnNewSale.IconRight = null;
            this.btnNewSale.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSale.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSale.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNewSale.IconSize = 25;
            this.btnNewSale.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewSale.IdleBorderRadius = 6;
            this.btnNewSale.IdleBorderThickness = 1;
            this.btnNewSale.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewSale.IdleIconLeftImage = null;
            this.btnNewSale.IdleIconRightImage = null;
            this.btnNewSale.IndicateFocus = false;
            this.btnNewSale.Location = new System.Drawing.Point(993, 20);
            this.btnNewSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNewSale.OnDisabledState.BorderRadius = 15;
            this.btnNewSale.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewSale.OnDisabledState.BorderThickness = 1;
            this.btnNewSale.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNewSale.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNewSale.OnDisabledState.IconLeftImage = null;
            this.btnNewSale.OnDisabledState.IconRightImage = null;
            this.btnNewSale.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewSale.onHoverState.BorderRadius = 15;
            this.btnNewSale.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewSale.onHoverState.BorderThickness = 1;
            this.btnNewSale.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnNewSale.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.onHoverState.IconLeftImage = null;
            this.btnNewSale.onHoverState.IconRightImage = null;
            this.btnNewSale.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnNewSale.OnIdleState.BorderRadius = 15;
            this.btnNewSale.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewSale.OnIdleState.BorderThickness = 1;
            this.btnNewSale.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnNewSale.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.OnIdleState.IconLeftImage = null;
            this.btnNewSale.OnIdleState.IconRightImage = null;
            this.btnNewSale.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewSale.OnPressedState.BorderRadius = 15;
            this.btnNewSale.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewSale.OnPressedState.BorderThickness = 1;
            this.btnNewSale.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnNewSale.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNewSale.OnPressedState.IconLeftImage = null;
            this.btnNewSale.OnPressedState.IconRightImage = null;
            this.btnNewSale.Size = new System.Drawing.Size(112, 33);
            this.btnNewSale.TabIndex = 10;
            this.btnNewSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewSale.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewSale.TextMarginLeft = 0;
            this.btnNewSale.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNewSale.UseDefaultRadiusAndThickness = true;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.LightGray;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(22, 68);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaxLength = 256;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.LightGray;
            stateProperties1.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties3.FillColor = System.Drawing.Color.Silver;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.LightGray;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Search by invoices or customer...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(1083, 44);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search by invoices or customer...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // SalesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "SalesPage";
            this.Size = new System.Drawing.Size(1155, 687);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.cardTotalSales.ResumeLayout(false);
            this.cardTotalRevenue.ResumeLayout(false);
            this.cardPending.ResumeLayout(false);
            this.cardDrafts.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardTotalSales;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.Label lblTotalSalesSub;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardTotalRevenue;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueSub;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardPending;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Label lblPendingSub;
        private System.Windows.Forms.Label lblPendingTitle;
        private Bunifu.UI.WinForms.BunifuPanel cardDrafts;
        private System.Windows.Forms.Label lblDraftsValue;
        private System.Windows.Forms.Label lblDraftsSub;
        private System.Windows.Forms.Label lblDraftsTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlContent;
        private Bunifu.UI.WinForms.BunifuDropdown ddlFilter;
        private System.Windows.Forms.Label lblListHeader;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvInvoices;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewSale;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
    }
}