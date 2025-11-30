using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace ERP_System
{
    public partial class MainPageForm : Form
    {
        public MainPageForm()
        {
            InitializeComponent();

            // ADDED: Enable double buffering to reduce flickering
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                         ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Enable double buffering for bunifuPages if possible
            if (this.bunifuPages1 != null)
            {
                typeof(Control).GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance)
                    ?.SetValue(this.bunifuPages1, true, null);
            }

            // Set the reference to this form in the SideNavBar
            this.sideNavBar1.SetMainPageForm(this);

            // Attach event handlers for navigation
            this.sideNavBar1.btnDashboard.Click += dashboardBtn_Click;
            this.sideNavBar1.btnProd.Click += productsBtn_Click;
            this.sideNavBar1.btnEmp.Click += employBtn_Click;
            this.sideNavBar1.btnStkAdj.Click += stkAdjBtn_Click;
            this.sideNavBar1.btnSup.Click += suppliersBtn_Click;
            this.sideNavBar1.btnSales.Click += salesBtn_Click;
            this.sideNavBar1.btnPurchases.Click += purchasesBtn_Click;
            this.sideNavBar1.btnHistory.Click += historyBtn_Click;
            this.sideNavBar1.btnUserProfile.Click += profileBtn_Click;
        }

        private void ChangePage(int pageIndex)
        {
            this.SuspendLayout();
            try
            {
                this.bunifuPages1.PageIndex = pageIndex;
            }
            finally
            {
                this.ResumeLayout(false);
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ChangePage(0);
        }

        private void employBtn_Click(object sender, EventArgs e)
        {
            ChangePage(1);
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            ChangePage(2);
        }

        private void stkAdjBtn_Click(object sender, EventArgs e)
        {
            ChangePage(3);
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            ChangePage(4);
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            ChangePage(5);
        }

        private void purchasesBtn_Click(object sender, EventArgs e)
        {
            ChangePage(6);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            ChangePage(7);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            ChangePage(8);
        }

        private void EmployPage_Click(object sender, EventArgs e)
        {
            // Empty handler - can be removed if not used
        }

        private void sideNavBar1_Load(object sender, EventArgs e)
        {
            // Can be used for any initialization when sidebar loads
        }
    }
}