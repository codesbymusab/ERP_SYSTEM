using ERP_System.BL;
using ERP_System.GUI.Forms;
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
    public partial class PurchasesPage : UserControl
    {
        private readonly PurchaseBL _purchaseBL;
        private AddPurchaseOrderForm _form=new AddPurchaseOrderForm();
        public PurchasesPage()
        {   
            _purchaseBL= new PurchaseBL();
            InitializeComponent();
           
            this.ActiveControl = dgvPurchases;
          
        }

        private void LoadPurchasePage()
        {
            try
            {
                this.dgvPurchases.DataSource = _purchaseBL.GetAllPurchases();
            }
            catch
            {
                MessageBox.Show("Failed to Load Activity Log", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PurchasePage_Enter(object sender, EventArgs e)
        {
            LoadPurchasePage();
        }

        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            _form.ShowDialog();
            LoadPurchasePage();
        }
    }
}
