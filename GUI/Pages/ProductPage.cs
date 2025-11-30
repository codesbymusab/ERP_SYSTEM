using ERP_System.BL;
using ERP_System.DTO;
using ERP_System.GUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class ProductPage : UserControl
    {
        private ProductBL _productBL=new ProductBL();
        private AddEditProdForm _addeditForm=new AddEditProdForm();
        public ProductPage()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {



            _addeditForm.FormClosing += AddEditProdForm_FormClosing;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;


            this.btnAddProduct.Click += BtnAddProduct_Click;


            this.dgvProducts.CellDoubleClick += DgvProducts_CellDoubleClick;
            this.dgvProducts.KeyDown += DgvProducts_KeyDown;
            // context menu for delete
            var cms = new ContextMenuStrip();
            cms.Items.Add("Edit").Click += (s, e) => EditSelected();
            cms.Items.Add("Delete").Click += (s, e) => DeleteSelected();
            this.dgvProducts.ContextMenuStrip = cms;

        }
        private void AddEditProdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGrid();
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            this.lblTotal.Text=_productBL.GetTotalProductCount().ToString();
            this.lblValue.Text=_productBL.GetTotalInventoryValue().ToString();
            this.lblLowStk.Text=_productBL.GetLowStockCount().ToString();
            this.lblOutofStck.Text=_productBL.GetOutOfStockCount().ToString();

            RefreshGrid();
            LoadLowStockCards();
            LoadSupplierCards();

            

        }

        private void LoadLowStockCards()
        {
            var dt = _productBL.GetLowStockProducts();

            // Convert DataTable to ProductDTO list
            var products = new List<ProductDTO>();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                products.Add(new ProductDTO
                {
                    Id = Convert.ToInt32(row["id"]),
                    SKU = row["sku"]?.ToString(),
                    Name = row["name"]?.ToString(),
                    Category = row["category"]?.ToString(),
                    Stock = Convert.ToInt32(row["stock"]),
                    PurchasePrice = row["purchase_price"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row["purchase_price"]),
                    SellingPrice = row["selling_price"] == DBNull.Value ? null : (decimal?)Convert.ToDecimal(row["selling_price"]),
                    SupplierId = row["supplier_id"] == DBNull.Value ? null : (int?)Convert.ToInt32(row["supplier_id"]),
                    LowStockThreshold = Convert.ToInt32(row["low_stock_threshold"])
                });
            }


            var cards = LowStockCard.CreateCardsFromProducts(products);


            flowLayoutPanel1.Controls.Clear();
            foreach (var card in cards)
            {

                flowLayoutPanel1.Controls.Add(card);
            }

        }
        private void LoadSupplierCards()
        {
            var bl = new SupplierBL();
            var dt = bl.GetAllSuppliers();

            flowLayoutPanel2.Controls.Clear();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                int count = bl.GetSupplierProductCount(id);

                var card = new SupplierProductsCard(id, name, count);
                
                flowLayoutPanel2.Controls.Add(card);

                // Optionally wire the button inside card
                //card.Controls["btnViewSupplier"].Click += (s, e) =>
                //{
                //    MessageBox.Show($"Supplier {name} has {count} products.", "Info");
                //    // Or open a detailed supplier products page
                //};
            }
        }

        private void RefreshGrid()
        {
            try
            {
                DataTable dt = _productBL.GetAllProducts();
                BindGrid(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(DataTable dt)
        {
            dgvProducts.SuspendLayout();
            dgvProducts.DataSource = null;
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.DataSource = dt;

          
            dgvProducts.ResumeLayout();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string q = txtSearch.Text?.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(q))
                {
                    RefreshGrid();
                    return;
                }
                var dt = _productBL.SearchProducts(q);
                BindGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _addeditForm.lblTitle.Text = "Add Product";


                _addeditForm.btnAddEdit.Click -= _addeditForm.SaveEditedProduct_Click;

                _addeditForm.btnAddEdit.Click += _addeditForm.AddProduct_Click;


                _addeditForm.ShowDialog();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSelected();
        }

        private void EditSelected()
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!int.TryParse(dgvProducts.CurrentRow.Cells["id"].Value?.ToString(), out int id)) return;

            try
            {
                var dto = _productBL.GetProduct(id);
                if (dto == null)
                {
                    MessageBox.Show("Product not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    return;
                }

                _addeditForm.LoadForEdit(dto.Id);
             
                _addeditForm.btnAddEdit.Click -= _addeditForm.AddProduct_Click;

                _addeditForm.btnAddEdit.Click += _addeditForm.SaveEditedProduct_Click;

                _addeditForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DgvProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelected();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                RefreshGrid();
                e.Handled = true;
            }
        }

        private void DeleteSelected()
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!int.TryParse(dgvProducts.CurrentRow.Cells["id"].Value?.ToString(), out int id)) return;

            var name = dgvProducts.CurrentRow.Cells["name"].Value?.ToString() ?? "this employee";
            var ok = MessageBox.Show($"Delete {name} (ID: {id})? This action cannot be undone.", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ok != DialogResult.Yes) return;

            try
            {
                _productBL.DeleteProduct(id);
                MessageBox.Show("Employee deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
