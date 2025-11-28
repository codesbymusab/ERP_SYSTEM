using ERP_System.GUI.Administration;
using ERP_System.GUI.HR;
using ERP_System.GUI.Login;
using ERP_System.GUI.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeesForm());
        }
    }
}
