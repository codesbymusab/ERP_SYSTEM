namespace ERP_System.GUI.Components
{
    partial class SupplierDetailsCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierDetailsCard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.cardSupplierTemplate = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnViewProducts = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.sepSupCard = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupContact = new System.Windows.Forms.Label();
            this.lblSupEmail = new System.Windows.Forms.Label();
            this.lblSupPhone = new System.Windows.Forms.Label();
            this.lblSupProductCount = new System.Windows.Forms.Label();
            this.cardSupplierTemplate.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardSupplierTemplate
            // 
            this.cardSupplierTemplate.BackgroundColor = System.Drawing.Color.White;
            this.cardSupplierTemplate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cardSupplierTemplate.BackgroundImage")));
            this.cardSupplierTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cardSupplierTemplate.BorderColor = System.Drawing.Color.LightGray;
            this.cardSupplierTemplate.BorderRadius = 20;
            this.cardSupplierTemplate.BorderThickness = 1;
            this.cardSupplierTemplate.Controls.Add(this.lblAddress);
            this.cardSupplierTemplate.Controls.Add(this.btnViewProducts);
            this.cardSupplierTemplate.Controls.Add(this.sepSupCard);
            this.cardSupplierTemplate.Controls.Add(this.lblSupName);
            this.cardSupplierTemplate.Controls.Add(this.lblSupContact);
            this.cardSupplierTemplate.Controls.Add(this.lblSupEmail);
            this.cardSupplierTemplate.Controls.Add(this.lblSupPhone);
            this.cardSupplierTemplate.Controls.Add(this.lblSupProductCount);
            this.cardSupplierTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSupplierTemplate.Location = new System.Drawing.Point(0, 0);
            this.cardSupplierTemplate.Margin = new System.Windows.Forms.Padding(25);
            this.cardSupplierTemplate.Name = "cardSupplierTemplate";
            this.cardSupplierTemplate.Padding = new System.Windows.Forms.Padding(20);
            this.cardSupplierTemplate.ShowBorders = true;
            this.cardSupplierTemplate.Size = new System.Drawing.Size(438, 397);
            this.cardSupplierTemplate.TabIndex = 4;
            this.cardSupplierTemplate.Click += new System.EventHandler(this.cardSupplierTemplate_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(26, 188);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(301, 30);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address: Lahore";
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.AllowAnimations = true;
            this.btnViewProducts.AllowMouseEffects = true;
            this.btnViewProducts.AllowToggling = false;
            this.btnViewProducts.AnimationSpeed = 200;
            this.btnViewProducts.AutoGenerateColors = false;
            this.btnViewProducts.AutoRoundBorders = false;
            this.btnViewProducts.AutoSizeLeftIcon = true;
            this.btnViewProducts.AutoSizeRightIcon = true;
            this.btnViewProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnViewProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewProducts.BackgroundImage")));
            this.btnViewProducts.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.ButtonText = "View Products";
            this.btnViewProducts.ButtonTextMarginLeft = 0;
            this.btnViewProducts.ColorContrastOnClick = 45;
            this.btnViewProducts.ColorContrastOnHover = 45;
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnViewProducts.CustomizableEdges = borderEdges1;
            this.btnViewProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewProducts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewProducts.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnViewProducts.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnViewProducts.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnViewProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.IconLeft = null;
            this.btnViewProducts.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProducts.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewProducts.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnViewProducts.IconMarginLeft = 11;
            this.btnViewProducts.IconPadding = 10;
            this.btnViewProducts.IconRight = null;
            this.btnViewProducts.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewProducts.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnViewProducts.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnViewProducts.IconSize = 25;
            this.btnViewProducts.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnViewProducts.IdleBorderRadius = 0;
            this.btnViewProducts.IdleBorderThickness = 0;
            this.btnViewProducts.IdleFillColor = System.Drawing.Color.Empty;
            this.btnViewProducts.IdleIconLeftImage = null;
            this.btnViewProducts.IdleIconRightImage = null;
            this.btnViewProducts.IndicateFocus = false;
            this.btnViewProducts.Location = new System.Drawing.Point(23, 327);
            this.btnViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnViewProducts.OnDisabledState.BorderRadius = 20;
            this.btnViewProducts.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnDisabledState.BorderThickness = 1;
            this.btnViewProducts.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnViewProducts.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnViewProducts.OnDisabledState.IconLeftImage = null;
            this.btnViewProducts.OnDisabledState.IconRightImage = null;
            this.btnViewProducts.onHoverState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProducts.onHoverState.BorderRadius = 20;
            this.btnViewProducts.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.onHoverState.BorderThickness = 1;
            this.btnViewProducts.onHoverState.FillColor = System.Drawing.Color.Silver;
            this.btnViewProducts.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.onHoverState.IconLeftImage = null;
            this.btnViewProducts.onHoverState.IconRightImage = null;
            this.btnViewProducts.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.btnViewProducts.OnIdleState.BorderRadius = 20;
            this.btnViewProducts.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnIdleState.BorderThickness = 1;
            this.btnViewProducts.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnViewProducts.OnIdleState.IconLeftImage = null;
            this.btnViewProducts.OnIdleState.IconRightImage = null;
            this.btnViewProducts.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnViewProducts.OnPressedState.BorderRadius = 20;
            this.btnViewProducts.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnViewProducts.OnPressedState.BorderThickness = 1;
            this.btnViewProducts.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnViewProducts.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnViewProducts.OnPressedState.IconLeftImage = null;
            this.btnViewProducts.OnPressedState.IconRightImage = null;
            this.btnViewProducts.Size = new System.Drawing.Size(394, 41);
            this.btnViewProducts.TabIndex = 7;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewProducts.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnViewProducts.TextMarginLeft = 0;
            this.btnViewProducts.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnViewProducts.UseDefaultRadiusAndThickness = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // sepSupCard
            // 
            this.sepSupCard.BackColor = System.Drawing.Color.Transparent;
            this.sepSupCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sepSupCard.BackgroundImage")));
            this.sepSupCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sepSupCard.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.sepSupCard.LineColor = System.Drawing.Color.Silver;
            this.sepSupCard.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.sepSupCard.LineThickness = 1;
            this.sepSupCard.Location = new System.Drawing.Point(23, 250);
            this.sepSupCard.Margin = new System.Windows.Forms.Padding(5);
            this.sepSupCard.Name = "sepSupCard";
            this.sepSupCard.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sepSupCard.Size = new System.Drawing.Size(389, 17);
            this.sepSupCard.TabIndex = 6;
            // 
            // lblSupName
            // 
            this.lblSupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupName.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblSupName.Location = new System.Drawing.Point(23, 34);
            this.lblSupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupName.Size = new System.Drawing.Size(227, 30);
            this.lblSupName.TabIndex = 0;
            this.lblSupName.Text = "Lighting Solutions";
            // 
            // lblSupContact
            // 
            this.lblSupContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupContact.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupContact.ForeColor = System.Drawing.Color.Black;
            this.lblSupContact.Location = new System.Drawing.Point(26, 80);
            this.lblSupContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupContact.Name = "lblSupContact";
            this.lblSupContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupContact.Size = new System.Drawing.Size(225, 30);
            this.lblSupContact.TabIndex = 1;
            this.lblSupContact.Text = "Contact: Mike Davis";
            // 
            // lblSupEmail
            // 
            this.lblSupEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupEmail.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupEmail.Location = new System.Drawing.Point(26, 154);
            this.lblSupEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupEmail.Name = "lblSupEmail";
            this.lblSupEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupEmail.Size = new System.Drawing.Size(301, 30);
            this.lblSupEmail.TabIndex = 2;
            this.lblSupEmail.Text = "Email: sales@lightingsol.com";
            // 
            // lblSupPhone
            // 
            this.lblSupPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupPhone.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupPhone.Location = new System.Drawing.Point(26, 116);
            this.lblSupPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupPhone.Name = "lblSupPhone";
            this.lblSupPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupPhone.Size = new System.Drawing.Size(287, 30);
            this.lblSupPhone.TabIndex = 3;
            this.lblSupPhone.Text = "Phone: +1 (555) 200-2003";
            // 
            // lblSupProductCount
            // 
            this.lblSupProductCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupProductCount.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupProductCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupProductCount.Location = new System.Drawing.Point(23, 274);
            this.lblSupProductCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupProductCount.Name = "lblSupProductCount";
            this.lblSupProductCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupProductCount.Size = new System.Drawing.Size(161, 30);
            this.lblSupProductCount.TabIndex = 4;
            this.lblSupProductCount.Text = "Products: 10";
            // 
            // SupplierDetailsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cardSupplierTemplate);
            this.Name = "SupplierDetailsCard";
            this.Size = new System.Drawing.Size(438, 397);
            this.cardSupplierTemplate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel cardSupplierTemplate;
        private Bunifu.UI.WinForms.BunifuSeparator sepSupCard;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupContact;
        private System.Windows.Forms.Label lblSupEmail;
        private System.Windows.Forms.Label lblSupPhone;
        private System.Windows.Forms.Label lblSupProductCount;
        private System.Windows.Forms.Label lblAddress;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnViewProducts;
    }
}
