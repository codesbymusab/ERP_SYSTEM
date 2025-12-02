namespace ERP_System.GUI.Pages
{
    partial class ActivityLogPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityLogPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDirectory = new Bunifu.UI.WinForms.BunifuPanel();
            this.activtylogDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.typeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.pnlDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activtylogDgv)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDirectory
            // 
            this.pnlDirectory.BackgroundColor = System.Drawing.Color.White;
            this.pnlDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDirectory.BackgroundImage")));
            this.pnlDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlDirectory.BorderRadius = 20;
            this.pnlDirectory.BorderThickness = 1;
            this.pnlDirectory.Controls.Add(this.activtylogDgv);
            this.pnlDirectory.Controls.Add(this.typeDropdown);
            this.pnlDirectory.Controls.Add(this.lblHeader);
            this.pnlDirectory.Location = new System.Drawing.Point(49, 131);
            this.pnlDirectory.Margin = new System.Windows.Forms.Padding(30);
            this.pnlDirectory.Name = "pnlDirectory";
            this.pnlDirectory.ShowBorders = true;
            this.pnlDirectory.Size = new System.Drawing.Size(1445, 619);
            this.pnlDirectory.TabIndex = 29;
            // 
            // activtylogDgv
            // 
            this.activtylogDgv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.activtylogDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.activtylogDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activtylogDgv.BackgroundColor = System.Drawing.Color.White;
            this.activtylogDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activtylogDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.activtylogDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activtylogDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.activtylogDgv.ColumnHeadersHeight = 40;
            this.activtylogDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.activtylogDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.activtylogDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.activtylogDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.activtylogDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.activtylogDgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.activtylogDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.activtylogDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.activtylogDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.activtylogDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.activtylogDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.activtylogDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.activtylogDgv.CurrentTheme.Name = null;
            this.activtylogDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.activtylogDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.activtylogDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.activtylogDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.activtylogDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.activtylogDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.activtylogDgv.EnableHeadersVisualStyles = false;
            this.activtylogDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.activtylogDgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.activtylogDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.activtylogDgv.HeaderForeColor = System.Drawing.Color.White;
            this.activtylogDgv.Location = new System.Drawing.Point(53, 86);
            this.activtylogDgv.Name = "activtylogDgv";
            this.activtylogDgv.RowHeadersVisible = false;
            this.activtylogDgv.RowHeadersWidth = 53;
            this.activtylogDgv.RowTemplate.Height = 40;
            this.activtylogDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activtylogDgv.Size = new System.Drawing.Size(1341, 486);
            this.activtylogDgv.TabIndex = 23;
            this.activtylogDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // typeDropdown
            // 
            this.typeDropdown.BackColor = System.Drawing.Color.Transparent;
            this.typeDropdown.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.typeDropdown.BorderColor = System.Drawing.Color.Gainsboro;
            this.typeDropdown.BorderRadius = 10;
            this.typeDropdown.Color = System.Drawing.Color.Gainsboro;
            this.typeDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.typeDropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.typeDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.typeDropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.typeDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.typeDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.typeDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.typeDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.typeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.typeDropdown.FillDropDown = true;
            this.typeDropdown.FillIndicator = false;
            this.typeDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeDropdown.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Icon = null;
            this.typeDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.typeDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.typeDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.typeDropdown.IndicatorThickness = 2;
            this.typeDropdown.IsDropdownOpened = false;
            this.typeDropdown.ItemBackColor = System.Drawing.Color.White;
            this.typeDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.typeDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.typeDropdown.ItemHeight = 35;
            this.typeDropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.typeDropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.typeDropdown.ItemTopMargin = 3;
            this.typeDropdown.Location = new System.Drawing.Point(1567, 24);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(218, 41);
            this.typeDropdown.TabIndex = 20;
            this.typeDropdown.Text = "All Actions";
            this.typeDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.typeDropdown.TextLeftMargin = 5;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(28, 25);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(263, 32);
            this.lblHeader.TabIndex = 13;
            this.lblHeader.Text = "System Activity Log";
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
            this.bunifuPanel2.Location = new System.Drawing.Point(1, 795);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1540, 51);
            this.bunifuPanel2.TabIndex = 28;
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnection.BackColor = System.Drawing.Color.Transparent;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblConnection.Location = new System.Drawing.Point(1371, 14);
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
            this.lblUserInfo.Location = new System.Drawing.Point(12, 14);
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
            this.bunifuPanel1.Controls.Add(this.lblDate);
            this.bunifuPanel1.Controls.Add(this.lblTopTitle);
            this.bunifuPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1538, 79);
            this.bunifuPanel1.TabIndex = 27;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(738, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 30);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Saturday, November 22, 2025";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.BackColor = System.Drawing.Color.White;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTopTitle.Location = new System.Drawing.Point(19, 23);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "Activity Log";
            // 
            // ActivityLogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDirectory);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ActivityLogPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.Enter += new System.EventHandler(this.ActivityLogPage_Enter);
            this.pnlDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activtylogDgv)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTopTitle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserInfo;
        private Bunifu.UI.WinForms.BunifuPanel pnlDirectory;
        private Bunifu.UI.WinForms.BunifuDataGridView activtylogDgv;
        private Bunifu.UI.WinForms.BunifuDropdown typeDropdown;
        private System.Windows.Forms.Label lblHeader;
    }
}
