using ERP_System.GUI.Components;
using ERP_System.GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class SuppliersPage : UserControl
    {   
        AddSuppplierForm addForm=new AddSuppplierForm();
        public SuppliersPage()
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            SupplierDetailsCard.LoadSupplierCards(this.flowSupplierCards);
            addForm.FormClosing += Refresh_Suppliers;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            addForm.ShowDialog();
        }

        private void Refresh_Suppliers(object sender, EventArgs e)
        {   
            SupplierDetailsCard.LoadSupplierCards(this.flowSupplierCards);

        }


    }
}
