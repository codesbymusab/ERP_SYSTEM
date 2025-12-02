using System;
using System.Data;
using System.Windows.Forms;
using ERP_System.BL;

namespace ERP_System.GUI.Pages
{
    public partial class ProductForm : BaseAccessControlForm
    {
        private readonly ProductBL productBL = new ProductBL(); // assume you have this BL

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvProducts;

        public ProductForm() : base("Products")
        {
            InitializeComponent();
            LoadProducts();
        }

        private void InitializeComponent()
        {
            Text = "Product Management";
            Size = new System.Drawing.Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;

            btnAdd = new Button
            {
                Text = "Add",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(90, 30)
            };
            btnAdd.Click += BtnAdd_Click;

            btnEdit = new Button
            {
                Text = "Edit",
                Location = new System.Drawing.Point(110, 10),
                Size = new System.Drawing.Size(90, 30)
            };
            btnEdit.Click += BtnEdit_Click;

            btnDelete = new Button
            {
                Text = "Delete",
                Location = new System.Drawing.Point(210, 10),
                Size = new System.Drawing.Size(90, 30)
            };
            btnDelete.Click += BtnDelete_Click;

            dgvProducts = new DataGridView
            {
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(760, 480),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AutoGenerateColumns = true
            };

            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dgvProducts);

            SetButtonPermissions(); // apply access
        }

        protected override void SetButtonPermissions()
        {
            btnAdd.Visible = HasAddPermission();
            btnEdit.Visible = HasEditPermission();
            btnDelete.Visible = HasDeletePermission();
        }

        private void LoadProducts()
        {
            try
            {
                DataTable dt = productBL.GetAllProducts(); // assume this method exists
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Open add product dialog
            // var addForm = new AddEditProductForm();
            // addForm.ShowDialog();
            // LoadProducts();
            MessageBox.Show("Add product logic here.");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["id"].Value);

            // var editForm = new AddEditProductForm(id);
            // editForm.ShowDialog();
            // LoadProducts();
            MessageBox.Show($"Edit product ID {id} logic here.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["id"].Value);

            if (MessageBox.Show("Delete this product?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    productBL.DeleteProduct(id);
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Delete failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}