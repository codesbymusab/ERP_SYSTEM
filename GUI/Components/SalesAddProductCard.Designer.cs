namespace ERP_System.GUI.Components
{
    partial class SalesAddProductCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesAddProductCard));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtProd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtunitPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblttl = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.txtProd.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtProd.BorderRadius = 5;
            this.txtProd.Color = System.Drawing.Color.Gainsboro;
            this.txtProd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.txtProd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtProd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtProd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.txtProd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtProd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.txtProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtProd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtProd.FillDropDown = true;
            this.txtProd.FillIndicator = false;
            this.txtProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProd.ForeColor = System.Drawing.Color.Black;
            this.txtProd.Icon = null;
            this.txtProd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtProd.IndicatorColor = System.Drawing.Color.DarkGray;
            this.txtProd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.txtProd.IndicatorThickness = 2;
            this.txtProd.IsDropdownOpened = false;
            this.txtProd.ItemBackColor = System.Drawing.Color.White;
            this.txtProd.ItemBorderColor = System.Drawing.Color.White;
            this.txtProd.ItemForeColor = System.Drawing.Color.Black;
            this.txtProd.ItemHeight = 26;
            this.txtProd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.txtProd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.txtProd.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.txtProd.ItemTopMargin = 3;
            this.txtProd.Location = new System.Drawing.Point(16, 25);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(215, 32);
            this.txtProd.TabIndex = 19;
            this.txtProd.Text = "Slect Product";
            this.txtProd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.txtProd.TextLeftMargin = 5;
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
            this.txtQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtQty.BackgroundImage")));
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
            this.txtQty.HideSelection = true;
            this.txtQty.IconLeft = null;
            this.txtQty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.IconPadding = 10;
            this.txtQty.IconRight = null;
            this.txtQty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(239, 25);
            this.txtQty.MaxLength = 32767;
            this.txtQty.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtQty.Modified = false;
            this.txtQty.Multiline = false;
            this.txtQty.Name = "txtQty";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtQty.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtQty.OnIdleState = stateProperties4;
            this.txtQty.Padding = new System.Windows.Forms.Padding(3);
            this.txtQty.PasswordChar = '\0';
            this.txtQty.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.PlaceholderText = "0";
            this.txtQty.ReadOnly = false;
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(90, 32);
            this.txtQty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtQty.TabIndex = 26;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQty.TextMarginBottom = 0;
            this.txtQty.TextMarginLeft = 3;
            this.txtQty.TextMarginTop = 1;
            this.txtQty.TextPlaceholder = "0";
            this.txtQty.UseSystemPasswordChar = false;
            this.txtQty.WordWrap = true;
            // 
            // txtunitPrice
            // 
            this.txtunitPrice.AcceptsReturn = false;
            this.txtunitPrice.AcceptsTab = false;
            this.txtunitPrice.AnimationSpeed = 200;
            this.txtunitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtunitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtunitPrice.AutoSizeHeight = true;
            this.txtunitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtunitPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtunitPrice.BackgroundImage")));
            this.txtunitPrice.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtunitPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtunitPrice.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtunitPrice.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtunitPrice.BorderRadius = 5;
            this.txtunitPrice.BorderThickness = 1;
            this.txtunitPrice.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtunitPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtunitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitPrice.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtunitPrice.DefaultText = "";
            this.txtunitPrice.FillColor = System.Drawing.Color.Gainsboro;
            this.txtunitPrice.HideSelection = true;
            this.txtunitPrice.IconLeft = null;
            this.txtunitPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitPrice.IconPadding = 10;
            this.txtunitPrice.IconRight = null;
            this.txtunitPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtunitPrice.Lines = new string[0];
            this.txtunitPrice.Location = new System.Drawing.Point(352, 25);
            this.txtunitPrice.MaxLength = 32767;
            this.txtunitPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtunitPrice.Modified = false;
            this.txtunitPrice.Multiline = false;
            this.txtunitPrice.Name = "txtunitPrice";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtunitPrice.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtunitPrice.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtunitPrice.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtunitPrice.OnIdleState = stateProperties8;
            this.txtunitPrice.Padding = new System.Windows.Forms.Padding(3);
            this.txtunitPrice.PasswordChar = '\0';
            this.txtunitPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtunitPrice.PlaceholderText = "0";
            this.txtunitPrice.ReadOnly = false;
            this.txtunitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtunitPrice.SelectedText = "";
            this.txtunitPrice.SelectionLength = 0;
            this.txtunitPrice.SelectionStart = 0;
            this.txtunitPrice.ShortcutsEnabled = true;
            this.txtunitPrice.Size = new System.Drawing.Size(90, 32);
            this.txtunitPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtunitPrice.TabIndex = 27;
            this.txtunitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtunitPrice.TextMarginBottom = 0;
            this.txtunitPrice.TextMarginLeft = 3;
            this.txtunitPrice.TextMarginTop = 1;
            this.txtunitPrice.TextPlaceholder = "0";
            this.txtunitPrice.UseSystemPasswordChar = false;
            this.txtunitPrice.WordWrap = true;
            // 
            // lblttl
            // 
            this.lblttl.BackColor = System.Drawing.Color.Transparent;
            this.lblttl.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold);
            this.lblttl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblttl.Location = new System.Drawing.Point(484, 25);
            this.lblttl.Name = "lblttl";
            this.lblttl.Size = new System.Drawing.Size(92, 32);
            this.lblttl.TabIndex = 51;
            this.lblttl.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowMouseEffects = true;
            this.btnDelete.AllowToggling = false;
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.AnimationSpeed = 200;
            this.btnDelete.AutoGenerateColors = false;
            this.btnDelete.AutoRoundBorders = false;
            this.btnDelete.AutoSizeLeftIcon = true;
            this.btnDelete.AutoSizeRightIcon = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.ButtonTextMarginLeft = 0;
            this.btnDelete.ColorContrastOnClick = 45;
            this.btnDelete.ColorContrastOnHover = 45;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDelete.CustomizableEdges = borderEdges1;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDelete.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconLeft = null;
            this.btnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDelete.IconMarginLeft = 11;
            this.btnDelete.IconPadding = 10;
            this.btnDelete.IconRight = null;
            this.btnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDelete.IconSize = 25;
            this.btnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDelete.IdleBorderRadius = 6;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnDelete.IdleIconLeftImage = null;
            this.btnDelete.IdleIconRightImage = null;
            this.btnDelete.IndicateFocus = false;
            this.btnDelete.Location = new System.Drawing.Point(582, 25);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDelete.OnDisabledState.BorderRadius = 15;
            this.btnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnDisabledState.BorderThickness = 2;
            this.btnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDelete.OnDisabledState.IconLeftImage = null;
            this.btnDelete.OnDisabledState.IconRightImage = null;
            this.btnDelete.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.onHoverState.BorderRadius = 15;
            this.btnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.onHoverState.BorderThickness = 2;
            this.btnDelete.onHoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.onHoverState.IconLeftImage = null;
            this.btnDelete.onHoverState.IconRightImage = null;
            this.btnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.OnIdleState.BorderRadius = 15;
            this.btnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnIdleState.BorderThickness = 2;
            this.btnDelete.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnDelete.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnIdleState.IconLeftImage = null;
            this.btnDelete.OnIdleState.IconRightImage = null;
            this.btnDelete.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnPressedState.BorderRadius = 15;
            this.btnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDelete.OnPressedState.BorderThickness = 2;
            this.btnDelete.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDelete.OnPressedState.IconLeftImage = null;
            this.btnDelete.OnPressedState.IconRightImage = null;
            this.btnDelete.Size = new System.Drawing.Size(108, 32);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextMarginLeft = 0;
            this.btnDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDelete.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.DarkGray;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 2;
            this.bunifuPanel2.Controls.Add(this.btnDelete);
            this.bunifuPanel2.Controls.Add(this.lblttl);
            this.bunifuPanel2.Controls.Add(this.txtunitPrice);
            this.bunifuPanel2.Controls.Add(this.txtQty);
            this.bunifuPanel2.Controls.Add(this.txtProd);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(726, 86);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // SalesAddProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuPanel2);
            this.Name = "SalesAddProductCard";
            this.Size = new System.Drawing.Size(726, 86);
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuDropdown txtProd;
        public Bunifu.UI.WinForms.BunifuTextBox txtQty;
        public Bunifu.UI.WinForms.BunifuTextBox txtunitPrice;
        private System.Windows.Forms.Label lblttl;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDelete;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
    }
}
