namespace ERP_System.GUI.Pages
{
    partial class PurchasesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvPurchases = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnNewPurchase = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblListHeader = new System.Windows.Forms.Label();
            this.pnlFooter = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.pnlFooter.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlFooter);
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
            this.pnlHeader.TabIndex = 26;
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
            this.lblPageTitle.Size = new System.Drawing.Size(119, 32);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Purchases";
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundColor = System.Drawing.Color.White;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.BorderColor = System.Drawing.Color.White;
            this.pnlContent.BorderRadius = 20;
            this.pnlContent.BorderThickness = 1;
            this.pnlContent.Controls.Add(this.dgvPurchases);
            this.pnlContent.Controls.Add(this.btnNewPurchase);
            this.pnlContent.Controls.Add(this.lblListHeader);
            this.pnlContent.Location = new System.Drawing.Point(92, 185);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShowBorders = true;
            this.pnlContent.Size = new System.Drawing.Size(1507, 271);
            this.pnlContent.TabIndex = 28;
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.AllowCustomTheming = false;
            this.dgvPurchases.AllowUserToAddRows = false;
            this.dgvPurchases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPurchases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPurchases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchases.ColumnHeadersHeight = 40;
            this.dgvPurchases.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvPurchases.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPurchases.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchases.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPurchases.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPurchases.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPurchases.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPurchases.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvPurchases.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPurchases.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvPurchases.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPurchases.CurrentTheme.Name = null;
            this.dgvPurchases.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPurchases.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvPurchases.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchases.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvPurchases.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchases.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchases.EnableHeadersVisualStyles = false;
            this.dgvPurchases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvPurchases.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvPurchases.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvPurchases.HeaderForeColor = System.Drawing.Color.White;
            this.dgvPurchases.Location = new System.Drawing.Point(43, 86);
            this.dgvPurchases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.RowHeadersVisible = false;
            this.dgvPurchases.RowHeadersWidth = 53;
            this.dgvPurchases.RowTemplate.Height = 40;
            this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchases.Size = new System.Drawing.Size(1437, 150);
            this.dgvPurchases.TabIndex = 17;
            this.dgvPurchases.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnNewPurchase
            // 
            this.btnNewPurchase.AllowAnimations = true;
            this.btnNewPurchase.AllowMouseEffects = true;
            this.btnNewPurchase.AllowToggling = false;
            this.btnNewPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPurchase.AnimationSpeed = 200;
            this.btnNewPurchase.AutoGenerateColors = false;
            this.btnNewPurchase.AutoRoundBorders = false;
            this.btnNewPurchase.AutoSizeLeftIcon = true;
            this.btnNewPurchase.AutoSizeRightIcon = true;
            this.btnNewPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewPurchase.BackgroundImage")));
            this.btnNewPurchase.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPurchase.ButtonText = "+ New Purchase";
            this.btnNewPurchase.ButtonTextMarginLeft = 0;
            this.btnNewPurchase.ColorContrastOnClick = 45;
            this.btnNewPurchase.ColorContrastOnHover = 45;
            this.btnNewPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNewPurchase.CustomizableEdges = borderEdges1;
            this.btnNewPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNewPurchase.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNewPurchase.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNewPurchase.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNewPurchase.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNewPurchase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNewPurchase.ForeColor = System.Drawing.Color.White;
            this.btnNewPurchase.IconLeft = null;
            this.btnNewPurchase.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewPurchase.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPurchase.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNewPurchase.IconMarginLeft = 11;
            this.btnNewPurchase.IconPadding = 10;
            this.btnNewPurchase.IconRight = null;
            this.btnNewPurchase.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewPurchase.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPurchase.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNewPurchase.IconSize = 25;
            this.btnNewPurchase.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewPurchase.IdleBorderRadius = 6;
            this.btnNewPurchase.IdleBorderThickness = 1;
            this.btnNewPurchase.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnNewPurchase.IdleIconLeftImage = null;
            this.btnNewPurchase.IdleIconRightImage = null;
            this.btnNewPurchase.IndicateFocus = false;
            this.btnNewPurchase.Location = new System.Drawing.Point(1331, 30);
            this.btnNewPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewPurchase.Name = "btnNewPurchase";
            this.btnNewPurchase.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNewPurchase.OnDisabledState.BorderRadius = 15;
            this.btnNewPurchase.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPurchase.OnDisabledState.BorderThickness = 1;
            this.btnNewPurchase.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNewPurchase.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNewPurchase.OnDisabledState.IconLeftImage = null;
            this.btnNewPurchase.OnDisabledState.IconRightImage = null;
            this.btnNewPurchase.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.onHoverState.BorderRadius = 15;
            this.btnNewPurchase.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPurchase.onHoverState.BorderThickness = 1;
            this.btnNewPurchase.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnNewPurchase.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNewPurchase.onHoverState.IconLeftImage = null;
            this.btnNewPurchase.onHoverState.IconRightImage = null;
            this.btnNewPurchase.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnNewPurchase.OnIdleState.BorderRadius = 15;
            this.btnNewPurchase.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPurchase.OnIdleState.BorderThickness = 1;
            this.btnNewPurchase.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnNewPurchase.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNewPurchase.OnIdleState.IconLeftImage = null;
            this.btnNewPurchase.OnIdleState.IconRightImage = null;
            this.btnNewPurchase.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewPurchase.OnPressedState.BorderRadius = 15;
            this.btnNewPurchase.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNewPurchase.OnPressedState.BorderThickness = 1;
            this.btnNewPurchase.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnNewPurchase.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNewPurchase.OnPressedState.IconLeftImage = null;
            this.btnNewPurchase.OnPressedState.IconRightImage = null;
            this.btnNewPurchase.Size = new System.Drawing.Size(149, 41);
            this.btnNewPurchase.TabIndex = 15;
            this.btnNewPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewPurchase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNewPurchase.TextMarginLeft = 0;
            this.btnNewPurchase.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNewPurchase.UseDefaultRadiusAndThickness = true;
            // 
            // lblListHeader
            // 
            this.lblListHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblListHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListHeader.Location = new System.Drawing.Point(20, 30);
            this.lblListHeader.Name = "lblListHeader";
            this.lblListHeader.Size = new System.Drawing.Size(255, 32);
            this.lblListHeader.TabIndex = 14;
            this.lblListHeader.Text = "Purchase Orders";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BackgroundColor = System.Drawing.Color.White;
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.BorderColor = System.Drawing.Color.LightGray;
            this.pnlFooter.BorderRadius = 3;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.lblConnection);
            this.pnlFooter.Controls.Add(this.lblUserInfo);
            this.pnlFooter.Location = new System.Drawing.Point(-5, 794);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.ShowBorders = true;
            this.pnlFooter.Size = new System.Drawing.Size(1517, 50);
            this.pnlFooter.TabIndex = 27;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblConnection.Location = new System.Drawing.Point(1349, 14);
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
            this.lblUserInfo.Location = new System.Drawing.Point(8, 7);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUserInfo.Size = new System.Drawing.Size(528, 28);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "User: admin@company.com | Role: Administrator";
            // 
            // PurchasesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PurchasesPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlContent;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvPurchases;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNewPurchase;
        private System.Windows.Forms.Label lblListHeader;
        private Bunifu.UI.WinForms.BunifuPanel pnlFooter;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserInfo;
    }
}