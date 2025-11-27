namespace ERP_System.GUI.Suppliers
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblUserInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlDirectory = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddSupplier = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlMain.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.pnlDirectory.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 0;
            this.pnlMain.BorderThickness = 0;
            this.pnlMain.Controls.Add(this.bunifuPanel2);
            this.pnlMain.Controls.Add(this.bunifuPanel1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1902, 1032);
            this.pnlMain.TabIndex = 0;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.AutoSize = true;
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lblConnection);
            this.bunifuPanel2.Controls.Add(this.lblUserInfo);
            this.bunifuPanel2.Location = new System.Drawing.Point(3, 985);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1899, 51);
            this.bunifuPanel2.TabIndex = 5;
            // 
            // lblConnection
            // 
            this.lblConnection.AllowParentOverrides = false;
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.AutoEllipsis = false;
            this.lblConnection.CursorType = null;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblConnection.Location = new System.Drawing.Point(1742, 14);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnection.Size = new System.Drawing.Size(124, 21);
            this.lblConnection.TabIndex = 3;
            this.lblConnection.Text = "Status: Connected";
            this.lblConnection.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblConnection.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AllowParentOverrides = false;
            this.lblUserInfo.AutoEllipsis = false;
            this.lblUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUserInfo.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserInfo.Location = new System.Drawing.Point(15, 12);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserInfo.Size = new System.Drawing.Size(474, 30);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "User: admin@company.com | Role: Administrator";
            this.lblUserInfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlDirectory
            // 
            this.pnlDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDirectory.AutoScroll = true;
            this.pnlDirectory.AutoSize = true;
            this.pnlDirectory.BackColor = System.Drawing.Color.White;
            this.pnlDirectory.Controls.Add(this.bunifuPanel3);
            this.pnlDirectory.Location = new System.Drawing.Point(21, 108);
            this.pnlDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDirectory.Name = "pnlDirectory";
            this.pnlDirectory.Size = new System.Drawing.Size(1782, 725);
            this.pnlDirectory.TabIndex = 3;
            this.pnlDirectory.WrapContents = false;
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.bunifuSeparator1);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel3.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel3.Controls.Add(this.bunifuButton1);
            this.bunifuPanel3.Location = new System.Drawing.Point(25, 25);
            this.bunifuPanel3.Margin = new System.Windows.Forms.Padding(25);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.Padding = new System.Windows.Forms.Padding(8);
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(392, 316);
            this.bunifuPanel3.TabIndex = 3;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(24, 177);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(350, 17);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 20);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(182, 30);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Lighting Solutions";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(24, 66);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(184, 30);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Contact: Mike Davis";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(24, 140);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(267, 30);
            this.bunifuLabel3.TabIndex = 2;
            this.bunifuLabel3.Text = "Email: sales@lightingsol.com";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(24, 102);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(237, 30);
            this.bunifuLabel4.TabIndex = 3;
            this.bunifuLabel4.Text = "Phone: +1 (555) 200-2003";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(24, 201);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(114, 30);
            this.bunifuLabel5.TabIndex = 4;
            this.bunifuLabel5.Text = "Products: 10";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "View Products";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges2;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.IconLeft = null;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRight = null;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleBorderRadius = 0;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(19, 250);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 20;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuButton1.onHoverState.BorderRadius = 20;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuButton1.OnIdleState.BorderRadius = 20;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.OnPressedState.BorderRadius = 20;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(355, 41);
            this.bunifuButton1.TabIndex = 5;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnAddSupplier);
            this.bunifuPanel1.Controls.Add(this.pnlDirectory);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(18, 104);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1851, 843);
            this.bunifuPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier Directory";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackgroundColor = System.Drawing.Color.White;
            this.pnlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHeader.BackgroundImage")));
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlHeader.BorderRadius = 8;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1902, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AllowParentOverrides = false;
            this.lblTitle.AutoEllipsis = false;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(63, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(98, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Suppliers";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblDate
            // 
            this.lblDate.AllowParentOverrides = false;
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoEllipsis = false;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDate.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(1618, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(272, 30);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Saturday, November 22, 2025";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblStatus
            // 
            this.lblStatus.AllowParentOverrides = false;
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoEllipsis = false;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblStatus.Location = new System.Drawing.Point(2502, 1472);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(124, 21);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Connected";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.AllowAnimations = true;
            this.btnAddSupplier.AllowMouseEffects = true;
            this.btnAddSupplier.AllowToggling = false;
            this.btnAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSupplier.AnimationSpeed = 200;
            this.btnAddSupplier.AutoGenerateColors = false;
            this.btnAddSupplier.AutoRoundBorders = false;
            this.btnAddSupplier.AutoSizeLeftIcon = true;
            this.btnAddSupplier.AutoSizeRightIcon = true;
            this.btnAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.BackgroundImage")));
            this.btnAddSupplier.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.ButtonText = "+ Add Supplier";
            this.btnAddSupplier.ButtonTextMarginLeft = 0;
            this.btnAddSupplier.ColorContrastOnClick = 45;
            this.btnAddSupplier.ColorContrastOnHover = 45;
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddSupplier.CustomizableEdges = borderEdges1;
            this.btnAddSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSupplier.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSupplier.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddSupplier.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddSupplier.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.IconLeft = null;
            this.btnAddSupplier.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddSupplier.IconMarginLeft = 11;
            this.btnAddSupplier.IconPadding = 10;
            this.btnAddSupplier.IconRight = null;
            this.btnAddSupplier.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSupplier.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddSupplier.IconSize = 25;
            this.btnAddSupplier.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddSupplier.IdleBorderRadius = 6;
            this.btnAddSupplier.IdleBorderThickness = 1;
            this.btnAddSupplier.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddSupplier.IdleIconLeftImage = null;
            this.btnAddSupplier.IdleIconRightImage = null;
            this.btnAddSupplier.IndicateFocus = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(1629, 26);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSupplier.OnDisabledState.BorderRadius = 15;
            this.btnAddSupplier.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnDisabledState.BorderThickness = 1;
            this.btnAddSupplier.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddSupplier.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddSupplier.OnDisabledState.IconLeftImage = null;
            this.btnAddSupplier.OnDisabledState.IconRightImage = null;
            this.btnAddSupplier.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.onHoverState.BorderRadius = 15;
            this.btnAddSupplier.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.onHoverState.BorderThickness = 1;
            this.btnAddSupplier.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.onHoverState.IconLeftImage = null;
            this.btnAddSupplier.onHoverState.IconRightImage = null;
            this.btnAddSupplier.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddSupplier.OnIdleState.BorderRadius = 15;
            this.btnAddSupplier.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnIdleState.BorderThickness = 1;
            this.btnAddSupplier.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnAddSupplier.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.OnIdleState.IconLeftImage = null;
            this.btnAddSupplier.OnIdleState.IconRightImage = null;
            this.btnAddSupplier.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.OnPressedState.BorderRadius = 15;
            this.btnAddSupplier.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnPressedState.BorderThickness = 1;
            this.btnAddSupplier.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.OnPressedState.IconLeftImage = null;
            this.btnAddSupplier.OnPressedState.IconRightImage = null;
            this.btnAddSupplier.Size = new System.Drawing.Size(174, 44);
            this.btnAddSupplier.TabIndex = 11;
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSupplier.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSupplier.TextMarginLeft = 0;
            this.btnAddSupplier.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddSupplier.UseDefaultRadiusAndThickness = true;
            // 
            // SupplierForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.pnlMain);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers - Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.pnlDirectory.ResumeLayout(false);
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuLabel lblTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
        private Bunifu.UI.WinForms.BunifuLabel lblUserInfo;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlDirectory;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblConnection;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSupplier;
    }
}
