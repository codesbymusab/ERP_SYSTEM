namespace ERP_System.GUI.Pages
{
    partial class SuppliersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersPage));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowSupplierCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardSupplierTemplate = new Bunifu.UI.WinForms.BunifuPanel();
            this.sepSupCard = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblSupName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSupContact = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSupEmail = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSupPhone = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblSupProductCount = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnViewProducts = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlDirectoryBackground = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDirectoryTitle = new System.Windows.Forms.Label();
            this.btnAddSupplier = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPageTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMain.SuspendLayout();
            this.flowSupplierCards.SuspendLayout();
            this.cardSupplierTemplate.SuspendLayout();
            this.pnlDirectoryBackground.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.flowSupplierCards);
            this.pnlMain.Controls.Add(this.pnlDirectoryBackground);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.TabIndex = 1;
            // 
            // flowSupplierCards
            // 
            this.flowSupplierCards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSupplierCards.AutoScroll = true;
            this.flowSupplierCards.BackColor = System.Drawing.Color.White;
            this.flowSupplierCards.Controls.Add(this.cardSupplierTemplate);
            this.flowSupplierCards.Location = new System.Drawing.Point(192, 226);
            this.flowSupplierCards.Margin = new System.Windows.Forms.Padding(0);
            this.flowSupplierCards.Name = "flowSupplierCards";
            this.flowSupplierCards.Size = new System.Drawing.Size(1117, 556);
            this.flowSupplierCards.TabIndex = 3;
            this.flowSupplierCards.WrapContents = false;
            // 
            // cardSupplierTemplate
            // 
            this.cardSupplierTemplate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardSupplierTemplate.BackgroundColor = System.Drawing.Color.White;
            this.cardSupplierTemplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardSupplierTemplate.BackgroundImage")));
            this.cardSupplierTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardSupplierTemplate.BorderColor = System.Drawing.Color.LightGray;
            this.cardSupplierTemplate.BorderRadius = 20;
            this.cardSupplierTemplate.BorderThickness = 1;
            this.cardSupplierTemplate.Controls.Add(this.sepSupCard);
            this.cardSupplierTemplate.Controls.Add(this.lblSupName);
            this.cardSupplierTemplate.Controls.Add(this.lblSupContact);
            this.cardSupplierTemplate.Controls.Add(this.lblSupEmail);
            this.cardSupplierTemplate.Controls.Add(this.lblSupPhone);
            this.cardSupplierTemplate.Controls.Add(this.lblSupProductCount);
            this.cardSupplierTemplate.Controls.Add(this.btnViewProducts);
            this.cardSupplierTemplate.Location = new System.Drawing.Point(25, 25);
            this.cardSupplierTemplate.Margin = new System.Windows.Forms.Padding(25);
            this.cardSupplierTemplate.Name = "cardSupplierTemplate";
            this.cardSupplierTemplate.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cardSupplierTemplate.ShowBorders = true;
            this.cardSupplierTemplate.Size = new System.Drawing.Size(392, 316);
            this.cardSupplierTemplate.TabIndex = 3;
            // 
            // sepSupCard
            // 
            this.sepSupCard.BackColor = System.Drawing.Color.Transparent;
            this.sepSupCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sepSupCard.BackgroundImage")));
            this.sepSupCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sepSupCard.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.sepSupCard.LineColor = System.Drawing.Color.Silver;
            this.sepSupCard.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.sepSupCard.LineThickness = 1;
            this.sepSupCard.Location = new System.Drawing.Point(24, 177);
            this.sepSupCard.Margin = new System.Windows.Forms.Padding(5);
            this.sepSupCard.Name = "sepSupCard";
            this.sepSupCard.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sepSupCard.Size = new System.Drawing.Size(349, 17);
            this.sepSupCard.TabIndex = 6;
            // 
            // lblSupName
            // 
            this.lblSupName.AllowParentOverrides = false;
            this.lblSupName.AutoEllipsis = false;
            this.lblSupName.AutoSize = false;
            this.lblSupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSupName.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblSupName.Location = new System.Drawing.Point(21, 20);
            this.lblSupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupName.Size = new System.Drawing.Size(227, 30);
            this.lblSupName.TabIndex = 0;
            this.lblSupName.Text = "Lighting Solutions";
            this.lblSupName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSupName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSupContact
            // 
            this.lblSupContact.AllowParentOverrides = false;
            this.lblSupContact.AutoEllipsis = false;
            this.lblSupContact.AutoSize = false;
            this.lblSupContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupContact.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSupContact.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupContact.ForeColor = System.Drawing.Color.Black;
            this.lblSupContact.Location = new System.Drawing.Point(24, 66);
            this.lblSupContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupContact.Name = "lblSupContact";
            this.lblSupContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupContact.Size = new System.Drawing.Size(225, 30);
            this.lblSupContact.TabIndex = 1;
            this.lblSupContact.Text = "Contact: Mike Davis";
            this.lblSupContact.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSupContact.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSupEmail
            // 
            this.lblSupEmail.AllowParentOverrides = false;
            this.lblSupEmail.AutoEllipsis = false;
            this.lblSupEmail.AutoSize = false;
            this.lblSupEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupEmail.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSupEmail.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupEmail.Location = new System.Drawing.Point(24, 140);
            this.lblSupEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupEmail.Name = "lblSupEmail";
            this.lblSupEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupEmail.Size = new System.Drawing.Size(301, 30);
            this.lblSupEmail.TabIndex = 2;
            this.lblSupEmail.Text = "Email: sales@lightingsol.com";
            this.lblSupEmail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSupEmail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSupPhone
            // 
            this.lblSupPhone.AllowParentOverrides = false;
            this.lblSupPhone.AutoEllipsis = false;
            this.lblSupPhone.AutoSize = false;
            this.lblSupPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupPhone.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSupPhone.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupPhone.Location = new System.Drawing.Point(24, 102);
            this.lblSupPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupPhone.Name = "lblSupPhone";
            this.lblSupPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupPhone.Size = new System.Drawing.Size(287, 30);
            this.lblSupPhone.TabIndex = 3;
            this.lblSupPhone.Text = "Phone: +1 (555) 200-2003";
            this.lblSupPhone.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSupPhone.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblSupProductCount
            // 
            this.lblSupProductCount.AllowParentOverrides = false;
            this.lblSupProductCount.AutoEllipsis = false;
            this.lblSupProductCount.AutoSize = false;
            this.lblSupProductCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupProductCount.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblSupProductCount.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupProductCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupProductCount.Location = new System.Drawing.Point(24, 201);
            this.lblSupProductCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupProductCount.Name = "lblSupProductCount";
            this.lblSupProductCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupProductCount.Size = new System.Drawing.Size(161, 30);
            this.lblSupProductCount.TabIndex = 4;
            this.lblSupProductCount.Text = "Products: 10";
            this.lblSupProductCount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblSupProductCount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.AllowAnimations = true;
            this.btnViewProducts.AllowMouseEffects = true;
            this.btnViewProducts.AllowToggling = false;
            this.btnViewProducts.AnimationSpeed = 200;
            this.btnViewProducts.AutoGenerateColors = false;
            this.btnViewProducts.AutoRoundBorders = false;
            this.btnViewProducts.AutoSizeLeftIcon = true;
            this.btnViewProducts.AutoSizeRightIcon = true;
            this.btnViewProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnViewProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewProducts.BackgroundImage")));
            this.btnViewProducts.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.ButtonText = "View Products";
            this.btnViewProducts.ButtonTextMarginLeft = 0;
            this.btnViewProducts.ColorContrastOnClick = 45;
            this.btnViewProducts.ColorContrastOnHover = 45;
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnViewProducts.CustomizableEdges = borderEdges1;
            this.btnViewProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewProducts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewProducts.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnViewProducts.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnViewProducts.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnViewProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.IconLeft = null;
            this.btnViewProducts.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProducts.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewProducts.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnViewProducts.IconMarginLeft = 11;
            this.btnViewProducts.IconPadding = 10;
            this.btnViewProducts.IconRight = null;
            this.btnViewProducts.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewProducts.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewProducts.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnViewProducts.IconSize = 25;
            this.btnViewProducts.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnViewProducts.IdleBorderRadius = 0;
            this.btnViewProducts.IdleBorderThickness = 0;
            this.btnViewProducts.IdleFillColor = System.Drawing.Color.Empty;
            this.btnViewProducts.IdleIconLeftImage = null;
            this.btnViewProducts.IdleIconRightImage = null;
            this.btnViewProducts.IndicateFocus = false;
            this.btnViewProducts.Location = new System.Drawing.Point(19, 250);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewProducts.OnDisabledState.BorderRadius = 20;
            this.btnViewProducts.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnDisabledState.BorderThickness = 1;
            this.btnViewProducts.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewProducts.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewProducts.OnDisabledState.IconLeftImage = null;
            this.btnViewProducts.OnDisabledState.IconRightImage = null;
            this.btnViewProducts.onHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProducts.onHoverState.BorderRadius = 20;
            this.btnViewProducts.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.onHoverState.BorderThickness = 1;
            this.btnViewProducts.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnViewProducts.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.onHoverState.IconLeftImage = null;
            this.btnViewProducts.onHoverState.IconRightImage = null;
            this.btnViewProducts.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnViewProducts.OnIdleState.BorderRadius = 20;
            this.btnViewProducts.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnIdleState.BorderThickness = 1;
            this.btnViewProducts.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.OnIdleState.IconLeftImage = null;
            this.btnViewProducts.OnIdleState.IconRightImage = null;
            this.btnViewProducts.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.OnPressedState.BorderRadius = 20;
            this.btnViewProducts.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnPressedState.BorderThickness = 1;
            this.btnViewProducts.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnViewProducts.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnViewProducts.OnPressedState.IconLeftImage = null;
            this.btnViewProducts.OnPressedState.IconRightImage = null;
            this.btnViewProducts.Size = new System.Drawing.Size(355, 41);
            this.btnViewProducts.TabIndex = 5;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProducts.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewProducts.TextMarginLeft = 0;
            this.btnViewProducts.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewProducts.UseDefaultRadiusAndThickness = true;
            // 
            // pnlDirectoryBackground
            // 
            this.pnlDirectoryBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDirectoryBackground.BackgroundColor = System.Drawing.Color.White;
            this.pnlDirectoryBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDirectoryBackground.BackgroundImage")));
            this.pnlDirectoryBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDirectoryBackground.BorderColor = System.Drawing.Color.LightGray;
            this.pnlDirectoryBackground.BorderRadius = 20;
            this.pnlDirectoryBackground.BorderThickness = 1;
            this.pnlDirectoryBackground.Controls.Add(this.lblDirectoryTitle);
            this.pnlDirectoryBackground.Controls.Add(this.btnAddSupplier);
            this.pnlDirectoryBackground.Location = new System.Drawing.Point(182, 123);
            this.pnlDirectoryBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDirectoryBackground.Name = "pnlDirectoryBackground";
            this.pnlDirectoryBackground.ShowBorders = true;
            this.pnlDirectoryBackground.Size = new System.Drawing.Size(1148, 673);
            this.pnlDirectoryBackground.TabIndex = 4;
            // 
            // lblDirectoryTitle
            // 
            this.lblDirectoryTitle.BackColor = System.Drawing.Color.White;
            this.lblDirectoryTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryTitle.Location = new System.Drawing.Point(15, 38);
            this.lblDirectoryTitle.Name = "lblDirectoryTitle";
            this.lblDirectoryTitle.Size = new System.Drawing.Size(205, 32);
            this.lblDirectoryTitle.TabIndex = 5;
            this.lblDirectoryTitle.Text = "Supplier Directory";
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
            this.btnAddSupplier.ButtonText = "+   Add Supplier";
            this.btnAddSupplier.ButtonTextMarginLeft = 0;
            this.btnAddSupplier.ColorContrastOnClick = 45;
            this.btnAddSupplier.ColorContrastOnHover = 45;
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddSupplier.CustomizableEdges = borderEdges2;
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
            this.btnAddSupplier.Location = new System.Drawing.Point(939, 27);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddSupplier.OnDisabledState.BorderRadius = 20;
            this.btnAddSupplier.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnDisabledState.BorderThickness = 1;
            this.btnAddSupplier.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddSupplier.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddSupplier.OnDisabledState.IconLeftImage = null;
            this.btnAddSupplier.OnDisabledState.IconRightImage = null;
            this.btnAddSupplier.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.onHoverState.BorderRadius = 20;
            this.btnAddSupplier.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.onHoverState.BorderThickness = 1;
            this.btnAddSupplier.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.onHoverState.IconLeftImage = null;
            this.btnAddSupplier.onHoverState.IconRightImage = null;
            this.btnAddSupplier.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.OnIdleState.BorderRadius = 20;
            this.btnAddSupplier.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnIdleState.BorderThickness = 1;
            this.btnAddSupplier.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnAddSupplier.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.OnIdleState.IconLeftImage = null;
            this.btnAddSupplier.OnIdleState.IconRightImage = null;
            this.btnAddSupplier.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.OnPressedState.BorderRadius = 20;
            this.btnAddSupplier.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddSupplier.OnPressedState.BorderThickness = 1;
            this.btnAddSupplier.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddSupplier.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.OnPressedState.IconLeftImage = null;
            this.btnAddSupplier.OnPressedState.IconRightImage = null;
            this.btnAddSupplier.Size = new System.Drawing.Size(189, 53);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSupplier.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddSupplier.TextMarginLeft = 0;
            this.btnAddSupplier.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddSupplier.UseDefaultRadiusAndThickness = true;
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
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Location = new System.Drawing.Point(3, 2);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1536, 79);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AllowParentOverrides = false;
            this.lblPageTitle.AutoEllipsis = false;
            this.lblPageTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPageTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageTitle.Location = new System.Drawing.Point(19, 23);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPageTitle.Size = new System.Drawing.Size(95, 31);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Suppliers";
            this.lblPageTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPageTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.lblDate.Location = new System.Drawing.Point(1237, 26);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(260, 28);
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
            this.lblStatus.Location = new System.Drawing.Point(2104, 1276);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(118, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Connected";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SuppliersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuppliersPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.flowSupplierCards.ResumeLayout(false);
            this.cardSupplierTemplate.ResumeLayout(false);
            this.pnlDirectoryBackground.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flowSupplierCards;
        private Bunifu.UI.WinForms.BunifuPanel cardSupplierTemplate;
        private Bunifu.UI.WinForms.BunifuSeparator sepSupCard;
        private Bunifu.UI.WinForms.BunifuLabel lblSupName;
        private Bunifu.UI.WinForms.BunifuLabel lblSupContact;
        private Bunifu.UI.WinForms.BunifuLabel lblSupEmail;
        private Bunifu.UI.WinForms.BunifuLabel lblSupPhone;
        private Bunifu.UI.WinForms.BunifuLabel lblSupProductCount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewProducts;
        private Bunifu.UI.WinForms.BunifuPanel pnlDirectoryBackground;
        private System.Windows.Forms.Label lblDirectoryTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSupplier;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuLabel lblPageTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
    }
}