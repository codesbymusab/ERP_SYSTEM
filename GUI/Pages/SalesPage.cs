using ERP_System.BL;
using ERP_System.DL;
using ERP_System.GUI.Forms;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class SalesPage : UserControl
    {
        private readonly SaleBL _salesBL;
        private AddSaleForm _saleForm=new AddSaleForm();
        public SalesPage()
        {
            InitializeComponent();
            _salesBL = new SaleBL();

        
            ddlFilter.SelectedIndexChanged += DdlFilter_SelectedIndexChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnNewSale.Click += BtnNewSale_Click;
            SalesPage_Load();
           
        }

        private void SalesPage_Load()
        {
            try
            {
               

                RefreshSummary();
                dgvInvoices.DataSource = _salesBL.GetAllSales();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize sales page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void RefreshSummary()
        {
            try
            {
                this.ddlFilter.Text = "All";

                lblTotalSalesValue.Text = _salesBL.GetTotalSalesCount("paid").ToString(CultureInfo.InvariantCulture);
                lblDraftsValue.Text = _salesBL.GetTotalSalesCount("draft").ToString(CultureInfo.InvariantCulture);
                lblCancelledValue.Text = _salesBL.GetTotalSalesCount("cancelled").ToString(CultureInfo.InvariantCulture); 
               
                lblRevenueValue.Text = _salesBL.GetTotalRevenue().ToString("C2", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load sales summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void LoadInvoicesGrid(string status)
        {
            try
            {
                DataTable dt;
                if (string.IsNullOrWhiteSpace(status) || status.Equals("all", StringComparison.OrdinalIgnoreCase))
                {
                   
                    dt = _salesBL.GetAllSales();
                }
                else
                {
                    dt = _salesBL.GetAllSalesByStatus(status);
                }

                dgvInvoices.DataSource = dt;

                
                if (dgvInvoices.Columns.Contains("date"))
                {
                    dgvInvoices.Columns["date"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }
                if (dgvInvoices.Columns.Contains("total_amount"))
                {
                    dgvInvoices.Columns["total_amount"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load invoices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DdlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var status = ddlFilter.Text?.Trim().ToLower() ?? "all";
            LoadInvoicesGrid(status);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            
            try
            {   
                var dt = dgvInvoices.DataSource as DataTable;
                if (dt == null) return;

                var filter = txtSearch.Text.Trim().Replace("'", "''");
                if (string.IsNullOrEmpty(filter))
                {
                    dgvInvoices.DataSource = _salesBL.GetAllSales();
                    return;
                }

               
                string rowFilter = $"Convert(id, 'System.String') LIKE '%{filter}%' OR customer_name LIKE '%{filter}%'";
                var dv = dt.DefaultView;
                dv.RowFilter = rowFilter;
                dgvInvoices.DataSource = dv.ToTable();
            }
            catch
            {
                // ignore search errors silently
            }
        }

        private void BtnNewSale_Click(object sender, EventArgs e)
        {
            _saleForm.ShowDialog();
            SalesPage_Load();

        }

    }
}
