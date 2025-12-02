using ERP_System.BL;
using ERP_System.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class StockAdjustmentPage : UserControl
    {
        private readonly ProductBL _productBL;
        private readonly AuditBL _auditBL;
        private readonly UserBL _userBL;

        public StockAdjustmentPage()
        {
            InitializeComponent();

            _productBL = new ProductBL();
            _auditBL = new AuditBL();
            _userBL=new UserBL();
          
            btnApplyAdjustment.Click += BtnApplyAdjustment_Click;

            this.lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            LoadProductsDropdown();
            LoadAuditLogGrid();
        }

        private void LoadProductsDropdown()
        {
            try
            {
                var dt = _productBL.GetAllProducts();
                ddlProduct.DataSource = dt;
                ddlProduct.DisplayMember = "name";
                ddlProduct.ValueMember = "id";
                ddlProduct.Text = "Choose Product";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAuditLogGrid()
        {
            try
            {
                dgvAuditLog.DataSource = _auditBL.GetAllAuditLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load audit log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApplyAdjustment_Click(object sender, EventArgs e)
        {
            try
            {
                if (ddlProduct.SelectedValue == null || !int.TryParse(ddlProduct.SelectedValue.ToString(), out int productId))
                {
                    MessageBox.Show("Please select a product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string type = ddlType.Text?.Trim().ToLower(); 
                if (string.IsNullOrWhiteSpace(type))
                {
                    MessageBox.Show("Please select adjustment type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQty.Text.Trim(), out int qty) || qty < 0)
                {
                    MessageBox.Show("Enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var product = _productBL.GetProduct(productId);
                if (product == null)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int previousStock = product.Stock;
                int newStock = previousStock;

                switch (type)
                {
                    
                    case "add stock":
                        newStock = previousStock + qty;
                        break;
                 
                    case "remove stock":
                        newStock = Math.Max(0, previousStock - qty);
                        break;
                  
                    default:
                        MessageBox.Show("Unknown adjustment type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                
                product.Stock = newStock;
                _productBL.UpdateProduct(product);

                try {

                    var user = _userBL.GetCurrentUser();


                    var audit = new AuditLogDTO
                    {
                        ProductId = product.Id,
                        ProductName = product.Name,
                        AdjustmentType = type,
                        Quantity = qty,
                        Reason = ddlReason.Text,
                        Notes = txtNotes.Text,
                        AdjustedBy = user.Name,
                        AdjustedAt = DateTime.Now,
                        PreviousStock = previousStock,
                        NewStock = newStock
                    };

                _auditBL.AddAuditLog(audit);

                MessageBox.Show($"Stock updated: {previousStock} → {newStock}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Failed to Validate User.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LoadProductsDropdown();
                LoadAuditLogGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adjustment failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
