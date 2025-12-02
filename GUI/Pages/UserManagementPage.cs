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
    public partial class UserManagementPage : UserControl
    {
        public UserManagementPage()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
        }
    }
}
