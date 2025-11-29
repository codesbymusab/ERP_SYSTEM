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
    public partial class LoginForm : Form
    {
        MainPageForm mainPageForm = new MainPageForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            mainPageForm.Show();
            this.Hide();
        }
    }
}
