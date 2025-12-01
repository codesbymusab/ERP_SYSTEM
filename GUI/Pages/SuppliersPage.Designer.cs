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
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowSupplierCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDirectoryBackground = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDirectoryTitle = new System.Windows.Forms.Label();
            this.btnAddSupplier = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblPageTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblStatus = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlMain.SuspendLayout();
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
            this.flowSupplierCards.Location = new System.Drawing.Point(91, 226);
            this.flowSupplierCards.Margin = new System.Windows.Forms.Padding(0);
            this.flowSupplierCards.Name = "flowSupplierCards";
            this.flowSupplierCards.Size = new System.Drawing.Size(1364, 556);
            this.flowSupplierCards.TabIndex = 3;
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
            this.pnlDirectoryBackground.Location = new System.Drawing.Point(46, 124);
            this.pnlDirectoryBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDirectoryBackground.Name = "pnlDirectoryBackground";
            this.pnlDirectoryBackground.ShowBorders = true;
            this.pnlDirectoryBackground.Size = new System.Drawing.Size(1431, 694);
            this.pnlDirectoryBackground.TabIndex = 4;
            // 
            // lblDirectoryTitle
            // 
            this.lblDirectoryTitle.BackColor = System.Drawing.Color.White;
            this.lblDirectoryTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryTitle.Location = new System.Drawing.Point(15, 38);
            this.lblDirectoryTitle.Name = "lblDirectoryTitle";
            this.lblDirectoryTitle.Size = new System.Drawing.Size(240, 32);
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
            this.btnAddSupplier.Location = new System.Drawing.Point(1208, 27);
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
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
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
            this.lblPageTitle.Size = new System.Drawing.Size(98, 32);
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
            this.lblStatus.Location = new System.Drawing.Point(2104, 1276);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(124, 21);
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
            this.pnlDirectoryBackground.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flowSupplierCards;
        private Bunifu.UI.WinForms.BunifuPanel pnlDirectoryBackground;
        private System.Windows.Forms.Label lblDirectoryTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSupplier;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private Bunifu.UI.WinForms.BunifuLabel lblPageTitle;
        private Bunifu.UI.WinForms.BunifuLabel lblDate; 
        private Bunifu.UI.WinForms.BunifuLabel lblStatus;
    }
}