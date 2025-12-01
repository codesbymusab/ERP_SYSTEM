using ERP_System.BL;
using ERP_System.DTO;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class SalesAddProductCard : UserControl
    {
        public event EventHandler RemoveRequested;
        public int ProductId { get; private set; }
        public decimal UnitPrice
        {
            get
            {
                if (decimal.TryParse(txtunitPrice.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out var v))
                    return v;
                return 0m;
            }
            set => txtunitPrice.Text = value.ToString(CultureInfo.InvariantCulture);
        }
        public int Quantity
        {
            get
            {
                if (int.TryParse(txtQty.Text.Trim(), out var q)) return q;
                return 0;
            }
            set => txtQty.Text = value.ToString();
        }
        public decimal LineTotal => UnitPrice * Quantity;

        public SalesAddProductCard()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            txtQty.TextChanged += InputChanged;
            txtunitPrice.TextChanged += InputChanged;
            txtProd.SelectedIndexChanged += TxtProd_SelectedIndexChanged;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            RemoveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void InputChanged(object sender, EventArgs e)
        {
            UpdateTotalLabel();
        }

        private void TxtProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If dropdown items are DataRowView with "id" and "selling_price" columns
            if (txtProd.SelectedItem is DataRowView drv)
            {
                if (drv.Row.Table.Columns.Contains("selling_price") && drv["selling_price"] != DBNull.Value)
                {
                    txtunitPrice.Text = Convert.ToDecimal(drv["selling_price"]).ToString(CultureInfo.InvariantCulture);
                }
                if (drv.Row.Table.Columns.Contains("id") && drv["id"] != DBNull.Value)
                {
                    ProductId = Convert.ToInt32(drv["id"]);
                }
            }
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            lblttl.Text = LineTotal.ToString("0.##");
        }

        
        public void InitializeProducts(DataTable products)
        {
            if (products == null) return;
            txtProd.DataSource = products;
            txtProd.DisplayMember = "name";
            txtProd.ValueMember = "id";
            txtProd.Text = "Select Product";
        }

       
        public (int productId, string productName, int qty, decimal unitPrice, decimal lineTotal) ToLineItem()
        {
            var name = txtProd.Text;
            return (ProductId, name, Quantity, UnitPrice, LineTotal);
        }
    }
}
