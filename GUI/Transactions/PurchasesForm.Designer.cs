namespace ERP_System.GUI.Transactions
{
    partial class PurchasesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.purchasesDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnAddPurchase = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.bunifuPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDgv)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel3.BorderRadius = 20;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.purchasesDgv);
            this.bunifuPanel3.Controls.Add(this.btnAddPurchase);
            this.bunifuPanel3.Controls.Add(this.lblHeader);
            this.bunifuPanel3.Location = new System.Drawing.Point(38, 126);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(1832, 271);
            this.bunifuPanel3.TabIndex = 25;
            // 
            // purchasesDgv
            // 
            this.purchasesDgv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.purchasesDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.purchasesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasesDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.purchasesDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.purchasesDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.purchasesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.purchasesDgv.ColumnHeadersHeight = 40;
            this.purchasesDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.purchasesDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchasesDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.purchasesDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.purchasesDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.purchasesDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.purchasesDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.purchasesDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.purchasesDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.purchasesDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.purchasesDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.purchasesDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.purchasesDgv.CurrentTheme.Name = null;
            this.purchasesDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.purchasesDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.purchasesDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.purchasesDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.purchasesDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.purchasesDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.purchasesDgv.EnableHeadersVisualStyles = false;
            this.purchasesDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.purchasesDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.purchasesDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.purchasesDgv.HeaderForeColor = System.Drawing.Color.White;
            this.purchasesDgv.Location = new System.Drawing.Point(26, 76);
            this.purchasesDgv.Name = "purchasesDgv";
            this.purchasesDgv.RowHeadersVisible = false;
            this.purchasesDgv.RowHeadersWidth = 53;
            this.purchasesDgv.RowTemplate.Height = 40;
            this.purchasesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasesDgv.Size = new System.Drawing.Size(1780, 150);
            this.purchasesDgv.TabIndex = 16;
            this.purchasesDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.AllowAnimations = true;
            this.btnAddPurchase.AllowMouseEffects = true;
            this.btnAddPurchase.AllowToggling = false;
            this.btnAddPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPurchase.AnimationSpeed = 200;
            this.btnAddPurchase.AutoGenerateColors = false;
            this.btnAddPurchase.AutoRoundBorders = false;
            this.btnAddPurchase.AutoSizeLeftIcon = true;
            this.btnAddPurchase.AutoSizeRightIcon = true;
            this.btnAddPurchase.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPurchase.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPurchase.BackgroundImage")));
            this.btnAddPurchase.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPurchase.ButtonText = "+ New Purchase";
            this.btnAddPurchase.ButtonTextMarginLeft = 0;
            this.btnAddPurchase.ColorContrastOnClick = 45;
            this.btnAddPurchase.ColorContrastOnHover = 45;
            this.btnAddPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddPurchase.CustomizableEdges = borderEdges1;
            this.btnAddPurchase.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPurchase.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddPurchase.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddPurchase.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddPurchase.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddPurchase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddPurchase.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.IconLeft = null;
            this.btnAddPurchase.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPurchase.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPurchase.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddPurchase.IconMarginLeft = 11;
            this.btnAddPurchase.IconPadding = 10;
            this.btnAddPurchase.IconRight = null;
            this.btnAddPurchase.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPurchase.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPurchase.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddPurchase.IconSize = 25;
            this.btnAddPurchase.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddPurchase.IdleBorderRadius = 6;
            this.btnAddPurchase.IdleBorderThickness = 1;
            this.btnAddPurchase.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddPurchase.IdleIconLeftImage = null;
            this.btnAddPurchase.IdleIconRightImage = null;
            this.btnAddPurchase.IndicateFocus = false;
            this.btnAddPurchase.Location = new System.Drawing.Point(1656, 29);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddPurchase.OnDisabledState.BorderRadius = 15;
            this.btnAddPurchase.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPurchase.OnDisabledState.BorderThickness = 1;
            this.btnAddPurchase.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddPurchase.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddPurchase.OnDisabledState.IconLeftImage = null;
            this.btnAddPurchase.OnDisabledState.IconRightImage = null;
            this.btnAddPurchase.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPurchase.onHoverState.BorderRadius = 15;
            this.btnAddPurchase.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPurchase.onHoverState.BorderThickness = 1;
            this.btnAddPurchase.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddPurchase.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.onHoverState.IconLeftImage = null;
            this.btnAddPurchase.onHoverState.IconRightImage = null;
            this.btnAddPurchase.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddPurchase.OnIdleState.BorderRadius = 15;
            this.btnAddPurchase.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPurchase.OnIdleState.BorderThickness = 1;
            this.btnAddPurchase.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnAddPurchase.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.OnIdleState.IconLeftImage = null;
            this.btnAddPurchase.OnIdleState.IconRightImage = null;
            this.btnAddPurchase.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddPurchase.OnPressedState.BorderRadius = 15;
            this.btnAddPurchase.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddPurchase.OnPressedState.BorderThickness = 1;
            this.btnAddPurchase.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddPurchase.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddPurchase.OnPressedState.IconLeftImage = null;
            this.btnAddPurchase.OnPressedState.IconRightImage = null;
            this.btnAddPurchase.Size = new System.Drawing.Size(150, 41);
            this.btnAddPurchase.TabIndex = 15;
            this.btnAddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPurchase.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddPurchase.TextMarginLeft = 0;
            this.btnAddPurchase.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddPurchase.UseDefaultRadiusAndThickness = true;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(20, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(255, 32);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Purchase Orders";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lblConnection);
            this.bunifuPanel2.Controls.Add(this.lblUserInfo);
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 987);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1902, 51);
            this.bunifuPanel2.TabIndex = 24;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblConnection.Location = new System.Drawing.Point(1733, 14);
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
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.bunifuPanel1.BorderRadius = 8;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.lblTopTitle);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1906, 79);
            this.bunifuPanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(1585, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saturday, November 22, 2025";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.BackColor = System.Drawing.Color.White;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTopTitle.Location = new System.Drawing.Point(19, 23);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(119, 32);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "Purchases";
            // 
            // PurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.bunifuPanel3);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "PurchasesForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchasesForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDgv)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopTitle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserInfo;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private System.Windows.Forms.Label lblHeader;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddPurchase;
        private Bunifu.UI.WinForms.BunifuDataGridView purchasesDgv;
    }
}