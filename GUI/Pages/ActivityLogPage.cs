using ERP_System.BL;
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
    public partial class ActivityLogPage : UserControl
    {
        ActivityLogBL _actBL;
        public ActivityLogPage()
        {   
            _actBL = new ActivityLogBL();
            InitializeComponent();
        
        }

        private void LoadActivityLog()
        {
            try
            {
                this.activtylogDgv.DataSource = _actBL.GetAllLogs();
            }
            catch
            {
                MessageBox.Show("Failed to Load Activity Log","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ActivityLogPage_Enter(object sender, EventArgs e)
        {
            LoadActivityLog();
        }
    }

    
}
