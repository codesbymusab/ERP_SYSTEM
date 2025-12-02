using ERP_System.BL;
using ERP_System.DTO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class AddEditProdForm : Form
    {
        private readonly ProductBL _productBL;
        private readonly SupplierBL _supplierBL;
        private ProductDTO _editingProduct;

        public AddEditProdForm()
        {
            InitializeComponent();
            _productBL = new ProductBL();
            _supplierBL = new SupplierBL();

            // default button wiring
            btnAddEdit.Click += AddProduct_Click;
            bunifuButton1.Click += Cancel_Click;

           
        }

      
        private void SearchSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtSupID.Text.Trim(), out int supplierId) || supplierId <= 0)
                {
                    MessageBox.Show("Enter a valid Supplier ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                    return;
                }

                var supplier = _supplierBL.GetSupplier(supplierId);
                if (supplier == null)
                {
                    MessageBox.Show("Supplier not found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                    return;
                }

                txtSupName.Text = supplier.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Supplier lookup failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new product
        /// </summary>
        public void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var dto = ReadFormToDto();
                _productBL.AddProduct(dto);
                MessageBox.Show("Product added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Prepare form for editing an existing product
        /// </summary>
        public void LoadForEdit(int productId)
        {
            _editingProduct = _productBL.GetProduct(productId);
            if (_editingProduct == null)
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // populate fields
            txtSku.Text = _editingProduct.SKU;
            txtName.Text = _editingProduct.Name;
            txtCategory.Text = _editingProduct.Category;
            txtDesc.Text = _editingProduct.Description;
            txtStock.Text = _editingProduct.Stock.ToString();
            txtPurPrice.Text = _editingProduct.PurchasePrice?.ToString(CultureInfo.InvariantCulture) ?? "";
            txtSalePrice.Text = _editingProduct.SellingPrice?.ToString(CultureInfo.InvariantCulture) ?? "";
            txtThres.Text = _editingProduct.LowStockThreshold.ToString();
            if (_editingProduct.SupplierId.HasValue)
            {
                txtSupID.Text = _editingProduct.SupplierId.Value.ToString();
                var sup = _supplierBL.GetSupplier(_editingProduct.SupplierId.Value);
                txtSupName.Text = sup.Name;
            }
            else
            {
                txtSupID.Text = "";
              
            }

            // switch button to save mode
            btnAddEdit.Click -= AddProduct_Click;
            btnAddEdit.Click += SaveEditedProduct_Click;
            btnAddEdit.ButtonText = "Save Changes";
            lblTitle.Text = "Edit Product";
        }

        /// <summary>
        /// Save edited product
        /// </summary>
        public void SaveEditedProduct_Click(object sender, EventArgs e)
        {
            if (_editingProduct == null)
            {
                MessageBox.Show("No product loaded for editing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dto = ReadFormToDto();
                dto.Id = _editingProduct.Id;
                _productBL.UpdateProduct(dto);
                MessageBox.Show("Product updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // restore add wiring
                btnAddEdit.Click -= SaveEditedProduct_Click;
                btnAddEdit.Click += AddProduct_Click;
                btnAddEdit.ButtonText = "Add Product";
                lblTitle.Text = "Add Product";
                _editingProduct = null;
            }
        }

        private ProductDTO ReadFormToDto()
        {
            int.TryParse(txtStock.Text.Trim(), out int stock);
            int.TryParse(txtThres.Text.Trim(), out int low);
            int? supplierId = null;
            if (int.TryParse(txtSupID.Text.Trim(), out int sid) && sid > 0) supplierId = sid;

            decimal? pp = null, sp = null;
            if (decimal.TryParse(txtPurPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal p)) pp = p;
            if (decimal.TryParse(txtSalePrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal s)) sp = s;

            return new ProductDTO
            {
                SKU = string.IsNullOrWhiteSpace(txtSku.Text) ? null : txtSku.Text.Trim(),
                Name = txtName.Text.Trim(),
                Category = string.IsNullOrWhiteSpace(txtCategory.Text) ? null : txtCategory.Text.Trim(),
                Description = string.IsNullOrWhiteSpace(txtDesc.Text) ? null : txtDesc.Text.Trim(),
                Stock = stock,
                PurchasePrice = pp,
                SellingPrice = sp,
                SupplierId = supplierId,
                LowStockThreshold = low > 0 ? low : 5
            };
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
        }

        private void ClearForm()
        {
            txtSku.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            txtDesc.Text = "";
            txtStock.Text = "0";
            txtPurPrice.Text = "";
            txtSalePrice.Text = "";
            txtThres.Text = "5";
            txtSupID.Text = "";
            txtSupName.Text = "";

            btnAddEdit.ButtonText = "Add Product";
            lblTitle.Text = "Add Product";

            // reset event wiring
            btnAddEdit.Click -= SaveEditedProduct_Click;
            btnAddEdit.Click -= AddProduct_Click;
            btnAddEdit.Click += AddProduct_Click;
            _editingProduct = null;
        }
    }
}
