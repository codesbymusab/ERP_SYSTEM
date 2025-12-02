using ERP_System.BL;
using ERP_System.DTO;
using ERP_System.GUI.Components;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ERP_System.GUI.Pages
{
    public partial class EmployeesPage : UserControl
    {
        private readonly EmployeeBL bl = new EmployeeBL();
        private readonly AttendanceBL a_bl = new AttendanceBL();
        private AddEditEmpForm _addeditForm=new AddEditEmpForm();

        public EmployeesPage()
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            WireEvents();
        }

      
       

        
        private void WireEvents()
        {



                _addeditForm.FormClosing += AddEditEmpForm_FormClosing;
                this.txtSearch.TextChanged += TxtSearch_TextChanged;

           
                this.btnAddEmployee.Click += BtnAddEmployee_Click;

           
                this.dgvEmployees.CellDoubleClick += DgvEmployees_CellDoubleClick;
                this.dgvEmployees.KeyDown += DgvEmployees_KeyDown;
                // context menu for delete
                var cms = new ContextMenuStrip();
                cms.Items.Add("Edit").Click += (s, e) => EditSelected();
                cms.Items.Add("Delete").Click += (s, e) => DeleteSelected();
                this.dgvEmployees.ContextMenuStrip = cms;
            
        }

        private void AddEditEmpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshGrid();
        }

        private void EmployeesPage_Load(object sender, EventArgs e)
        {
            this.lblTotal.Text = bl.GetTotalCount().ToString();
            this.lblActive.Text = bl.GetActiveEmployeesCount().ToString();
            this.lblOnLeave.Text = bl.GetOnLeaveEmployeesCount.ToString();
            this.lblDept.Text = bl.GetDepartmentsCount().ToString();
            this.lblTotalEmp.Text = bl.GetTotalEmployeesCount().ToString();
            this.lblAbsent.Text = a_bl.GetAbsentCount().ToString();
            this.lblAttRate.Text = a_bl.GetAttendancePercentage().ToString();
            PopulateEmployeesDropdown();
            LoadAttendanceForDate(datePicker.Value);


            RefreshGrid();
           
         
        }
        private void RefreshGrid()
        {
            try
            {
                DataTable dt = bl.GetAllEmployees();
                BindGrid(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(DataTable dt)
        {
            dgvEmployees.SuspendLayout();
            dgvEmployees.DataSource = null;
            dgvEmployees.AutoGenerateColumns = true;
            dgvEmployees.DataSource = dt;
           
            if (dgvEmployees.Columns.Contains("user_id"))
                dgvEmployees.Columns["user_id"].Visible = false;
            if (dgvEmployees.Columns.Contains("id"))
            {
                dgvEmployees.Columns["id"].HeaderText = "ID";
                dgvEmployees.Columns["id"].Width = 60;
            }
            dgvEmployees.ResumeLayout();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string q = txtSearch.Text?.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(q))
                {
                    RefreshGrid();
                    return;
                }
                var dt = bl.SearchEmployees(q);
                BindGrid(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                _addeditForm.lblTitle.Text = "Add Employee";


                _addeditForm.btnAddEdit.Click -= _addeditForm.SaveEditedEmployee_Click;

                _addeditForm.btnAddEdit.Click +=_addeditForm.AddEmployee_Click;


                _addeditForm.ShowDialog();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSelected();
        }

        private void EditSelected()
        {
            if (dgvEmployees.CurrentRow == null) return;
            if (!int.TryParse(dgvEmployees.CurrentRow.Cells["id"].Value?.ToString(), out int id)) return;

            try
            {
                var dto = bl.GetEmployee(id);
                if (dto == null)
                {
                    MessageBox.Show("Employee not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    return;
                }


                _addeditForm.lblTitle.Text = "Edit Employee";
                _addeditForm.txtUserID.Text = dto.UserId.ToString();
                _addeditForm.txtName.Text = dto.Name;
                _addeditForm.txtDepartment.Text = dto.Department;
                _addeditForm.txtRoleTitle.Text = dto.RoleTitle;
                _addeditForm.txtSalary.Text = dto.Salary.ToString();
                _addeditForm.ddlStatus.Text = dto.Status;
                _addeditForm.btnAddEdit.Click += _addeditForm.AddEmployee_Click;

                _addeditForm.btnAddEdit.Click += _addeditForm.SaveEditedEmployee_Click;
              
                _addeditForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DgvEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelected();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                RefreshGrid();
                e.Handled = true;
            }
        }

        private void DeleteSelected()
        {
            if (dgvEmployees.CurrentRow == null) return;
            if (!int.TryParse(dgvEmployees.CurrentRow.Cells["id"].Value?.ToString(), out int id)) return;

            var name = dgvEmployees.CurrentRow.Cells["name"].Value?.ToString() ?? "this employee";
            var ok = MessageBox.Show($"Delete {name} (ID: {id})? This action cannot be undone.", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ok != DialogResult.Yes) return;

            try
            {
                bl.DeleteEmployee(id);
                MessageBox.Show("Employee deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      
        private void PopulateEmployeesDropdown()
        {
            try
            {
                DataTable dt = bl.GetAllEmployees(); 
                employeeDropdown.DataSource = dt;
                employeeDropdown.DisplayMember = "name";   
                employeeDropdown.ValueMember = "id";       
                employeeDropdown.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAttendanceForDate(DateTime? date = null)
        {
            try
            {
                DateTime d = date ?? DateTime.Today;
             
                
                attDgv.DataSource = a_bl.GetDateAttendance(datePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load attendance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetSelectedEmployeeId()
        {
            if (employeeDropdown.SelectedValue == null) return -1;
            if (employeeDropdown.SelectedValue is int id) return id;
            if (int.TryParse(employeeDropdown.SelectedValue.ToString(), out id)) return id;
            return -1;
        }

        private void btnChkIn_Click(object sender, EventArgs e)
        {
            int empId = GetSelectedEmployeeId();
            if (empId <= 0)
            {
                MessageBox.Show("Please select an employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime now = DateTime.Now;
            a_bl.CheckInEmployee(empId, now);   // BL wrapper
            MessageBox.Show($"Checked in {employeeDropdown.Text} at {now:g}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAttendanceForDate(now.Date);
        }

        private void btnChkOut_Click(object sender, EventArgs e)
        {
            int empId = GetSelectedEmployeeId();
            if (empId <= 0)
            {
                MessageBox.Show("Please select an employee.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime now = DateTime.Now;
            a_bl.CheckOutEmployee(empId, now);  // BL wrapper
            MessageBox.Show($"Checked out {employeeDropdown.Text} at {now:g}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAttendanceForDate(now.Date);
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceForDate(datePicker.Value);
        }
    }
}
