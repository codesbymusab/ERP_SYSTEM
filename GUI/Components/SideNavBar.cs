using System;
using System.Windows.Forms;
using ERP_System.BL;
using ERP_System.GUI.Forms;

namespace ERP_System.GUI
{
    public partial class SideNavBar : UserControl
    {
        private MainPageForm mainPageForm;
        private readonly UserBL userBL = new UserBL();
        private readonly LoginBL loginBL = new LoginBL();
        private bool isLoggingOut = false;

        public SideNavBar()
        {
            InitializeComponent();
            // Wire up logout button
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
        }

        public void SetMainPageForm(MainPageForm form)
        {
            mainPageForm = form;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Prevent multiple logout attempts
            if (isLoggingOut) return;

            try
            {
                // Confirm logout
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isLoggingOut = true;
                    btnLogout.Enabled = false;

                    // Store user info BEFORE ending session
                    int currentUserId = 0;
                    string currentUserName = "Unknown User";

                    if (userBL.IsLoggedIn() && UserBL.CurrentUser != null)
                    {
                        currentUserId = userBL.GetCurrentUserId();
                        currentUserName = UserBL.CurrentUser.Name;

                        // Log the logout activity
                        try
                        {
                            loginBL.LogActivity(
                                currentUserId,
                                "logout",
                                "users",
                                currentUserId.ToString(),
                                $"User {currentUserName} logged out");
                        }
                        catch
                        {
                            // Ignore logging errors
                        }
                    }

                    // End session
                    userBL.EndSession();

                    // SIMPLE SOLUTION: Restart the application
                    Application.Restart();
                    Environment.Exit(0);
                }
                else
                {
                    // User cancelled logout
                    isLoggingOut = false;
                }
            }
            catch (Exception ex)
            {
                isLoggingOut = false;
                btnLogout.Enabled = true;

                MessageBox.Show($"Error during logout: {ex.Message}",
                    "Logout Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}