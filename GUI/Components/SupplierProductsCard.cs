using System.Windows.Forms;

namespace ERP_System.GUI.Components
{
    public partial class SupplierProductsCard : UserControl
    {
        public int SupplierId { get; private set; }

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
    }
}
