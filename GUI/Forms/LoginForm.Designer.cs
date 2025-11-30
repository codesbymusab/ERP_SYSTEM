namespace ERP_System.GUI.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.cardLogin = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblPasswordLabel = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lnkForgotPassword = new System.Windows.Forms.Label();
            this.pnlDemo = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDemoTitle = new System.Windows.Forms.Label();
            this.lblDemoAdmin = new System.Windows.Forms.Label();
            this.lblDemoManager = new System.Windows.Forms.Label();
            this.lblDemoUser = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.cardLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.pnlDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.Color.Lavender;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderRadius = 0;
            this.pnlMain.BorderThickness = 0;
            this.pnlMain.Controls.Add(this.cardLogin);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1902, 1032);
            this.pnlMain.TabIndex = 0;
            // 
            // cardLogin
            // 
            this.cardLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardLogin.BackgroundColor = System.Drawing.Color.White;
            this.cardLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardLogin.BackgroundImage")));
            this.cardLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardLogin.BorderColor = System.Drawing.Color.Silver;
            this.cardLogin.BorderRadius = 30;
            this.cardLogin.BorderThickness = 1;
            this.cardLogin.Controls.Add(this.bunifuPictureBox1);
            this.cardLogin.Controls.Add(this.lblPasswordLabel);
            this.cardLogin.Controls.Add(this.lblEmailLabel);
            this.cardLogin.Controls.Add(this.lblTitle);
            this.cardLogin.Controls.Add(this.lblSubtitle);
            this.cardLogin.Controls.Add(this.txtEmail);
            this.cardLogin.Controls.Add(this.txtPassword);
            this.cardLogin.Controls.Add(this.btnSignIn);
            this.cardLogin.Controls.Add(this.lnkForgotPassword);
            this.cardLogin.Controls.Add(this.pnlDemo);
            this.cardLogin.Controls.Add(this.lblVersion);
            this.cardLogin.Location = new System.Drawing.Point(666, 174);
            this.cardLogin.Name = "cardLogin";
            this.cardLogin.ShowBorders = true;
            this.cardLogin.Size = new System.Drawing.Size(584, 685);
            this.cardLogin.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 63;
            this.bunifuPictureBox1.Image = global::ERP_System.Properties.Resources.Logo;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(223, 17);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(126, 126);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 8;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblPasswordLabel
            // 
            this.lblPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblPasswordLabel.Location = new System.Drawing.Point(72, 323);
            this.lblPasswordLabel.Name = "lblPasswordLabel";
            this.lblPasswordLabel.Size = new System.Drawing.Size(122, 25);
            this.lblPasswordLabel.TabIndex = 7;
            this.lblPasswordLabel.Text = "Password:";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblEmailLabel.Location = new System.Drawing.Point(70, 223);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(152, 25);
            this.lblEmailLabel.TabIndex = 6;
            this.lblEmailLabel.Text = "Email Address:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(142, 146);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enterprise ERP System";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.lblSubtitle.Location = new System.Drawing.Point(172, 190);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(293, 43);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Sign in to access your account";
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.AutoSizeHeight = true;
            this.txtEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 9;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(68, 251);
            this.txtEmail.MaxLength = 256;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties1.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties1.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties3.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties4;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(170)))));
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(448, 59);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 10;
            this.txtEmail.TextMarginTop = 0;
            this.txtEmail.TextPlaceholder = "Email Address";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.AutoSizeHeight = true;
            this.txtPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 9;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(68, 351);
            this.txtPassword.MaxLength = 256;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties5.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties7.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties8;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(165)))), ((int)(((byte)(170)))));
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(448, 59);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 10;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WordWrap = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AllowAnimations = true;
            this.btnSignIn.AllowMouseEffects = true;
            this.btnSignIn.AllowToggling = false;
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignIn.AnimationSpeed = 200;
            this.btnSignIn.AutoGenerateColors = false;
            this.btnSignIn.AutoRoundBorders = false;
            this.btnSignIn.AutoSizeLeftIcon = true;
            this.btnSignIn.AutoSizeRightIcon = true;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.ButtonText = "Sign In";
            this.btnSignIn.ButtonTextMarginLeft = 0;
            this.btnSignIn.ColorContrastOnClick = 45;
            this.btnSignIn.ColorContrastOnHover = 45;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSignIn.CustomizableEdges = borderEdges1;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignIn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnSignIn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnSignIn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IconLeft = null;
            this.btnSignIn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSignIn.IconMarginLeft = 11;
            this.btnSignIn.IconPadding = 10;
            this.btnSignIn.IconRight = null;
            this.btnSignIn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSignIn.IconSize = 25;
            this.btnSignIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSignIn.IdleBorderRadius = 8;
            this.btnSignIn.IdleBorderThickness = 1;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSignIn.IdleIconLeftImage = null;
            this.btnSignIn.IdleIconRightImage = null;
            this.btnSignIn.IndicateFocus = false;
            this.btnSignIn.Location = new System.Drawing.Point(61, 459);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignIn.OnDisabledState.BorderRadius = 15;
            this.btnSignIn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnDisabledState.BorderThickness = 1;
            this.btnSignIn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignIn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignIn.OnDisabledState.IconLeftImage = null;
            this.btnSignIn.OnDisabledState.IconRightImage = null;
            this.btnSignIn.onHoverState.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.onHoverState.BorderRadius = 15;
            this.btnSignIn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.onHoverState.BorderThickness = 1;
            this.btnSignIn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSignIn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.onHoverState.IconLeftImage = null;
            this.btnSignIn.onHoverState.IconRightImage = null;
            this.btnSignIn.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.OnIdleState.BorderRadius = 15;
            this.btnSignIn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnIdleState.BorderThickness = 1;
            this.btnSignIn.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnSignIn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnIdleState.IconLeftImage = null;
            this.btnSignIn.OnIdleState.IconRightImage = null;
            this.btnSignIn.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.OnPressedState.BorderRadius = 15;
            this.btnSignIn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignIn.OnPressedState.BorderThickness = 1;
            this.btnSignIn.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnSignIn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnPressedState.IconLeftImage = null;
            this.btnSignIn.OnPressedState.IconRightImage = null;
            this.btnSignIn.Size = new System.Drawing.Size(448, 44);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.TextMarginLeft = 0;
            this.btnSignIn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSignIn.UseDefaultRadiusAndThickness = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lnkForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lnkForgotPassword.Location = new System.Drawing.Point(209, 422);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(242, 25);
            this.lnkForgotPassword.TabIndex = 3;
            this.lnkForgotPassword.Text = "Forgot Password?";
            // 
            // pnlDemo
            // 
            this.pnlDemo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlDemo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDemo.BackgroundImage")));
            this.pnlDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDemo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.pnlDemo.BorderRadius = 20;
            this.pnlDemo.BorderThickness = 2;
            this.pnlDemo.Controls.Add(this.lblDemoTitle);
            this.pnlDemo.Controls.Add(this.lblDemoAdmin);
            this.pnlDemo.Controls.Add(this.lblDemoManager);
            this.pnlDemo.Controls.Add(this.lblDemoUser);
            this.pnlDemo.Location = new System.Drawing.Point(61, 511);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.ShowBorders = true;
            this.pnlDemo.Size = new System.Drawing.Size(457, 110);
            this.pnlDemo.TabIndex = 4;
            // 
            // lblDemoTitle
            // 
            this.lblDemoTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDemoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDemoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.lblDemoTitle.Location = new System.Drawing.Point(12, 15);
            this.lblDemoTitle.Name = "lblDemoTitle";
            this.lblDemoTitle.Size = new System.Drawing.Size(140, 21);
            this.lblDemoTitle.TabIndex = 0;
            this.lblDemoTitle.Text = "Demo Credentials:";
            // 
            // lblDemoAdmin
            // 
            this.lblDemoAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblDemoAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDemoAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblDemoAdmin.Location = new System.Drawing.Point(12, 36);
            this.lblDemoAdmin.Name = "lblDemoAdmin";
            this.lblDemoAdmin.Size = new System.Drawing.Size(294, 21);
            this.lblDemoAdmin.TabIndex = 1;
            this.lblDemoAdmin.Text = "Admin: admin@company.com  /  admin123";
            // 
            // lblDemoManager
            // 
            this.lblDemoManager.BackColor = System.Drawing.Color.Transparent;
            this.lblDemoManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDemoManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblDemoManager.Location = new System.Drawing.Point(12, 57);
            this.lblDemoManager.Name = "lblDemoManager";
            this.lblDemoManager.Size = new System.Drawing.Size(346, 21);
            this.lblDemoManager.TabIndex = 2;
            this.lblDemoManager.Text = "Manager: manager@company.com  /  manager123";
            // 
            // lblDemoUser
            // 
            this.lblDemoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblDemoUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDemoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(95)))), ((int)(((byte)(102)))));
            this.lblDemoUser.Location = new System.Drawing.Point(12, 76);
            this.lblDemoUser.Name = "lblDemoUser";
            this.lblDemoUser.Size = new System.Drawing.Size(252, 21);
            this.lblDemoUser.TabIndex = 3;
            this.lblDemoUser.Text = "User: user@company.com  /  user123";
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.lblVersion.Location = new System.Drawing.Point(71, 635);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(308, 19);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Demo: admin@company.com | Role: Administrator";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1902, 1032);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in - Enterprise ERP System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.cardLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.pnlDemo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel cardLogin;

        // Replaced labels
        private System.Windows.Forms.Label lblPasswordLabel;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignIn;

        private System.Windows.Forms.Label lnkForgotPassword;

        private Bunifu.UI.WinForms.BunifuPanel pnlDemo;

        private System.Windows.Forms.Label lblDemoTitle;
        private System.Windows.Forms.Label lblDemoAdmin;
        private System.Windows.Forms.Label lblDemoManager;
        private System.Windows.Forms.Label lblDemoUser;

        private System.Windows.Forms.Label lblVersion;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}