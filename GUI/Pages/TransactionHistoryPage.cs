using ERP_System.BL;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class TransactionHistoryPage : UserControl
    {
        private readonly TransHistBL _txBl;

        public TransactionHistoryPage()
        {
            InitializeComponent();
            this.lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            _txBl = new TransHistBL();

            TransactionHistoryPage_Load();
        }

        private void TransactionHistoryPage_Load()
        {
            try
            {
                LoadAllTransactions();
                LoadSalesTransactions();
                LoadPurchaseTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load transaction history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void LoadAllTransactions()
        {
            DataTable dt = _txBl.GetAllTransactions();
            dgvAllTransactions.DataSource = dt;
            FormatGrid(dgvAllTransactions);
        }

        private void LoadSalesTransactions()
        {
            DataTable dt = _txBl.GetTransactionsByType("Sale");
            dgvSalesHistory.DataSource = dt;
            FormatGrid(dgvSalesHistory);
        }

        private void LoadPurchaseTransactions()
        {
            DataTable dt = _txBl.GetTransactionsByType("Purchase");
            dgvPurchaseHistory.DataSource = dt;
            FormatGrid(dgvPurchaseHistory);
        }

        private void FormatGrid(Bunifu.UI.WinForms.BunifuDataGridView grid)
        {
            if (grid?.DataSource is DataTable dt && dt.Columns.Count > 0)
            {
               
                if (grid.Columns.Contains("performed_at"))
                    grid.Columns["performed_at"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";

                if (grid.Columns.Contains("amount"))
                    grid.Columns["amount"].DefaultCellStyle.Format = "C2";

                
                if (grid.Columns.Contains("id"))
                    grid.Columns["id"].HeaderText = "Tx ID";

                
                if (grid.Columns.Contains("reference_id"))
                    grid.Columns["reference_id"].HeaderText = "Ref ID";
            }
        }

      
        
    }
}
