using ERP_System.BL;
using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class SupplierProductsCard : UserControl
    {
        public int SupplierId { get; private set; }
        private SupplierBL bl=new SupplierBL();
        public SupplierProductsCard()
        {
            InitializeComponent();
        }

        // Parameterized constructor
        public SupplierProductsCard(int supplierId, string supplierName, int productCount)
        {
            InitializeComponent();
            SupplierId = supplierId;
            supName.Text = supplierName;
            supProducts.Text = $"{productCount} products";
        }

        private void btnViewSupplier_Click(object sender, System.EventArgs e)
        {
            SupplierProdViewForm supplierProdViewForm = new SupplierProdViewForm();

            try
            {
                var dto = bl.GetSupplier(SupplierId);
                ProductBL productBL = new ProductBL();
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
