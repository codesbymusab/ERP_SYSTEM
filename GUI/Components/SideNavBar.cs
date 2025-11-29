using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System.GUI
{
    public partial class SideNavBar : UserControl
    {
        private MainPageForm mainPageForm;

        public SideNavBar()
        {
            InitializeComponent();
        }
        public void SetMainPageForm(MainPageForm form)
        {
            mainPageForm = form;
        }
    }
}