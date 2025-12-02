using System;
using System.Windows.Forms;
using ERP_System.BL;

namespace ERP_System.GUI
{
    public partial class BaseAccessControlForm : Form
    {
        protected UserBL userBL = new UserBL();
        private readonly string moduleName;

        public BaseAccessControlForm(string moduleName)
        {
            this.moduleName = moduleName;
            CheckAccess();
        }

        private void CheckAccess()
        {
            if (!userBL.HasModuleAccess(moduleName))
            {
                MessageBox.Show("You don't have access to this module.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        protected virtual void SetButtonPermissions() { }

        protected bool HasAddPermission() => userBL.CanAdd(moduleName);
        protected bool HasEditPermission() => userBL.CanEdit(moduleName);
        protected bool HasDeletePermission() => userBL.CanDelete(moduleName);
    }
}