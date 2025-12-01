namespace ERP_System.GUI.Components
{
    partial class SupplierProdViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierProdViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupContact = new System.Windows.Forms.Label();
            this.lblSupEmail = new System.Windows.Forms.Label();
            this.lblSupPhone = new System.Windows.Forms.Label();
            this.lblSupProductCount = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.prodDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.sepSupCard = new Bunifu.UI.WinForms.BunifuSeparator();
            this.lblAddress = new System.Windows.Forms.Label();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSupName
            // 
            this.lblSupName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupName.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblSupName.Location = new System.Drawing.Point(399, 20);
            this.lblSupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupName.Size = new System.Drawing.Size(227, 30);
            this.lblSupName.TabIndex = 7;
            this.lblSupName.Text = "Lighting Solutions";
            // 
            // lblSupContact
            // 
            this.lblSupContact.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupContact.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupContact.ForeColor = System.Drawing.Color.Black;
            this.lblSupContact.Location = new System.Drawing.Point(15, 66);
            this.lblSupContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupContact.Name = "lblSupContact";
            this.lblSupContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupContact.Size = new System.Drawing.Size(225, 30);
            this.lblSupContact.TabIndex = 8;
            this.lblSupContact.Text = "Contact: Mike Davis";
            // 
            // lblSupEmail
            // 
            this.lblSupEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupEmail.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupEmail.Location = new System.Drawing.Point(15, 140);
            this.lblSupEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupEmail.Name = "lblSupEmail";
            this.lblSupEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupEmail.Size = new System.Drawing.Size(301, 30);
            this.lblSupEmail.TabIndex = 9;
            this.lblSupEmail.Text = "Email: sales@lightingsol.com";
            // 
            // lblSupPhone
            // 
            this.lblSupPhone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupPhone.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupPhone.Location = new System.Drawing.Point(15, 102);
            this.lblSupPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupPhone.Name = "lblSupPhone";
            this.lblSupPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupPhone.Size = new System.Drawing.Size(287, 30);
            this.lblSupPhone.TabIndex = 10;
            this.lblSupPhone.Text = "Phone: +1 (555) 200-2003";
            // 
            // lblSupProductCount
            // 
            this.lblSupProductCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSupProductCount.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupProductCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSupProductCount.Location = new System.Drawing.Point(14, 248);
            this.lblSupProductCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSupProductCount.Name = "lblSupProductCount";
            this.lblSupProductCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSupProductCount.Size = new System.Drawing.Size(161, 30);
            this.lblSupProductCount.TabIndex = 11;
            this.lblSupProductCount.Text = "Products: 10";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.prodDgv);
            this.bunifuPanel1.Location = new System.Drawing.Point(19, 283);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(933, 302);
            this.bunifuPanel1.TabIndex = 14;
            // 
            // prodDgv
            // 
            this.prodDgv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.prodDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prodDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodDgv.BackgroundColor = System.Drawing.Color.White;
            this.prodDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prodDgv.ColumnHeadersHeight = 40;
            this.prodDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.prodDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.prodDgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.prodDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.prodDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.prodDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.prodDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.prodDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.prodDgv.CurrentTheme.Name = null;
            this.prodDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.prodDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.prodDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.prodDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.prodDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.prodDgv.EnableHeadersVisualStyles = false;
            this.prodDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.prodDgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.prodDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.prodDgv.HeaderForeColor = System.Drawing.Color.White;
            this.prodDgv.Location = new System.Drawing.Point(24, 26);
            this.prodDgv.Name = "prodDgv";
            this.prodDgv.RowHeadersVisible = false;
            this.prodDgv.RowHeadersWidth = 53;
            this.prodDgv.RowTemplate.Height = 40;
            this.prodDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDgv.Size = new System.Drawing.Size(886, 249);
            this.prodDgv.TabIndex = 14;
            this.prodDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
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
            this.sepSupCard.Location = new System.Drawing.Point(14, 224);
            this.sepSupCard.Margin = new System.Windows.Forms.Padding(5);
            this.sepSupCard.Name = "sepSupCard";
            this.sepSupCard.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sepSupCard.Size = new System.Drawing.Size(938, 17);
            this.sepSupCard.TabIndex = 12;
            this.sepSupCard.Click += new System.EventHandler(this.sepSupCard_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress.Location = new System.Drawing.Point(15, 187);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(301, 30);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Lahore";
            // 
            // SupplierProdViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 611);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.sepSupCard);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.lblSupContact);
            this.Controls.Add(this.lblSupEmail);
            this.Controls.Add(this.lblSupPhone);
            this.Controls.Add(this.lblSupProductCount);
            this.Name = "SupplierProdViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SupplierProdViewForm";
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuSeparator sepSupCard;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupContact;
        private System.Windows.Forms.Label lblSupEmail;
        private System.Windows.Forms.Label lblSupPhone;
        private System.Windows.Forms.Label lblSupProductCount;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView prodDgv;
        private System.Windows.Forms.Label lblAddress;
    }
}