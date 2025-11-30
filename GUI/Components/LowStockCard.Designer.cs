namespace ERP_System.GUI.Components
{
    partial class LowStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowStockCard));
            this.pnlLowStockItem = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblThres = new System.Windows.Forms.Label();
            this.lblCurrStk = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.itmCode = new System.Windows.Forms.Label();
            this.itmName = new System.Windows.Forms.Label();
            this.pnlLowStockItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLowStockItem
            // 
            this.pnlLowStockItem.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlLowStockItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLowStockItem.BackgroundImage")));
            this.pnlLowStockItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLowStockItem.BorderColor = System.Drawing.Color.LightGray;
            this.pnlLowStockItem.BorderRadius = 20;
            this.pnlLowStockItem.BorderThickness = 2;
            this.pnlLowStockItem.Controls.Add(this.lblThres);
            this.pnlLowStockItem.Controls.Add(this.lblCurrStk);
            this.pnlLowStockItem.Controls.Add(this.label43);
            this.pnlLowStockItem.Controls.Add(this.label44);
            this.pnlLowStockItem.Controls.Add(this.itmCode);
            this.pnlLowStockItem.Controls.Add(this.itmName);
            this.pnlLowStockItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStockItem.Location = new System.Drawing.Point(0, 0);
            this.pnlLowStockItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLowStockItem.Name = "pnlLowStockItem";
            this.pnlLowStockItem.ShowBorders = true;
            this.pnlLowStockItem.Size = new System.Drawing.Size(1375, 98);
            this.pnlLowStockItem.TabIndex = 16;
            // 
            // lblThres
            // 
            this.lblThres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThres.AutoSize = true;
            this.lblThres.Font = new System.Drawing.Font("Segoe UI Semibold", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblThres.Location = new System.Drawing.Point(1193, 41);
            this.lblThres.Name = "lblThres";
            this.lblThres.Size = new System.Drawing.Size(158, 23);
            this.lblThres.TabIndex = 5;
            this.lblThres.Text = "Reorder at: 15 units";
            // 
            // lblCurrStk
            // 
            this.lblCurrStk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrStk.AutoSize = true;
            this.lblCurrStk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrStk.Location = new System.Drawing.Point(1206, 16);
            this.lblCurrStk.Name = "lblCurrStk";
            this.lblCurrStk.Size = new System.Drawing.Size(145, 25);
            this.lblCurrStk.TabIndex = 4;
            this.lblCurrStk.Text = "Current: 8 units";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label43.Location = new System.Drawing.Point(1469, 59);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(119, 16);
            this.label43.TabIndex = 3;
            this.label43.Text = "Reorder At 20 units";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(1499, 20);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(92, 16);
            this.label44.TabIndex = 2;
            this.label44.Text = "Current: 8 units";
            // 
            // itmCode
            // 
            this.itmCode.AutoSize = true;
            this.itmCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itmCode.Location = new System.Drawing.Point(47, 43);
            this.itmCode.Name = "itmCode";
            this.itmCode.Size = new System.Drawing.Size(84, 21);
            this.itmCode.TabIndex = 1;
            this.itmCode.Text = "FURN-045";
            // 
            // itmName
            // 
            this.itmName.AutoSize = true;
            this.itmName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itmName.Location = new System.Drawing.Point(46, 17);
            this.itmName.Name = "itmName";
            this.itmName.Size = new System.Drawing.Size(213, 25);
            this.itmName.TabIndex = 0;
            this.itmName.Text = "Office Chair-Ergonomic";
            // 
            // LowStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.pnlLowStockItem);
            this.Name = "LowStockCard";
            this.Size = new System.Drawing.Size(1375, 98);
            this.pnlLowStockItem.ResumeLayout(false);
            this.pnlLowStockItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel pnlLowStockItem;
        public System.Windows.Forms.Label lblThres;
        public System.Windows.Forms.Label lblCurrStk;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label label44;
        public System.Windows.Forms.Label itmCode;
        public System.Windows.Forms.Label itmName;
    }
}
