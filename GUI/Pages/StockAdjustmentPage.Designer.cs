namespace ERP_System.GUI.Pages
{
    partial class StockAdjustmentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockAdjustmentPage));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.tabStock = new TradeWright.UI.Forms.TabControlExtra();
            this.tabAdjust = new System.Windows.Forms.TabPage();
            this.pnlAdjustForm = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtNotes = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.ddlReason = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.ddlType = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblType = new System.Windows.Forms.Label();
            this.ddlProduct = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnApplyAdjustment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.pnlLog = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgvAuditLog = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabAdjust.SuspendLayout();
            this.pnlAdjustForm.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 0;
            this.pnlMain.BorderThickness = 0;
            this.pnlMain.Controls.Add(this.pnlContainer);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1155, 687);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlContainer.BackgroundColor = System.Drawing.Color.White;
            this.pnlContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContainer.BorderColor = System.Drawing.Color.LightGray;
            this.pnlContainer.BorderRadius = 20;
            this.pnlContainer.BorderThickness = 1;
            this.pnlContainer.Controls.Add(this.tabStock);
            this.pnlContainer.Location = new System.Drawing.Point(86, 36);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShowBorders = true;
            this.pnlContainer.Size = new System.Drawing.Size(1150, 615);
            this.pnlContainer.TabIndex = 11;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.tabAdjust);
            this.tabStock.Controls.Add(this.tabLog);
            this.tabStock.DisplayStyle = TradeWright.UI.Forms.TabStyle.Rounded;
            this.tabStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStock.HotTrack = true;
            this.tabStock.Location = new System.Drawing.Point(0, 0);
            this.tabStock.Margin = new System.Windows.Forms.Padding(2);
            this.tabStock.Name = "tabStock";
            this.tabStock.SelectedIndex = 0;
            this.tabStock.Size = new System.Drawing.Size(1150, 615);
            this.tabStock.TabIndex = 11;
            // 
            // tabAdjust
            // 
            this.tabAdjust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAdjust.Controls.Add(this.pnlAdjustForm);
            this.tabAdjust.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdjust.ForeColor = System.Drawing.Color.Black;
            this.tabAdjust.Location = new System.Drawing.Point(4, 26);
            this.tabAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdjust.Name = "tabAdjust";
            this.tabAdjust.Padding = new System.Windows.Forms.Padding(2);
            this.tabAdjust.Size = new System.Drawing.Size(1142, 585);
            this.tabAdjust.TabIndex = 0;
            this.tabAdjust.Text = "Adjust Stock";
            this.tabAdjust.UseVisualStyleBackColor = true;
            // 
            // pnlAdjustForm
            // 
            this.pnlAdjustForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAdjustForm.BackgroundColor = System.Drawing.Color.White;
            this.pnlAdjustForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAdjustForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlAdjustForm.BorderRadius = 20;
            this.pnlAdjustForm.BorderThickness = 1;
            this.pnlAdjustForm.Controls.Add(this.txtNotes);
            this.pnlAdjustForm.Controls.Add(this.lblNotes);
            this.pnlAdjustForm.Controls.Add(this.ddlReason);
            this.pnlAdjustForm.Controls.Add(this.lblReason);
            this.pnlAdjustForm.Controls.Add(this.txtQty);
            this.pnlAdjustForm.Controls.Add(this.lblQty);
            this.pnlAdjustForm.Controls.Add(this.ddlType);
            this.pnlAdjustForm.Controls.Add(this.lblType);
            this.pnlAdjustForm.Controls.Add(this.ddlProduct);
            this.pnlAdjustForm.Controls.Add(this.lblProduct);
            this.pnlAdjustForm.Controls.Add(this.lblFormTitle);
            this.pnlAdjustForm.Controls.Add(this.btnApplyAdjustment);
            this.pnlAdjustForm.Location = new System.Drawing.Point(19, 25);
            this.pnlAdjustForm.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.pnlAdjustForm.Name = "pnlAdjustForm";
            this.pnlAdjustForm.ShowBorders = true;
            this.pnlAdjustForm.Size = new System.Drawing.Size(1099, 444);
            this.pnlAdjustForm.TabIndex = 13;
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = false;
            this.txtNotes.AcceptsTab = false;
            this.txtNotes.AnimationSpeed = 200;
            this.txtNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNotes.AutoSizeHeight = true;
            this.txtNotes.BackColor = System.Drawing.Color.Transparent;
            this.txtNotes.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtNotes.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNotes.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtNotes.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtNotes.BorderRadius = 5;
            this.txtNotes.BorderThickness = 1;
            this.txtNotes.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtNotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNotes.DefaultText = "";
            this.txtNotes.FillColor = System.Drawing.Color.Gainsboro;
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.HideSelection = true;
            this.txtNotes.IconLeft = null;
            this.txtNotes.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.IconPadding = 10;
            this.txtNotes.IconRight = null;
            this.txtNotes.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(21, 315);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNotes.Modified = false;
            this.txtNotes.Multiline = false;
            this.txtNotes.Name = "txtNotes";
            stateProperties1.BorderColor = System.Drawing.Color.LightGray;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNotes.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Silver;
            stateProperties3.FillColor = System.Drawing.Color.LightGray;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNotes.OnIdleState = stateProperties4;
            this.txtNotes.Padding = new System.Windows.Forms.Padding(2);
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNotes.PlaceholderText = "Additional Notes...";
            this.txtNotes.ReadOnly = false;
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(582, 36);
            this.txtNotes.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNotes.TabIndex = 24;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNotes.TextMarginBottom = 0;
            this.txtNotes.TextMarginLeft = 3;
            this.txtNotes.TextMarginTop = 1;
            this.txtNotes.TextPlaceholder = "Additional Notes...";
            this.txtNotes.UseSystemPasswordChar = false;
            this.txtNotes.WordWrap = true;
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.Color.Transparent;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblNotes.Location = new System.Drawing.Point(17, 285);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(137, 20);
            this.lblNotes.TabIndex = 23;
            this.lblNotes.Text = "Notes";
            // 
            // ddlReason
            // 
            this.ddlReason.BackColor = System.Drawing.Color.Transparent;
            this.ddlReason.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ddlReason.BorderColor = System.Drawing.Color.Gainsboro;
            this.ddlReason.BorderRadius = 5;
            this.ddlReason.Color = System.Drawing.Color.Gainsboro;
            this.ddlReason.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlReason.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlReason.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlReason.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlReason.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlReason.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlReason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlReason.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlReason.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlReason.FillDropDown = true;
            this.ddlReason.FillIndicator = false;
            this.ddlReason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlReason.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddlReason.FormattingEnabled = true;
            this.ddlReason.Icon = null;
            this.ddlReason.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlReason.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlReason.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlReason.IndicatorThickness = 2;
            this.ddlReason.IsDropdownOpened = false;
            this.ddlReason.ItemBackColor = System.Drawing.Color.White;
            this.ddlReason.ItemBorderColor = System.Drawing.Color.White;
            this.ddlReason.ItemForeColor = System.Drawing.Color.Black;
            this.ddlReason.ItemHeight = 26;
            this.ddlReason.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlReason.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlReason.ItemTopMargin = 3;
            this.ddlReason.Location = new System.Drawing.Point(21, 245);
            this.ddlReason.Margin = new System.Windows.Forms.Padding(2);
            this.ddlReason.Name = "ddlReason";
            this.ddlReason.Size = new System.Drawing.Size(583, 32);
            this.ddlReason.TabIndex = 22;
            this.ddlReason.Text = "Select Reason";
            this.ddlReason.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlReason.TextLeftMargin = 5;
            // 
            // lblReason
            // 
            this.lblReason.BackColor = System.Drawing.Color.Transparent;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblReason.Location = new System.Drawing.Point(17, 215);
            this.lblReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(114, 20);
            this.lblReason.TabIndex = 21;
            this.lblReason.Text = "Reason";
            // 
            // txtQty
            // 
            this.txtQty.AcceptsReturn = false;
            this.txtQty.AcceptsTab = false;
            this.txtQty.AnimationSpeed = 200;
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQty.AutoSizeHeight = true;
            this.txtQty.BackColor = System.Drawing.Color.Transparent;
            this.txtQty.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtQty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtQty.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtQty.BorderRadius = 5;
            this.txtQty.BorderThickness = 1;
            this.txtQty.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtQty.DefaultText = "";
            this.txtQty.FillColor = System.Drawing.Color.Gainsboro;
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.HideSelection = true;
            this.txtQty.IconLeft = null;
            this.txtQty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.IconPadding = 10;
            this.txtQty.IconRight = null;
            this.txtQty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(308, 176);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2);
            this.txtQty.MaxLength = 32767;
            this.txtQty.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQty.Modified = false;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            stateProperties5.BorderColor = System.Drawing.Color.LightGray;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQty.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Silver;
            stateProperties7.FillColor = System.Drawing.Color.LightGray;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnIdleState = stateProperties8;
            this.txtQty.Padding = new System.Windows.Forms.Padding(2);
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.PlaceholderText = "0";
            this.txtQty.ReadOnly = false;
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(296, 36);
            this.txtQty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQty.TabIndex = 20;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.TextMarginBottom = 0;
            this.txtQty.TextMarginLeft = 3;
            this.txtQty.TextMarginTop = 1;
            this.txtQty.TextPlaceholder = "0";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WordWrap = true;
            // 
            // lblQty
            // 
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblQty.Location = new System.Drawing.Point(304, 146);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(137, 20);
            this.lblQty.TabIndex = 19;
            this.lblQty.Text = "Quantity";
            // 
            // ddlType
            // 
            this.ddlType.BackColor = System.Drawing.Color.Transparent;
            this.ddlType.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ddlType.BorderColor = System.Drawing.Color.Gainsboro;
            this.ddlType.BorderRadius = 5;
            this.ddlType.Color = System.Drawing.Color.Gainsboro;
            this.ddlType.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlType.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlType.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlType.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlType.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlType.FillDropDown = true;
            this.ddlType.FillIndicator = false;
            this.ddlType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlType.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddlType.FormattingEnabled = true;
            this.ddlType.Icon = null;
            this.ddlType.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlType.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlType.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlType.IndicatorThickness = 2;
            this.ddlType.IsDropdownOpened = false;
            this.ddlType.ItemBackColor = System.Drawing.Color.White;
            this.ddlType.ItemBorderColor = System.Drawing.Color.White;
            this.ddlType.ItemForeColor = System.Drawing.Color.Black;
            this.ddlType.ItemHeight = 26;
            this.ddlType.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlType.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlType.ItemTopMargin = 3;
            this.ddlType.Location = new System.Drawing.Point(21, 176);
            this.ddlType.Margin = new System.Windows.Forms.Padding(2);
            this.ddlType.Name = "ddlType";
            this.ddlType.Size = new System.Drawing.Size(275, 32);
            this.ddlType.TabIndex = 18;
            this.ddlType.Text = "Select Type";
            this.ddlType.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlType.TextLeftMargin = 5;
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblType.Location = new System.Drawing.Point(17, 146);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(137, 20);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Adjustment Type";
            // 
            // ddlProduct
            // 
            this.ddlProduct.BackColor = System.Drawing.Color.Transparent;
            this.ddlProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ddlProduct.BorderColor = System.Drawing.Color.Gainsboro;
            this.ddlProduct.BorderRadius = 5;
            this.ddlProduct.Color = System.Drawing.Color.Gainsboro;
            this.ddlProduct.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlProduct.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddlProduct.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddlProduct.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddlProduct.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlProduct.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddlProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProduct.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlProduct.FillDropDown = true;
            this.ddlProduct.FillIndicator = false;
            this.ddlProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlProduct.Font = new System.Drawing.Font("Segoe UI", 9.792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ddlProduct.FormattingEnabled = true;
            this.ddlProduct.Icon = null;
            this.ddlProduct.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlProduct.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ddlProduct.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlProduct.IndicatorThickness = 2;
            this.ddlProduct.IsDropdownOpened = false;
            this.ddlProduct.ItemBackColor = System.Drawing.Color.White;
            this.ddlProduct.ItemBorderColor = System.Drawing.Color.White;
            this.ddlProduct.ItemForeColor = System.Drawing.Color.Black;
            this.ddlProduct.ItemHeight = 26;
            this.ddlProduct.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddlProduct.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddlProduct.ItemTopMargin = 3;
            this.ddlProduct.Location = new System.Drawing.Point(21, 106);
            this.ddlProduct.Margin = new System.Windows.Forms.Padding(2);
            this.ddlProduct.Name = "ddlProduct";
            this.ddlProduct.Size = new System.Drawing.Size(583, 32);
            this.ddlProduct.TabIndex = 16;
            this.ddlProduct.Text = "Choose Product";
            this.ddlProduct.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlProduct.TextLeftMargin = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblProduct.Location = new System.Drawing.Point(17, 76);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(114, 20);
            this.lblProduct.TabIndex = 15;
            this.lblProduct.Text = "Select Product";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormTitle.Location = new System.Drawing.Point(16, 20);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(233, 25);
            this.lblFormTitle.TabIndex = 13;
            this.lblFormTitle.Text = "Manual Stock Adjustment";
            // 
            // btnApplyAdjustment
            // 
            this.btnApplyAdjustment.AllowAnimations = true;
            this.btnApplyAdjustment.AllowMouseEffects = true;
            this.btnApplyAdjustment.AllowToggling = false;
            this.btnApplyAdjustment.AnimationSpeed = 200;
            this.btnApplyAdjustment.AutoGenerateColors = false;
            this.btnApplyAdjustment.AutoRoundBorders = false;
            this.btnApplyAdjustment.AutoSizeLeftIcon = true;
            this.btnApplyAdjustment.AutoSizeRightIcon = true;
            this.btnApplyAdjustment.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyAdjustment.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnApplyAdjustment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyAdjustment.ButtonText = "Apply Adjustment";
            this.btnApplyAdjustment.ButtonTextMarginLeft = 0;
            this.btnApplyAdjustment.ColorContrastOnClick = 45;
            this.btnApplyAdjustment.ColorContrastOnHover = 45;
            this.btnApplyAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnApplyAdjustment.CustomizableEdges = borderEdges1;
            this.btnApplyAdjustment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApplyAdjustment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplyAdjustment.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnApplyAdjustment.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnApplyAdjustment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnApplyAdjustment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApplyAdjustment.ForeColor = System.Drawing.Color.White;
            this.btnApplyAdjustment.IconLeft = null;
            this.btnApplyAdjustment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyAdjustment.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyAdjustment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnApplyAdjustment.IconMarginLeft = 11;
            this.btnApplyAdjustment.IconPadding = 10;
            this.btnApplyAdjustment.IconRight = null;
            this.btnApplyAdjustment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplyAdjustment.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyAdjustment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnApplyAdjustment.IconSize = 25;
            this.btnApplyAdjustment.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnApplyAdjustment.IdleBorderRadius = 6;
            this.btnApplyAdjustment.IdleBorderThickness = 1;
            this.btnApplyAdjustment.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnApplyAdjustment.IdleIconLeftImage = null;
            this.btnApplyAdjustment.IdleIconRightImage = null;
            this.btnApplyAdjustment.IndicateFocus = false;
            this.btnApplyAdjustment.Location = new System.Drawing.Point(21, 396);
            this.btnApplyAdjustment.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyAdjustment.Name = "btnApplyAdjustment";
            this.btnApplyAdjustment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnApplyAdjustment.OnDisabledState.BorderRadius = 15;
            this.btnApplyAdjustment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyAdjustment.OnDisabledState.BorderThickness = 1;
            this.btnApplyAdjustment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApplyAdjustment.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnApplyAdjustment.OnDisabledState.IconLeftImage = null;
            this.btnApplyAdjustment.OnDisabledState.IconRightImage = null;
            this.btnApplyAdjustment.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnApplyAdjustment.onHoverState.BorderRadius = 15;
            this.btnApplyAdjustment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyAdjustment.onHoverState.BorderThickness = 1;
            this.btnApplyAdjustment.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnApplyAdjustment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnApplyAdjustment.onHoverState.IconLeftImage = null;
            this.btnApplyAdjustment.onHoverState.IconRightImage = null;
            this.btnApplyAdjustment.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnApplyAdjustment.OnIdleState.BorderRadius = 15;
            this.btnApplyAdjustment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyAdjustment.OnIdleState.BorderThickness = 1;
            this.btnApplyAdjustment.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnApplyAdjustment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnApplyAdjustment.OnIdleState.IconLeftImage = null;
            this.btnApplyAdjustment.OnIdleState.IconRightImage = null;
            this.btnApplyAdjustment.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnApplyAdjustment.OnPressedState.BorderRadius = 15;
            this.btnApplyAdjustment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnApplyAdjustment.OnPressedState.BorderThickness = 1;
            this.btnApplyAdjustment.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnApplyAdjustment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnApplyAdjustment.OnPressedState.IconLeftImage = null;
            this.btnApplyAdjustment.OnPressedState.IconRightImage = null;
            this.btnApplyAdjustment.Size = new System.Drawing.Size(134, 33);
            this.btnApplyAdjustment.TabIndex = 10;
            this.btnApplyAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnApplyAdjustment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApplyAdjustment.TextMarginLeft = 0;
            this.btnApplyAdjustment.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnApplyAdjustment.UseDefaultRadiusAndThickness = true;
            // 
            // tabLog
            // 
            this.tabLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLog.Controls.Add(this.pnlLog);
            this.tabLog.Location = new System.Drawing.Point(4, 26);
            this.tabLog.Margin = new System.Windows.Forms.Padding(2);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(2);
            this.tabLog.Size = new System.Drawing.Size(1142, 585);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Audit Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // pnlLog
            // 
            this.pnlLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLog.BackgroundColor = System.Drawing.Color.White;
            this.pnlLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLog.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlLog.BorderRadius = 20;
            this.pnlLog.BorderThickness = 1;
            this.pnlLog.Controls.Add(this.dgvAuditLog);
            this.pnlLog.Controls.Add(this.lblLogTitle);
            this.pnlLog.Location = new System.Drawing.Point(22, 25);
            this.pnlLog.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.ShowBorders = true;
            this.pnlLog.Size = new System.Drawing.Size(1088, 284);
            this.pnlLog.TabIndex = 14;
            // 
            // dgvAuditLog
            // 
            this.dgvAuditLog.AllowCustomTheming = false;
            this.dgvAuditLog.AllowUserToAddRows = false;
            this.dgvAuditLog.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAuditLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuditLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAuditLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuditLog.ColumnHeadersHeight = 40;
            this.dgvAuditLog.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvAuditLog.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAuditLog.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAuditLog.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAuditLog.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAuditLog.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvAuditLog.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAuditLog.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAuditLog.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAuditLog.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAuditLog.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvAuditLog.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAuditLog.CurrentTheme.Name = null;
            this.dgvAuditLog.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuditLog.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAuditLog.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAuditLog.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvAuditLog.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditLog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditLog.EnableHeadersVisualStyles = false;
            this.dgvAuditLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvAuditLog.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvAuditLog.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAuditLog.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAuditLog.Location = new System.Drawing.Point(24, 70);
            this.dgvAuditLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAuditLog.Name = "dgvAuditLog";
            this.dgvAuditLog.ReadOnly = true;
            this.dgvAuditLog.RowHeadersVisible = false;
            this.dgvAuditLog.RowHeadersWidth = 53;
            this.dgvAuditLog.RowTemplate.Height = 40;
            this.dgvAuditLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditLog.Size = new System.Drawing.Size(1039, 183);
            this.dgvAuditLog.TabIndex = 15;
            this.dgvAuditLog.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblLogTitle
            // 
            this.lblLogTitle.AutoSize = true;
            this.lblLogTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogTitle.Location = new System.Drawing.Point(14, 23);
            this.lblLogTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogTitle.Name = "lblLogTitle";
            this.lblLogTitle.Size = new System.Drawing.Size(206, 23);
            this.lblLogTitle.TabIndex = 14;
            this.lblLogTitle.Text = "Stock Adjustment History";
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
            this.pnlHeader.Size = new System.Drawing.Size(892, 64);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(652, 19);
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
            this.lblPageTitle.Size = new System.Drawing.Size(157, 25);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Stock Adjustment";
            // 
            // StockAdjustmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "StockAdjustmentPage";
            this.Size = new System.Drawing.Size(1155, 687);
            this.pnlMain.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabAdjust.ResumeLayout(false);
            this.pnlAdjustForm.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.pnlLog.ResumeLayout(false);
            this.pnlLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlContainer;
        private TradeWright.UI.Forms.TabControlExtra tabStock;
        private System.Windows.Forms.TabPage tabAdjust;
        private Bunifu.UI.WinForms.BunifuPanel pnlAdjustForm;
        private Bunifu.UI.WinForms.BunifuTextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Bunifu.UI.WinForms.BunifuDropdown ddlReason;
        private System.Windows.Forms.Label lblReason;
        private Bunifu.UI.WinForms.BunifuTextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private Bunifu.UI.WinForms.BunifuDropdown ddlType;
        private System.Windows.Forms.Label lblType;
        private Bunifu.UI.WinForms.BunifuDropdown ddlProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblFormTitle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnApplyAdjustment;
        private System.Windows.Forms.TabPage tabLog;
        private Bunifu.UI.WinForms.BunifuPanel pnlLog;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvAuditLog;
        private System.Windows.Forms.Label lblLogTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
    }
}