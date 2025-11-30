namespace ERP_System.GUI.Pages
{
    partial class ProductPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            this.tabProducts = new TradeWright.UI.Forms.TabControlExtra();
            this.tabAllProducts = new System.Windows.Forms.TabPage();
            this.tabLowStock = new System.Windows.Forms.TabPage();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.cardOutOfStock = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblOutofStck = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.cardLowStock = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblLowStk = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.cardInventoryValue = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblValue = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pnlGridContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblProductListHeader = new System.Windows.Forms.Label();
            this.dgvProducts = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnAddProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.cardTotalProducts = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.pnlLowStockContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLowStockHeader = new System.Windows.Forms.Label();
            this.pnlSupplierContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblSupplierHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.supplierProductsCard1 = new ERP_System.GUI.Components.SupplierProductsCard();
            this.tabProducts.SuspendLayout();
            this.tabAllProducts.SuspendLayout();
            this.tabLowStock.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.cardOutOfStock.SuspendLayout();
            this.cardLowStock.SuspendLayout();
            this.cardInventoryValue.SuspendLayout();
            this.pnlGridContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cardTotalProducts.SuspendLayout();
            this.pnlLowStockContainer.SuspendLayout();
            this.pnlSupplierContainer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tabAllProducts);
            this.tabProducts.Controls.Add(this.tabLowStock);
            this.tabProducts.Controls.Add(this.tabSuppliers);
            this.tabProducts.DisplayStyle = TradeWright.UI.Forms.TabStyle.Rounded;
            // 
            // 
            // 
            this.tabProducts.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabProducts.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabProducts.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabProducts.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabProducts.DisplayStyleProvider.FocusTrack = false;
            this.tabProducts.DisplayStyleProvider.HotTrack = true;
            this.tabProducts.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabProducts.DisplayStyleProvider.Opacity = 1F;
            this.tabProducts.DisplayStyleProvider.Overlap = 0;
            this.tabProducts.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.tabProducts.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabProducts.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabProducts.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabProducts.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.Radius = 10;
            this.tabProducts.DisplayStyleProvider.SelectedTabIsLarger = false;
            this.tabProducts.DisplayStyleProvider.ShowTabCloser = false;
            this.tabProducts.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.TabColorFocused1 = System.Drawing.SystemColors.ControlLight;
            this.tabProducts.DisplayStyleProvider.TabColorFocused2 = System.Drawing.SystemColors.ControlLight;
            this.tabProducts.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabProducts.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabProducts.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabProducts.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabProducts.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabProducts.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabProducts.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabProducts.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabProducts.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabProducts.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabProducts.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlText;
            this.tabProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.HotTrack = true;
            this.tabProducts.Location = new System.Drawing.Point(51, 117);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.SelectedIndex = 0;
            this.tabProducts.Size = new System.Drawing.Size(1533, 757);
            this.tabProducts.TabIndex = 11;
            // 
            // tabAllProducts
            // 
            this.tabAllProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAllProducts.Controls.Add(this.cardOutOfStock);
            this.tabAllProducts.Controls.Add(this.cardLowStock);
            this.tabAllProducts.Controls.Add(this.cardInventoryValue);
            this.tabAllProducts.Controls.Add(this.pnlGridContainer);
            this.tabAllProducts.Controls.Add(this.cardTotalProducts);
            this.tabAllProducts.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAllProducts.ForeColor = System.Drawing.Color.Black;
            this.tabAllProducts.Location = new System.Drawing.Point(4, 30);
            this.tabAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllProducts.Name = "tabAllProducts";
            this.tabAllProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllProducts.Size = new System.Drawing.Size(1525, 723);
            this.tabAllProducts.TabIndex = 0;
            this.tabAllProducts.Text = "All Products";
            this.tabAllProducts.UseVisualStyleBackColor = true;
            this.tabAllProducts.UseWaitCursor = true;
            // 
            // tabLowStock
            // 
            this.tabLowStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLowStock.Controls.Add(this.pnlLowStockContainer);
            this.tabLowStock.Location = new System.Drawing.Point(4, 30);
            this.tabLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLowStock.Name = "tabLowStock";
            this.tabLowStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabLowStock.Size = new System.Drawing.Size(1525, 723);
            this.tabLowStock.TabIndex = 1;
            this.tabLowStock.Text = "Low Stock";
            this.tabLowStock.UseVisualStyleBackColor = true;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSuppliers.Controls.Add(this.pnlSupplierContainer);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 30);
            this.tabSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1525, 723);
            this.tabSuppliers.TabIndex = 2;
            this.tabSuppliers.Text = "Supplier Summary";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // cardOutOfStock
            // 
            this.cardOutOfStock.BackgroundColor = System.Drawing.Color.White;
            this.cardOutOfStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardOutOfStock.BackgroundImage")));
            this.cardOutOfStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardOutOfStock.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardOutOfStock.BorderRadius = 20;
            this.cardOutOfStock.BorderThickness = 1;
            this.cardOutOfStock.Controls.Add(this.lblOutofStck);
            this.cardOutOfStock.Controls.Add(this.label50);
            this.cardOutOfStock.Controls.Add(this.label51);
            this.cardOutOfStock.Controls.Add(this.label52);
            this.cardOutOfStock.Location = new System.Drawing.Point(1136, 25);
            this.cardOutOfStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardOutOfStock.Name = "cardOutOfStock";
            this.cardOutOfStock.ShowBorders = true;
            this.cardOutOfStock.Size = new System.Drawing.Size(349, 156);
            this.cardOutOfStock.TabIndex = 16;
            this.cardOutOfStock.UseWaitCursor = true;
            // 
            // lblOutofStck
            // 
            this.lblOutofStck.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblOutofStck.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutofStck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOutofStck.Location = new System.Drawing.Point(24, 85);
            this.lblOutofStck.Name = "lblOutofStck";
            this.lblOutofStck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutofStck.Size = new System.Drawing.Size(134, 34);
            this.lblOutofStck.TabIndex = 4;
            this.lblOutofStck.Text = "5";
            this.lblOutofStck.UseWaitCursor = true;
            // 
            // label50
            // 
            this.label50.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label50.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.Red;
            this.label50.Location = new System.Drawing.Point(23, 119);
            this.label50.Name = "label50";
            this.label50.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label50.Size = new System.Drawing.Size(101, 27);
            this.label50.TabIndex = 3;
            this.label50.Text = "Urgent";
            this.label50.UseWaitCursor = true;
            // 
            // label51
            // 
            this.label51.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label51.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label51.Location = new System.Drawing.Point(24, 62);
            this.label51.Name = "label51";
            this.label51.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label51.Size = new System.Drawing.Size(9, 23);
            this.label51.TabIndex = 2;
            this.label51.Text = "5";
            this.label51.UseWaitCursor = true;
            // 
            // label52
            // 
            this.label52.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label52.Location = new System.Drawing.Point(24, 22);
            this.label52.Name = "label52";
            this.label52.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label52.Size = new System.Drawing.Size(184, 23);
            this.label52.TabIndex = 1;
            this.label52.Text = "Out of Stock";
            this.label52.UseWaitCursor = true;
            // 
            // cardLowStock
            // 
            this.cardLowStock.BackgroundColor = System.Drawing.Color.White;
            this.cardLowStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardLowStock.BackgroundImage")));
            this.cardLowStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardLowStock.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardLowStock.BorderRadius = 20;
            this.cardLowStock.BorderThickness = 1;
            this.cardLowStock.Controls.Add(this.lblLowStk);
            this.cardLowStock.Controls.Add(this.label54);
            this.cardLowStock.Controls.Add(this.label55);
            this.cardLowStock.Controls.Add(this.label56);
            this.cardLowStock.Location = new System.Drawing.Point(765, 25);
            this.cardLowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardLowStock.Name = "cardLowStock";
            this.cardLowStock.ShowBorders = true;
            this.cardLowStock.Size = new System.Drawing.Size(349, 156);
            this.cardLowStock.TabIndex = 15;
            this.cardLowStock.UseWaitCursor = true;
            // 
            // lblLowStk
            // 
            this.lblLowStk.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblLowStk.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLowStk.Location = new System.Drawing.Point(24, 85);
            this.lblLowStk.Name = "lblLowStk";
            this.lblLowStk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLowStk.Size = new System.Drawing.Size(143, 34);
            this.lblLowStk.TabIndex = 4;
            this.lblLowStk.Text = "1";
            this.lblLowStk.UseWaitCursor = true;
            // 
            // label54
            // 
            this.label54.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label54.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.DarkOrange;
            this.label54.Location = new System.Drawing.Point(23, 119);
            this.label54.Name = "label54";
            this.label54.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label54.Size = new System.Drawing.Size(168, 27);
            this.label54.TabIndex = 3;
            this.label54.Text = "Needs Reorder";
            this.label54.UseWaitCursor = true;
            // 
            // label55
            // 
            this.label55.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label55.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label55.Location = new System.Drawing.Point(24, 62);
            this.label55.Name = "label55";
            this.label55.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label55.Size = new System.Drawing.Size(9, 23);
            this.label55.TabIndex = 2;
            this.label55.Text = "5";
            this.label55.UseWaitCursor = true;
            // 
            // label56
            // 
            this.label56.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label56.Location = new System.Drawing.Point(24, 22);
            this.label56.Name = "label56";
            this.label56.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label56.Size = new System.Drawing.Size(143, 23);
            this.label56.TabIndex = 1;
            this.label56.Text = "Low Stock";
            this.label56.UseWaitCursor = true;
            // 
            // cardInventoryValue
            // 
            this.cardInventoryValue.BackgroundColor = System.Drawing.Color.White;
            this.cardInventoryValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardInventoryValue.BackgroundImage")));
            this.cardInventoryValue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardInventoryValue.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardInventoryValue.BorderRadius = 20;
            this.cardInventoryValue.BorderThickness = 1;
            this.cardInventoryValue.Controls.Add(this.lblValue);
            this.cardInventoryValue.Controls.Add(this.label58);
            this.cardInventoryValue.Controls.Add(this.label59);
            this.cardInventoryValue.Controls.Add(this.label60);
            this.cardInventoryValue.Location = new System.Drawing.Point(395, 25);
            this.cardInventoryValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardInventoryValue.Name = "cardInventoryValue";
            this.cardInventoryValue.ShowBorders = true;
            this.cardInventoryValue.Size = new System.Drawing.Size(349, 156);
            this.cardInventoryValue.TabIndex = 14;
            this.cardInventoryValue.UseWaitCursor = true;
            // 
            // lblValue
            // 
            this.lblValue.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValue.Location = new System.Drawing.Point(25, 85);
            this.lblValue.Name = "lblValue";
            this.lblValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblValue.Size = new System.Drawing.Size(131, 34);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "$44108.27";
            this.lblValue.UseWaitCursor = true;
            // 
            // label58
            // 
            this.label58.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label58.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.Gray;
            this.label58.Location = new System.Drawing.Point(23, 119);
            this.label58.Name = "label58";
            this.label58.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label58.Size = new System.Drawing.Size(147, 27);
            this.label58.TabIndex = 3;
            this.label58.Text = "Total Worth";
            this.label58.UseWaitCursor = true;
            // 
            // label59
            // 
            this.label59.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label59.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label59.Location = new System.Drawing.Point(24, 62);
            this.label59.Name = "label59";
            this.label59.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label59.Size = new System.Drawing.Size(9, 23);
            this.label59.TabIndex = 2;
            this.label59.Text = "5";
            this.label59.UseWaitCursor = true;
            // 
            // label60
            // 
            this.label60.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label60.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label60.Location = new System.Drawing.Point(24, 22);
            this.label60.Name = "label60";
            this.label60.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label60.Size = new System.Drawing.Size(205, 23);
            this.label60.TabIndex = 1;
            this.label60.Text = "Inventory Value";
            this.label60.UseWaitCursor = true;
            // 
            // pnlGridContainer
            // 
            this.pnlGridContainer.BackgroundColor = System.Drawing.Color.White;
            this.pnlGridContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGridContainer.BackgroundImage")));
            this.pnlGridContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGridContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlGridContainer.BorderRadius = 20;
            this.pnlGridContainer.BorderThickness = 1;
            this.pnlGridContainer.Controls.Add(this.lblProductListHeader);
            this.pnlGridContainer.Controls.Add(this.dgvProducts);
            this.pnlGridContainer.Controls.Add(this.btnAddProduct);
            this.pnlGridContainer.Controls.Add(this.txtSearch);
            this.pnlGridContainer.Location = new System.Drawing.Point(23, 201);
            this.pnlGridContainer.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.pnlGridContainer.Name = "pnlGridContainer";
            this.pnlGridContainer.ShowBorders = true;
            this.pnlGridContainer.Size = new System.Drawing.Size(1463, 496);
            this.pnlGridContainer.TabIndex = 13;
            this.pnlGridContainer.UseWaitCursor = true;
            // 
            // lblProductListHeader
            // 
            this.lblProductListHeader.AutoSize = true;
            this.lblProductListHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProductListHeader.Location = new System.Drawing.Point(21, 25);
            this.lblProductListHeader.Name = "lblProductListHeader";
            this.lblProductListHeader.Size = new System.Drawing.Size(211, 32);
            this.lblProductListHeader.TabIndex = 13;
            this.lblProductListHeader.Text = "Product Inventory";
            this.lblProductListHeader.UseWaitCursor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowCustomTheming = false;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.ColumnHeadersHeight = 40;
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvProducts.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProducts.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvProducts.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dgvProducts.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.Name = null;
            this.dgvProducts.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvProducts.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvProducts.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvProducts.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvProducts.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvProducts.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(29, 162);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 53;
            this.dgvProducts.RowTemplate.Height = 40;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1400, 309);
            this.dgvProducts.TabIndex = 12;
            this.dgvProducts.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvProducts.UseWaitCursor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AllowAnimations = true;
            this.btnAddProduct.AllowMouseEffects = true;
            this.btnAddProduct.AllowToggling = false;
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.AnimationSpeed = 200;
            this.btnAddProduct.AutoGenerateColors = false;
            this.btnAddProduct.AutoRoundBorders = false;
            this.btnAddProduct.AutoSizeLeftIcon = true;
            this.btnAddProduct.AutoSizeRightIcon = true;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProduct.ButtonText = "+ Add Product";
            this.btnAddProduct.ButtonTextMarginLeft = 0;
            this.btnAddProduct.ColorContrastOnClick = 45;
            this.btnAddProduct.ColorContrastOnHover = 45;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddProduct.CustomizableEdges = borderEdges2;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddProduct.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddProduct.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.IconLeft = null;
            this.btnAddProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.IconLeftCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddProduct.IconMarginLeft = 11;
            this.btnAddProduct.IconPadding = 10;
            this.btnAddProduct.IconRight = null;
            this.btnAddProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.IconRightCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAddProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddProduct.IconSize = 25;
            this.btnAddProduct.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddProduct.IdleBorderRadius = 6;
            this.btnAddProduct.IdleBorderThickness = 1;
            this.btnAddProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddProduct.IdleIconLeftImage = null;
            this.btnAddProduct.IdleIconRightImage = null;
            this.btnAddProduct.IndicateFocus = false;
            this.btnAddProduct.Location = new System.Drawing.Point(1280, 25);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddProduct.OnDisabledState.BorderRadius = 15;
            this.btnAddProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProduct.OnDisabledState.BorderThickness = 1;
            this.btnAddProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddProduct.OnDisabledState.IconLeftImage = null;
            this.btnAddProduct.OnDisabledState.IconRightImage = null;
            this.btnAddProduct.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.onHoverState.BorderRadius = 15;
            this.btnAddProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProduct.onHoverState.BorderThickness = 1;
            this.btnAddProduct.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.onHoverState.IconLeftImage = null;
            this.btnAddProduct.onHoverState.IconRightImage = null;
            this.btnAddProduct.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnIdleState.BorderRadius = 15;
            this.btnAddProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProduct.OnIdleState.BorderThickness = 1;
            this.btnAddProduct.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnAddProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.OnIdleState.IconLeftImage = null;
            this.btnAddProduct.OnIdleState.IconRightImage = null;
            this.btnAddProduct.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.OnPressedState.BorderRadius = 15;
            this.btnAddProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddProduct.OnPressedState.BorderThickness = 1;
            this.btnAddProduct.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.OnPressedState.IconLeftImage = null;
            this.btnAddProduct.OnPressedState.IconRightImage = null;
            this.btnAddProduct.Size = new System.Drawing.Size(149, 41);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddProduct.TextMarginLeft = 0;
            this.btnAddProduct.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddProduct.UseDefaultRadiusAndThickness = true;
            this.btnAddProduct.UseWaitCursor = true;
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
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.LightGray;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(29, 84);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 256;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties5.BorderColor = System.Drawing.Color.LightGray;
            stateProperties5.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties7.FillColor = System.Drawing.Color.Silver;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.LightGray;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties8;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(11, 6, 11, 6);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Search by SKU, name, category...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(1400, 54);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search by SKU, name, category...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.UseWaitCursor = true;
            this.txtSearch.WordWrap = true;
            // 
            // cardTotalProducts
            // 
            this.cardTotalProducts.BackgroundColor = System.Drawing.Color.White;
            this.cardTotalProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardTotalProducts.BackgroundImage")));
            this.cardTotalProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardTotalProducts.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cardTotalProducts.BorderRadius = 20;
            this.cardTotalProducts.BorderThickness = 1;
            this.cardTotalProducts.Controls.Add(this.lblTotal);
            this.cardTotalProducts.Controls.Add(this.label40);
            this.cardTotalProducts.Controls.Add(this.label41);
            this.cardTotalProducts.Controls.Add(this.label42);
            this.cardTotalProducts.Location = new System.Drawing.Point(23, 25);
            this.cardTotalProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardTotalProducts.Name = "cardTotalProducts";
            this.cardTotalProducts.ShowBorders = true;
            this.cardTotalProducts.Size = new System.Drawing.Size(349, 156);
            this.cardTotalProducts.TabIndex = 12;
            this.cardTotalProducts.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(25, 85);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(132, 34);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "5";
            this.lblTotal.UseWaitCursor = true;
            // 
            // label40
            // 
            this.label40.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.Gray;
            this.label40.Location = new System.Drawing.Point(23, 119);
            this.label40.Name = "label40";
            this.label40.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label40.Size = new System.Drawing.Size(101, 27);
            this.label40.TabIndex = 3;
            this.label40.Text = "Active SKUs";
            this.label40.UseWaitCursor = true;
            // 
            // label41
            // 
            this.label41.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label41.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label41.Location = new System.Drawing.Point(24, 62);
            this.label41.Name = "label41";
            this.label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label41.Size = new System.Drawing.Size(9, 23);
            this.label41.TabIndex = 2;
            this.label41.Text = "5";
            this.label41.UseWaitCursor = true;
            // 
            // label42
            // 
            this.label42.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label42.Location = new System.Drawing.Point(24, 22);
            this.label42.Name = "label42";
            this.label42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label42.Size = new System.Drawing.Size(143, 23);
            this.label42.TabIndex = 1;
            this.label42.Text = "Total Products";
            this.label42.UseWaitCursor = true;
            // 
            // pnlLowStockContainer
            // 
            this.pnlLowStockContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLowStockContainer.BackgroundColor = System.Drawing.Color.White;
            this.pnlLowStockContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLowStockContainer.BackgroundImage")));
            this.pnlLowStockContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLowStockContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlLowStockContainer.BorderRadius = 20;
            this.pnlLowStockContainer.BorderThickness = 1;
            this.pnlLowStockContainer.Controls.Add(this.flowLayoutPanel1);
            this.pnlLowStockContainer.Controls.Add(this.lblLowStockHeader);
            this.pnlLowStockContainer.Location = new System.Drawing.Point(33, 31);
            this.pnlLowStockContainer.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.pnlLowStockContainer.Name = "pnlLowStockContainer";
            this.pnlLowStockContainer.ShowBorders = true;
            this.pnlLowStockContainer.Size = new System.Drawing.Size(1451, 519);
            this.pnlLowStockContainer.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1379, 388);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lblLowStockHeader
            // 
            this.lblLowStockHeader.AutoSize = true;
            this.lblLowStockHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStockHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLowStockHeader.Location = new System.Drawing.Point(19, 28);
            this.lblLowStockHeader.Name = "lblLowStockHeader";
            this.lblLowStockHeader.Size = new System.Drawing.Size(344, 30);
            this.lblLowStockHeader.TabIndex = 14;
            this.lblLowStockHeader.Text = "Low Stock Items-Reorder Required";
            // 
            // pnlSupplierContainer
            // 
            this.pnlSupplierContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSupplierContainer.BackgroundColor = System.Drawing.Color.White;
            this.pnlSupplierContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSupplierContainer.BackgroundImage")));
            this.pnlSupplierContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSupplierContainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlSupplierContainer.BorderRadius = 20;
            this.pnlSupplierContainer.BorderThickness = 1;
            this.pnlSupplierContainer.Controls.Add(this.flowLayoutPanel2);
            this.pnlSupplierContainer.Controls.Add(this.lblSupplierHeader);
            this.pnlSupplierContainer.Location = new System.Drawing.Point(29, 31);
            this.pnlSupplierContainer.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.pnlSupplierContainer.Name = "pnlSupplierContainer";
            this.pnlSupplierContainer.ShowBorders = true;
            this.pnlSupplierContainer.Size = new System.Drawing.Size(1451, 526);
            this.pnlSupplierContainer.TabIndex = 15;
            // 
            // lblSupplierHeader
            // 
            this.lblSupplierHeader.AutoSize = true;
            this.lblSupplierHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupplierHeader.Location = new System.Drawing.Point(16, 25);
            this.lblSupplierHeader.Name = "lblSupplierHeader";
            this.lblSupplierHeader.Size = new System.Drawing.Size(217, 30);
            this.lblSupplierHeader.TabIndex = 14;
            this.lblSupplierHeader.Text = "Products By Suppllier";
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
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1136, 79);
            this.pnlHeader.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(816, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 30);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Saturday, November 22, 2025";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.White;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageTitle.Location = new System.Drawing.Point(19, 23);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(106, 32);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Products";
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Location = new System.Drawing.Point(93, 115);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = false;
            this.pnlMain.Size = new System.Drawing.Size(1533, 757);
            this.pnlMain.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.supplierProductsCard1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(37, 92);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1377, 398);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // supplierProductsCard1
            // 
            this.supplierProductsCard1.BackColor = System.Drawing.Color.White;
            this.supplierProductsCard1.Location = new System.Drawing.Point(4, 4);
            this.supplierProductsCard1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.supplierProductsCard1.Name = "supplierProductsCard1";
            this.supplierProductsCard1.Size = new System.Drawing.Size(1392, 100);
            this.supplierProductsCard1.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabProducts);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.Load += new System.EventHandler(this.ProductPage_Load);
            this.tabProducts.ResumeLayout(false);
            this.tabAllProducts.ResumeLayout(false);
            this.tabLowStock.ResumeLayout(false);
            this.tabSuppliers.ResumeLayout(false);
            this.cardOutOfStock.ResumeLayout(false);
            this.cardLowStock.ResumeLayout(false);
            this.cardInventoryValue.ResumeLayout(false);
            this.pnlGridContainer.ResumeLayout(false);
            this.pnlGridContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cardTotalProducts.ResumeLayout(false);
            this.pnlLowStockContainer.ResumeLayout(false);
            this.pnlLowStockContainer.PerformLayout();
            this.pnlSupplierContainer.ResumeLayout(false);
            this.pnlSupplierContainer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
        private TradeWright.UI.Forms.TabControlExtra tabProducts;
        private System.Windows.Forms.TabPage tabAllProducts;
        private Bunifu.UI.WinForms.BunifuPanel cardOutOfStock;
        private System.Windows.Forms.Label lblOutofStck;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private Bunifu.UI.WinForms.BunifuPanel cardLowStock;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private Bunifu.UI.WinForms.BunifuPanel cardInventoryValue;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private Bunifu.UI.WinForms.BunifuPanel pnlGridContainer;
        private System.Windows.Forms.Label lblProductListHeader;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvProducts;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddProduct;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuPanel cardTotalProducts;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TabPage tabLowStock;
        private Bunifu.UI.WinForms.BunifuPanel pnlLowStockContainer;
        private System.Windows.Forms.Label lblLowStockHeader;
        private System.Windows.Forms.TabPage tabSuppliers;
        private Bunifu.UI.WinForms.BunifuPanel pnlSupplierContainer;
        private System.Windows.Forms.Label lblSupplierHeader;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblValue;
        public System.Windows.Forms.Label lblLowStk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Components.SupplierProductsCard supplierProductsCard1;
    }
}