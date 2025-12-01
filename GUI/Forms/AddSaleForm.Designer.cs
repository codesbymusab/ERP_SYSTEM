namespace ERP_System.GUI.Forms
{
    partial class AddSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSaleForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTaxPer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.txtlName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDraft = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 269);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblDate.Location = new System.Drawing.Point(318, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(131, 23);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // lblCusName
            // 
            this.lblCusName.BackColor = System.Drawing.Color.Transparent;
            this.lblCusName.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.lblCusName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblCusName.Location = new System.Drawing.Point(23, 65);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(164, 23);
            this.lblCusName.TabIndex = 26;
            this.lblCusName.Text = "CustomerName";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 33);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "New Sale / Invoice";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(103, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(264, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(378, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(515, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(643, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Action";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuSeparator2);
            this.bunifuPanel1.Controls.Add(this.lblTotal);
            this.bunifuPanel1.Controls.Add(this.lblTax);
            this.bunifuPanel1.Controls.Add(this.lblSubtotal);
            this.bunifuPanel1.Controls.Add(this.label8);
            this.bunifuPanel1.Controls.Add(this.lblTaxPer);
            this.bunifuPanel1.Controls.Add(this.label6);
            this.bunifuPanel1.Location = new System.Drawing.Point(50, 562);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(703, 180);
            this.bunifuPanel1.TabIndex = 46;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Gray;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-4, 107);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(703, 17);
            this.bunifuSeparator2.TabIndex = 51;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblTotal.Location = new System.Drawing.Point(562, 128);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 23);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.BackColor = System.Drawing.Color.Transparent;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblTax.Location = new System.Drawing.Point(562, 69);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(109, 23);
            this.lblTax.TabIndex = 49;
            this.lblTax.Text = "Tax(8%):";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblSubtotal.Location = new System.Drawing.Point(562, 18);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(131, 23);
            this.lblSubtotal.TabIndex = 48;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label8.Location = new System.Drawing.Point(30, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Total:";
            // 
            // lblTaxPer
            // 
            this.lblTaxPer.BackColor = System.Drawing.Color.Transparent;
            this.lblTaxPer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblTaxPer.Location = new System.Drawing.Point(30, 69);
            this.lblTaxPer.Name = "lblTaxPer";
            this.lblTaxPer.Size = new System.Drawing.Size(109, 23);
            this.lblTaxPer.TabIndex = 46;
            this.lblTaxPer.Text = "Tax(8%):";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.label6.Location = new System.Drawing.Point(30, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "Subtotal";
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
            this.bunifuSeparator1.Location = new System.Drawing.Point(50, 538);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(703, 17);
            this.bunifuSeparator1.TabIndex = 0;
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuDatePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.BorderRadius = 5;
            this.bunifuDatePicker1.Color = System.Drawing.Color.Transparent;
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.LeftTextMargin = 5;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(323, 103);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(4, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(258, 32);
            this.bunifuDatePicker1.TabIndex = 29;
            // 
            // txtlName
            // 
            this.txtlName.AcceptsReturn = false;
            this.txtlName.AcceptsTab = false;
            this.txtlName.AnimationSpeed = 200;
            this.txtlName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtlName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtlName.AutoSizeHeight = true;
            this.txtlName.BackColor = System.Drawing.Color.Transparent;
            this.txtlName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtlName.BackgroundImage")));
            this.txtlName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtlName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtlName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtlName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtlName.BorderRadius = 5;
            this.txtlName.BorderThickness = 1;
            this.txtlName.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtlName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtlName.DefaultText = "";
            this.txtlName.FillColor = System.Drawing.Color.Gainsboro;
            this.txtlName.HideSelection = true;
            this.txtlName.IconLeft = null;
            this.txtlName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlName.IconPadding = 10;
            this.txtlName.IconRight = null;
            this.txtlName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlName.Lines = new string[0];
            this.txtlName.Location = new System.Drawing.Point(28, 103);
            this.txtlName.MaxLength = 32767;
            this.txtlName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtlName.Modified = false;
            this.txtlName.Multiline = false;
            this.txtlName.Name = "txtlName";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtlName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtlName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtlName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtlName.OnIdleState = stateProperties8;
            this.txtlName.Padding = new System.Windows.Forms.Padding(3);
            this.txtlName.PasswordChar = '\0';
            this.txtlName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlName.PlaceholderText = "Enter Customer Name";
            this.txtlName.ReadOnly = false;
            this.txtlName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlName.SelectedText = "";
            this.txtlName.SelectionLength = 0;
            this.txtlName.SelectionStart = 0;
            this.txtlName.ShortcutsEnabled = true;
            this.txtlName.Size = new System.Drawing.Size(258, 32);
            this.txtlName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtlName.TabIndex = 25;
            this.txtlName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlName.TextMarginBottom = 0;
            this.txtlName.TextMarginLeft = 3;
            this.txtlName.TextMarginTop = 1;
            this.txtlName.TextPlaceholder = "Enter Customer Name";
            this.txtlName.UseSystemPasswordChar = false;
            this.txtlName.WordWrap = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.AllowAnimations = true;
            this.btnAddItem.AllowMouseEffects = true;
            this.btnAddItem.AllowToggling = false;
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.AnimationSpeed = 200;
            this.btnAddItem.AutoGenerateColors = false;
            this.btnAddItem.AutoRoundBorders = false;
            this.btnAddItem.AutoSizeLeftIcon = true;
            this.btnAddItem.AutoSizeRightIcon = true;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.ButtonText = "+ Add Item";
            this.btnAddItem.ButtonTextMarginLeft = 0;
            this.btnAddItem.ColorContrastOnClick = 45;
            this.btnAddItem.ColorContrastOnHover = 45;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAddItem.CustomizableEdges = borderEdges5;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddItem.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddItem.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.IconLeft = null;
            this.btnAddItem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddItem.IconMarginLeft = 11;
            this.btnAddItem.IconPadding = 10;
            this.btnAddItem.IconRight = null;
            this.btnAddItem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddItem.IconSize = 25;
            this.btnAddItem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddItem.IdleBorderRadius = 6;
            this.btnAddItem.IdleBorderThickness = 1;
            this.btnAddItem.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddItem.IdleIconLeftImage = null;
            this.btnAddItem.IdleIconRightImage = null;
            this.btnAddItem.IndicateFocus = false;
            this.btnAddItem.Location = new System.Drawing.Point(50, 152);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddItem.OnDisabledState.BorderRadius = 15;
            this.btnAddItem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnDisabledState.BorderThickness = 1;
            this.btnAddItem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddItem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddItem.OnDisabledState.IconLeftImage = null;
            this.btnAddItem.OnDisabledState.IconRightImage = null;
            this.btnAddItem.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.onHoverState.BorderRadius = 15;
            this.btnAddItem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.onHoverState.BorderThickness = 1;
            this.btnAddItem.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddItem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.onHoverState.IconLeftImage = null;
            this.btnAddItem.onHoverState.IconRightImage = null;
            this.btnAddItem.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.OnIdleState.BorderRadius = 15;
            this.btnAddItem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnIdleState.BorderThickness = 1;
            this.btnAddItem.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnAddItem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnIdleState.IconLeftImage = null;
            this.btnAddItem.OnIdleState.IconRightImage = null;
            this.btnAddItem.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddItem.OnPressedState.BorderRadius = 15;
            this.btnAddItem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddItem.OnPressedState.BorderThickness = 1;
            this.btnAddItem.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnAddItem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.OnPressedState.IconLeftImage = null;
            this.btnAddItem.OnPressedState.IconRightImage = null;
            this.btnAddItem.Size = new System.Drawing.Size(149, 41);
            this.btnAddItem.TabIndex = 31;
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddItem.TextMarginLeft = 0;
            this.btnAddItem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAddItem.UseDefaultRadiusAndThickness = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.AllowAnimations = true;
            this.btnSave.AllowMouseEffects = true;
            this.btnSave.AllowToggling = false;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.AutoRoundBorders = false;
            this.btnSave.AutoSizeLeftIcon = true;
            this.btnSave.AutoSizeRightIcon = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Finalize && Update Stock";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges6;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.064F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconLeft = null;
            this.btnSave.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRight = null;
            this.btnSave.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSave.IconSize = 25;
            this.btnSave.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.IdleBorderRadius = 6;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(574, 768);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSave.OnDisabledState.BorderRadius = 15;
            this.btnSave.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnDisabledState.BorderThickness = 1;
            this.btnSave.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.OnDisabledState.IconLeftImage = null;
            this.btnSave.OnDisabledState.IconRightImage = null;
            this.btnSave.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.onHoverState.BorderRadius = 15;
            this.btnSave.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.onHoverState.BorderThickness = 1;
            this.btnSave.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnSave.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.onHoverState.IconLeftImage = null;
            this.btnSave.onHoverState.IconRightImage = null;
            this.btnSave.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnSave.OnIdleState.BorderRadius = 15;
            this.btnSave.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnIdleState.BorderThickness = 1;
            this.btnSave.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnSave.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnIdleState.IconLeftImage = null;
            this.btnSave.OnIdleState.IconRightImage = null;
            this.btnSave.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSave.OnPressedState.BorderRadius = 15;
            this.btnSave.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.OnPressedState.BorderThickness = 1;
            this.btnSave.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnSave.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSave.OnPressedState.IconLeftImage = null;
            this.btnSave.OnPressedState.IconRightImage = null;
            this.btnSave.Size = new System.Drawing.Size(197, 41);
            this.btnSave.TabIndex = 27;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowAnimations = true;
            this.btnCancel.AllowMouseEffects = true;
            this.btnCancel.AllowToggling = false;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.AutoRoundBorders = false;
            this.btnCancel.AutoSizeLeftIcon = true;
            this.btnCancel.AutoSizeRightIcon = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges7;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnCancel.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.IconLeft = null;
            this.btnCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRight = null;
            this.btnCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancel.IconSize = 25;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCancel.IdleBorderRadius = 6;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(263, 768);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancel.OnDisabledState.BorderRadius = 15;
            this.btnCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnDisabledState.BorderThickness = 2;
            this.btnCancel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.OnDisabledState.IconLeftImage = null;
            this.btnCancel.OnDisabledState.IconRightImage = null;
            this.btnCancel.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.onHoverState.BorderRadius = 15;
            this.btnCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.onHoverState.BorderThickness = 2;
            this.btnCancel.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnCancel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.onHoverState.IconLeftImage = null;
            this.btnCancel.onHoverState.IconRightImage = null;
            this.btnCancel.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.OnIdleState.BorderRadius = 15;
            this.btnCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnIdleState.BorderThickness = 2;
            this.btnCancel.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.OnIdleState.IconLeftImage = null;
            this.btnCancel.OnIdleState.IconRightImage = null;
            this.btnCancel.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.OnPressedState.BorderRadius = 15;
            this.btnCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancel.OnPressedState.BorderThickness = 2;
            this.btnCancel.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancel.OnPressedState.IconLeftImage = null;
            this.btnCancel.OnPressedState.IconRightImage = null;
            this.btnCancel.Size = new System.Drawing.Size(149, 41);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.AllowAnimations = true;
            this.btnDraft.AllowMouseEffects = true;
            this.btnDraft.AllowToggling = false;
            this.btnDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraft.AnimationSpeed = 200;
            this.btnDraft.AutoGenerateColors = false;
            this.btnDraft.AutoRoundBorders = false;
            this.btnDraft.AutoSizeLeftIcon = true;
            this.btnDraft.AutoSizeRightIcon = true;
            this.btnDraft.BackColor = System.Drawing.Color.Transparent;
            this.btnDraft.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDraft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDraft.BackgroundImage")));
            this.btnDraft.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDraft.ButtonText = "Save as Draft";
            this.btnDraft.ButtonTextMarginLeft = 0;
            this.btnDraft.ColorContrastOnClick = 45;
            this.btnDraft.ColorContrastOnHover = 45;
            this.btnDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnDraft.CustomizableEdges = borderEdges8;
            this.btnDraft.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDraft.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDraft.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDraft.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDraft.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDraft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDraft.ForeColor = System.Drawing.Color.Black;
            this.btnDraft.IconLeft = null;
            this.btnDraft.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraft.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraft.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDraft.IconMarginLeft = 11;
            this.btnDraft.IconPadding = 10;
            this.btnDraft.IconRight = null;
            this.btnDraft.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDraft.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraft.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDraft.IconSize = 25;
            this.btnDraft.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDraft.IdleBorderRadius = 6;
            this.btnDraft.IdleBorderThickness = 1;
            this.btnDraft.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDraft.IdleIconLeftImage = null;
            this.btnDraft.IdleIconRightImage = null;
            this.btnDraft.IndicateFocus = false;
            this.btnDraft.Location = new System.Drawing.Point(418, 768);
            this.btnDraft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDraft.OnDisabledState.BorderRadius = 15;
            this.btnDraft.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDraft.OnDisabledState.BorderThickness = 2;
            this.btnDraft.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDraft.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDraft.OnDisabledState.IconLeftImage = null;
            this.btnDraft.OnDisabledState.IconRightImage = null;
            this.btnDraft.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDraft.onHoverState.BorderRadius = 15;
            this.btnDraft.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDraft.onHoverState.BorderThickness = 2;
            this.btnDraft.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnDraft.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDraft.onHoverState.IconLeftImage = null;
            this.btnDraft.onHoverState.IconRightImage = null;
            this.btnDraft.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDraft.OnIdleState.BorderRadius = 15;
            this.btnDraft.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDraft.OnIdleState.BorderThickness = 2;
            this.btnDraft.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnDraft.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnDraft.OnIdleState.IconLeftImage = null;
            this.btnDraft.OnIdleState.IconRightImage = null;
            this.btnDraft.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDraft.OnPressedState.BorderRadius = 15;
            this.btnDraft.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDraft.OnPressedState.BorderThickness = 2;
            this.btnDraft.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnDraft.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDraft.OnPressedState.IconLeftImage = null;
            this.btnDraft.OnPressedState.IconRightImage = null;
            this.btnDraft.Size = new System.Drawing.Size(149, 41);
            this.btnDraft.TabIndex = 38;
            this.btnDraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDraft.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDraft.TextMarginLeft = 0;
            this.btnDraft.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDraft.UseDefaultRadiusAndThickness = true;
            this.btnDraft.Click += new System.EventHandler(this.BtnDraft_Click);
            // 
            // AddSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 846);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnDraft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCusName);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSaleForm";
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblDate;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
        private System.Windows.Forms.Label lblCusName;
        public Bunifu.UI.WinForms.BunifuTextBox txtlName;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTaxPer;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddItem;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDraft;
    }
}