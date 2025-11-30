namespace ERP_System.GUI.Pages
{
    partial class ProfilePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilePage));
            this.pnlMain = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlContent = new Bunifu.UI.WinForms.BunifuPanel();
            this.tabProfile = new TradeWright.UI.Forms.TabControlExtra();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tabPassword = new System.Windows.Forms.TabPage();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.lblCurrentPass = new System.Windows.Forms.Label();
            this.tabSession = new System.Windows.Forms.TabPage();
            this.lblSessionStartVal = new System.Windows.Forms.Label();
            this.lblIPVal = new System.Windows.Forms.Label();
            this.lblLastLoginVal = new System.Windows.Forms.Label();
            this.lblSessionStart = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblLastLogin = new System.Windows.Forms.Label();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.pnlHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.tabPassword.SuspendLayout();
            this.tabSession.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.BorderColor = System.Drawing.Color.LightGray;
            this.pnlMain.BorderRadius = 20;
            this.pnlMain.BorderThickness = 1;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShowBorders = true;
            this.pnlMain.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.TabIndex = 11;
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundColor = System.Drawing.Color.White;
            this.pnlContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContent.BackgroundImage")));
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContent.BorderColor = System.Drawing.Color.White;
            this.pnlContent.BorderRadius = 20;
            this.pnlContent.BorderThickness = 1;
            this.pnlContent.Controls.Add(this.tabProfile);
            this.pnlContent.Controls.Add(this.lblMyProfile);
            this.pnlContent.Location = new System.Drawing.Point(40, 110);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShowBorders = true;
            this.pnlContent.Size = new System.Drawing.Size(1460, 600);
            this.pnlContent.TabIndex = 32;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.tabPersonal);
            this.tabProfile.Controls.Add(this.tabPassword);
            this.tabProfile.Controls.Add(this.tabSession);
            this.tabProfile.DisplayStyle = TradeWright.UI.Forms.TabStyle.Rounded;
            // 
            // 
            // 
            this.tabProfile.DisplayStyleProvider.BlendStyle = TradeWright.UI.Forms.BlendStyle.Normal;
            this.tabProfile.DisplayStyleProvider.BorderColorDisabled = System.Drawing.SystemColors.ControlLight;
            this.tabProfile.DisplayStyleProvider.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabProfile.DisplayStyleProvider.BorderColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.BorderColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.BorderColorUnselected = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorFocused = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorFocusedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorHighlighted = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorSelected = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorSelectedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonFillColorUnselected = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorFocused = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorFocusedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorHighlighted = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorHighlightedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorSelected = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorSelectedActive = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserButtonOutlineColorUnselected = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.CloserColorFocused = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorFocusedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorHighlighted = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorHighlightedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorSelected = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorSelectedActive = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.CloserColorUnselected = System.Drawing.Color.Empty;
            this.tabProfile.DisplayStyleProvider.FocusTrack = false;
            this.tabProfile.DisplayStyleProvider.HotTrack = true;
            this.tabProfile.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabProfile.DisplayStyleProvider.Opacity = 1F;
            this.tabProfile.DisplayStyleProvider.Overlap = 0;
            this.tabProfile.DisplayStyleProvider.Padding = new System.Drawing.Point(6, 3);
            this.tabProfile.DisplayStyleProvider.PageBackgroundColorDisabled = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.PageBackgroundColorFocused = System.Drawing.SystemColors.ControlLight;
            this.tabProfile.DisplayStyleProvider.PageBackgroundColorHighlighted = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabProfile.DisplayStyleProvider.PageBackgroundColorSelected = System.Drawing.SystemColors.ControlLightLight;
            this.tabProfile.DisplayStyleProvider.PageBackgroundColorUnselected = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.Radius = 10;
            this.tabProfile.DisplayStyleProvider.SelectedTabIsLarger = false;
            this.tabProfile.DisplayStyleProvider.ShowTabCloser = false;
            this.tabProfile.DisplayStyleProvider.TabColorDisabled1 = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.TabColorDisabled2 = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.TabColorFocused1 = System.Drawing.SystemColors.ControlLight;
            this.tabProfile.DisplayStyleProvider.TabColorFocused2 = System.Drawing.SystemColors.ControlLight;
            this.tabProfile.DisplayStyleProvider.TabColorHighLighted1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.tabProfile.DisplayStyleProvider.TabColorHighLighted2 = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.tabProfile.DisplayStyleProvider.TabColorSelected1 = System.Drawing.SystemColors.ControlLightLight;
            this.tabProfile.DisplayStyleProvider.TabColorSelected2 = System.Drawing.SystemColors.ControlLightLight;
            this.tabProfile.DisplayStyleProvider.TabColorUnSelected1 = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.TabColorUnSelected2 = System.Drawing.SystemColors.Control;
            this.tabProfile.DisplayStyleProvider.TabPageMargin = new System.Windows.Forms.Padding(1);
            this.tabProfile.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabProfile.DisplayStyleProvider.TextColorFocused = System.Drawing.SystemColors.ControlText;
            this.tabProfile.DisplayStyleProvider.TextColorHighlighted = System.Drawing.SystemColors.ControlText;
            this.tabProfile.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabProfile.DisplayStyleProvider.TextColorUnselected = System.Drawing.SystemColors.ControlText;
            this.tabProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfile.HotTrack = true;
            this.tabProfile.Location = new System.Drawing.Point(20, 80);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.SelectedIndex = 0;
            this.tabProfile.Size = new System.Drawing.Size(1420, 500);
            this.tabProfile.TabIndex = 17;
            // 
            // tabPersonal
            // 
            this.tabPersonal.BackColor = System.Drawing.Color.White;
            this.tabPersonal.Controls.Add(this.btnUpdateProfile);
            this.tabPersonal.Controls.Add(this.txtPhone);
            this.tabPersonal.Controls.Add(this.lblPhone);
            this.tabPersonal.Controls.Add(this.txtEmail);
            this.tabPersonal.Controls.Add(this.lblEmail);
            this.tabPersonal.Controls.Add(this.txtRole);
            this.tabPersonal.Controls.Add(this.lblRole);
            this.tabPersonal.Controls.Add(this.txtFullName);
            this.tabPersonal.Controls.Add(this.lblFullName);
            this.tabPersonal.Location = new System.Drawing.Point(4, 30);
            this.tabPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Size = new System.Drawing.Size(1412, 466);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "Personal Information";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(48)))));
            this.btnUpdateProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(20, 220);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(160, 45);
            this.btnUpdateProfile.TabIndex = 8;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(740, 155);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(640, 35);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "+1 (555) 000-0000";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(736, 125);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(59, 23);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(740, 65);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(640, 35);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "admin@company.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(736, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(20, 155);
            this.txtRole.Multiline = true;
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(640, 35);
            this.txtRole.TabIndex = 3;
            this.txtRole.Text = "Administrator";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(16, 125);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(44, 23);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(20, 65);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(640, 35);
            this.txtFullName.TabIndex = 1;
            this.txtFullName.Text = "Admin User";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(16, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 23);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // tabPassword
            // 
            this.tabPassword.BackColor = System.Drawing.Color.White;
            this.tabPassword.Controls.Add(this.btnChangePassword);
            this.tabPassword.Controls.Add(this.txtConfirmPass);
            this.tabPassword.Controls.Add(this.lblConfirmPass);
            this.tabPassword.Controls.Add(this.txtNewPass);
            this.tabPassword.Controls.Add(this.lblNewPass);
            this.tabPassword.Controls.Add(this.txtCurrentPass);
            this.tabPassword.Controls.Add(this.lblCurrentPass);
            this.tabPassword.Location = new System.Drawing.Point(4, 30);
            this.tabPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPassword.Name = "tabPassword";
            this.tabPassword.Size = new System.Drawing.Size(1412, 466);
            this.tabPassword.TabIndex = 1;
            this.tabPassword.Text = "Change Password";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(48)))));
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 310);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(180, 45);
            this.btnChangePassword.TabIndex = 6;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(20, 245);
            this.txtConfirmPass.Multiline = true;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(600, 35);
            this.txtConfirmPass.TabIndex = 5;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(16, 215);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(189, 23);
            this.lblConfirmPass.TabIndex = 4;
            this.lblConfirmPass.Text = "Confirm New Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(20, 155);
            this.txtNewPass.Multiline = true;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(600, 35);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(16, 125);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(122, 23);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "New Password";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(20, 65);
            this.txtCurrentPass.Multiline = true;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(600, 35);
            this.txtCurrentPass.TabIndex = 1;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // lblCurrentPass
            // 
            this.lblCurrentPass.AutoSize = true;
            this.lblCurrentPass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPass.Location = new System.Drawing.Point(16, 35);
            this.lblCurrentPass.Name = "lblCurrentPass";
            this.lblCurrentPass.Size = new System.Drawing.Size(145, 23);
            this.lblCurrentPass.TabIndex = 0;
            this.lblCurrentPass.Text = "Current Password";
            // 
            // tabSession
            // 
            this.tabSession.BackColor = System.Drawing.Color.White;
            this.tabSession.Controls.Add(this.lblSessionStartVal);
            this.tabSession.Controls.Add(this.lblIPVal);
            this.tabSession.Controls.Add(this.lblLastLoginVal);
            this.tabSession.Controls.Add(this.lblSessionStart);
            this.tabSession.Controls.Add(this.lblIP);
            this.tabSession.Controls.Add(this.lblLastLogin);
            this.tabSession.Location = new System.Drawing.Point(4, 30);
            this.tabSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSession.Name = "tabSession";
            this.tabSession.Size = new System.Drawing.Size(1412, 466);
            this.tabSession.TabIndex = 2;
            this.tabSession.Text = "Session Info";
            // 
            // lblSessionStartVal
            // 
            this.lblSessionStartVal.AutoSize = true;
            this.lblSessionStartVal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionStartVal.ForeColor = System.Drawing.Color.Black;
            this.lblSessionStartVal.Location = new System.Drawing.Point(1296, 140);
            this.lblSessionStartVal.Name = "lblSessionStartVal";
            this.lblSessionStartVal.Size = new System.Drawing.Size(80, 25);
            this.lblSessionStartVal.TabIndex = 5;
            this.lblSessionStartVal.Text = "11:26:10";
            this.lblSessionStartVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIPVal
            // 
            this.lblIPVal.AutoSize = true;
            this.lblIPVal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPVal.ForeColor = System.Drawing.Color.Black;
            this.lblIPVal.Location = new System.Drawing.Point(1250, 90);
            this.lblIPVal.Name = "lblIPVal";
            this.lblIPVal.Size = new System.Drawing.Size(124, 25);
            this.lblIPVal.TabIndex = 4;
            this.lblIPVal.Text = "192.168.1.100";
            this.lblIPVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastLoginVal
            // 
            this.lblLastLoginVal.AutoSize = true;
            this.lblLastLoginVal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLoginVal.ForeColor = System.Drawing.Color.Black;
            this.lblLastLoginVal.Location = new System.Drawing.Point(1158, 40);
            this.lblLastLoginVal.Name = "lblLastLoginVal";
            this.lblLastLoginVal.Size = new System.Drawing.Size(216, 25);
            this.lblLastLoginVal.TabIndex = 3;
            this.lblLastLoginVal.Text = "11/30/2025, 11:26:10 AM";
            this.lblLastLoginVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSessionStart
            // 
            this.lblSessionStart.AutoSize = true;
            this.lblSessionStart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionStart.ForeColor = System.Drawing.Color.Gray;
            this.lblSessionStart.Location = new System.Drawing.Point(20, 140);
            this.lblSessionStart.Name = "lblSessionStart";
            this.lblSessionStart.Size = new System.Drawing.Size(150, 25);
            this.lblSessionStart.TabIndex = 2;
            this.lblSessionStart.Text = "Session Duration:";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.Color.Gray;
            this.lblIP.Location = new System.Drawing.Point(20, 90);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(101, 25);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP Address:";
            // 
            // lblLastLogin
            // 
            this.lblLastLogin.AutoSize = true;
            this.lblLastLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastLogin.ForeColor = System.Drawing.Color.Gray;
            this.lblLastLogin.Location = new System.Drawing.Point(20, 40);
            this.lblLastLogin.Name = "lblLastLogin";
            this.lblLastLogin.Size = new System.Drawing.Size(96, 25);
            this.lblLastLogin.TabIndex = 0;
            this.lblLastLogin.Text = "Last Login:";
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.AutoSize = true;
            this.lblMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblMyProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 13.824F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMyProfile.Location = new System.Drawing.Point(20, 30);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(125, 32);
            this.lblMyProfile.TabIndex = 14;
            this.lblMyProfile.Text = "My Profile";
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
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShowBorders = true;
            this.pnlHeader.Size = new System.Drawing.Size(1540, 79);
            this.pnlHeader.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(1222, 23);
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
            this.lblPageTitle.Size = new System.Drawing.Size(136, 32);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "User Profile";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfilePage";
            this.Size = new System.Drawing.Size(1540, 846);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.tabPersonal.PerformLayout();
            this.tabPassword.ResumeLayout(false);
            this.tabPassword.PerformLayout();
            this.tabSession.ResumeLayout(false);
            this.tabSession.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlMain;
        private Bunifu.UI.WinForms.BunifuPanel pnlHeader;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPageTitle;
        private Bunifu.UI.WinForms.BunifuPanel pnlContent;
        private TradeWright.UI.Forms.TabControlExtra tabProfile;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TabPage tabPassword;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Label lblCurrentPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TabPage tabSession;
        private System.Windows.Forms.Label lblLastLogin;
        private System.Windows.Forms.Label lblSessionStartVal;
        private System.Windows.Forms.Label lblIPVal;
        private System.Windows.Forms.Label lblLastLoginVal;
        private System.Windows.Forms.Label lblSessionStart;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblMyProfile;
    }
}