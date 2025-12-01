using ERP_System.BL;
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

namespace ERP_System.GUI.Forms
{   
    public partial class AddSuppplierForm : Form
    {   
        private SupplierBL bl=new SupplierBL();
        public AddSuppplierForm()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Build DTO from form fields
                var dto = new SupplierDTO
                {
                    Name = txtSName.Text.Trim(),
                    ContactName = txtName.Text.Trim(),  
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),             
                };

                
               
             bl.AddSupplier(dto);

                MessageBox.Show("Supplier added Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void ClearForm()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtSName.Text = "";
           

            btnAddEdit.Text = "Add Supplier";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
        }

      
    }
}
