using ERP_System.DTO;
using ERP_System.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class SupplierDetailsCard : UserControl
    {
        public int SupplierId { get; private set; }
        private SupplierBL bl=new SupplierBL();
        
        public SupplierDetailsCard()
        {
            InitializeComponent();
        }

      
        public SupplierDetailsCard(int supplierId, string address,string name, string contact, string phone, string email, int productCount)
        {
            InitializeComponent();
            SupplierId = supplierId;
            lblSupName.Text = name;
            lblSupContact.Text = $"Contact: {contact}";
            lblSupPhone.Text = $"Phone: {phone}";
            lblSupEmail.Text = $"Email: {email}";
            label1.Text= $"Address: {address}";
            lblSupProductCount.Text = $"Products: {productCount}";
        }

        public SupplierDetailsCard(SupplierDTO dto, int productCount)
        {
            InitializeComponent();
            SupplierId = dto.Id;
            lblSupName.Text = dto.Name;
            lblSupContact.Text = $"Contact: {dto.ContactName}";
            lblSupPhone.Text = $"Phone: {dto.Phone}";
            lblSupEmail.Text = $"Email: {dto.Email}";
            label1.Text = $"Address: {dto.Address}";
            lblSupProductCount.Text = $"Products: {productCount}";
        }

      
        public static void LoadSupplierCards(FlowLayoutPanel panel)
        {
            var bl = new SupplierBL();
            var dt = bl.GetAllSuppliers();

            panel.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string name = row["name"].ToString();
                string contact = row["contact_name"]?.ToString();
                string phone = row["phone"]?.ToString();
                string email = row["email"]?.ToString();
                string address = row["address"]?.ToString();

                int productCount = bl.GetSupplierProductCount(id);

                var card = new SupplierDetailsCard(id, address,name, contact, phone, email, productCount);
            
                panel.Controls.Add(card);

                //// Optional: wire up the "View Products" button
                //card.Controls["btnViewProducts"].Click += (s, e) =>
                //{
                //    MessageBox.Show($"Supplier {name} has {productCount} products.", "Info");
                //    // Or open a detailed supplier products page
                //};
            }
        }

        private void cardSupplierTemplate_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            SupplierProdViewForm supplierProdViewForm = new SupplierProdViewForm();
           
            try
            {
                var dto = bl.GetSupplier(SupplierId);
                ProductBL productBL=new ProductBL();
                var st = productBL.SearchProducts(SupplierId.ToString());
                supplierProdViewForm.SetSupplierDetails(dto, st);
                supplierProdViewForm.ShowDialog();
                

            }
            catch
            {
                MessageBox.Show("Failed to Load Products");
            }


        }
    }
}
