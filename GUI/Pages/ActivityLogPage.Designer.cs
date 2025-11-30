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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.pnlDirectory = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuDataGridView3 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.typeDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblHeader = new System.Windows.Forms.Label();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.pnlDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Controls.Add(this.lblTopTitle);
            this.bunifuPanel1.Location = new System.Drawing.Point(1, 1);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1538, 79);
            this.bunifuPanel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(738, 25);
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
            this.lblTopTitle.Size = new System.Drawing.Size(138, 32);
            this.lblTopTitle.TabIndex = 4;
            this.lblTopTitle.Text = "Activity Log";
            // 
            // pnlDirectory
            // 
            this.pnlDirectory.BackgroundColor = System.Drawing.Color.White;
            this.pnlDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDirectory.BackgroundImage")));
            this.pnlDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDirectory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlDirectory.BorderRadius = 20;
            this.pnlDirectory.BorderThickness = 1;
            this.pnlDirectory.Controls.Add(this.bunifuDataGridView3);
            this.pnlDirectory.Controls.Add(this.bunifuDataGridView2);
            this.pnlDirectory.Controls.Add(this.typeDropdown);
            this.pnlDirectory.Controls.Add(this.lblHeader);
            this.pnlDirectory.Location = new System.Drawing.Point(49, 131);
            this.pnlDirectory.Margin = new System.Windows.Forms.Padding(30);
            this.pnlDirectory.Name = "pnlDirectory";
            this.pnlDirectory.ShowBorders = true;
            this.pnlDirectory.Size = new System.Drawing.Size(1445, 346);
            this.pnlDirectory.TabIndex = 29;
            // 
            // bunifuDataGridView3
            // 
            this.bunifuDataGridView3.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView3.ColumnHeadersHeight = 40;
            this.bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView3.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView3.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView3.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView3.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView3.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView3.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView3.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView3.CurrentTheme.Name = null;
            this.bunifuDataGridView3.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView3.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView3.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView3.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView3.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView3.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView3.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView3.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView3.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView3.Location = new System.Drawing.Point(53, 86);
            this.bunifuDataGridView3.Name = "bunifuDataGridView3";
            this.bunifuDataGridView3.RowHeadersVisible = false;
            this.bunifuDataGridView3.RowHeadersWidth = 53;
            this.bunifuDataGridView3.RowTemplate.Height = 40;
            this.bunifuDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView3.Size = new System.Drawing.Size(1341, 215);
            this.bunifuDataGridView3.TabIndex = 23;
            this.bunifuDataGridView3.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView2.ColumnHeadersHeight = 40;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.Name = null;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(334, 25);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowHeadersWidth = 53;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(8, 8);
            this.bunifuDataGridView2.TabIndex = 22;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            // ActivityLogPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDirectory);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ActivityLogPage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.pnlDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTopTitle;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblUserInfo;
        private Bunifu.UI.WinForms.BunifuPanel pnlDirectory;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView3;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView2;
        private Bunifu.UI.WinForms.BunifuDropdown typeDropdown;
        private System.Windows.Forms.Label lblHeader;
    }
}
