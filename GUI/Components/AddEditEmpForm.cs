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
using TheArtOfDev.HtmlRenderer.Adapters;

namespace ERP_System.GUI.Components
{
    public partial class AddEditEmpForm : Form
    {
        private UserBL _userBL;
        private EmployeeBL _employeeBL;
        public AddEditEmpForm()
        {
            _userBL = new UserBL();
            _employeeBL = new EmployeeBL();
            InitializeComponent();
        }


        private void SearchEmployee_Click(Object sender, EventArgs e)
        {
            try
            {
                int userId = 0;
                if (!int.TryParse(this.txtUserID.Text.Trim(), out userId))
                {
                    MessageBox.Show("Invalid User ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearForm();
                    return;
                }

                var userBL = new UserBL();
                var user = userBL.GetUser(userId);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearForm();
                    return;
                }

                // Fill name and role title from user
                txtName.Text = user.Name;
            }
            catch
            {

            }
        }
        public void AddEmployee_Click(Object sender, EventArgs e)
        {
            try
            {

                // Create DTO
                var dto = new EmployeeDTO
                {
                    UserId = Convert.ToInt32(txtUserID.Text.Trim()),
                    Name = txtName.Text.Trim(),
                    RoleTitle = txtRoleTitle.Text.Trim(),
                    Department = txtDepartment.Text.Trim(),
                    Salary = decimal.TryParse(txtSalary.Text.Trim(), out var s) ? s : (decimal?)null,
                    Status = ddlStatus.SelectedItem?.ToString() ?? "active"
                };


                int newId = _employeeBL.AddEmployee(dto);
                MessageBox.Show($"Employee added (ID: {newId})", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public void SaveEditedEmployee_Click(Object sender, EventArgs e)
        {
            try
            {
                var dto = new EmployeeDTO
                {
                   
                    UserId = int.TryParse(txtUserID.Text.Trim(), out var uid) ? uid : (int?)null,
                    Name = txtName.Text.Trim(),
                    RoleTitle = txtRoleTitle.Text.Trim(),
                    Department = txtDepartment.Text.Trim(),
                    Salary = decimal.TryParse(txtSalary.Text.Trim(), out var s) ? s : (decimal?)null,
                    Status = ddlStatus.SelectedItem?.ToString() ?? "active"
                };

                var bl = new EmployeeBL();
                bl.UpdateEmployee(dto);
                MessageBox.Show("Employee updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtRoleTitle.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
            ddlStatus.SelectedIndex = 0;
            btnAddEdit.Text = "Add Employee";

            // Reset event handlers
            btnAddEdit.Click -= SaveEditedEmployee_Click;
            btnAddEdit.Click += AddEmployee_Click;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {   
            ClearForm();
            this.Hide();
        }

       
    }
}
