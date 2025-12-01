using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class SupplierProdViewForm : Form
    {
        public SupplierProdViewForm()
        {
            InitializeComponent();
        }
        public void SetSupplierDetails(SupplierDTO supplier, DataTable products)
        {
            if (supplier == null) return;

            lblSupName.Text = supplier.Name;
            lblSupContact.Text = $"Contact: {supplier.ContactName}";
            lblSupPhone.Text = $"Phone: {supplier.Phone}";
            lblSupEmail.Text = $"Email: {supplier.Email}";
            lblAddress.Text = $"Address: {supplier.Address}";

            // product count
            lblSupProductCount.Text = $"Products: {products?.Rows.Count ?? 0}";

            // bind product list to grid
            prodDgv.DataSource = products;
        }

        private void sepSupCard_Click(object sender, EventArgs e)
        {

        }
    }
}
