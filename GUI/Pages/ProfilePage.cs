using ERP_System.BL;
using ERP_System.DTO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ERP_System.GUI.Pages
{
    public partial class ProfilePage : UserControl
    {
        private readonly UserBL userBL = new UserBL();
        private readonly LoginBL loginBL = new LoginBL();
        private Timer sessionTimer;

        public ProfilePage()
        {
            InitializeComponent();
            LoadUserProfile();
            InitializeSessionTimer();
            this.lblDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            // Wire up event handlers
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
        }

        private void LoadUserProfile()
        {
            try
            {
                if (userBL.IsLoggedIn())
                {
                    UserDTO currentUser = UserBL.CurrentUser;

                    // Personal Information Tab
                    txtFullName.Text = currentUser.Name;
                    txtEmail.Text = currentUser.Email;
                    txtRole.Text = currentUser.Role;
                    txtPhone.Text = "+1 (555) 000-0000"; // Default placeholder

                    // Session Information Tab
                    lblLastLoginVal.Text = UserBL.LastLoginTime.ToString("MM/dd/yyyy, hh:mm:ss tt");
                    lblIPVal.Text = UserBL.IPAddress;
                    UpdateSessionTime();

                    // Update page header date
                    lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
                }
                else
                {
                    MessageBox.Show("No active session found. Please login again.",
                        "Session Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void InitializeSessionTimer()
        {
            sessionTimer = new Timer();
            sessionTimer.Interval = 1000; // Update every second
            sessionTimer.Tick += SessionTimer_Tick;
            sessionTimer.Start();
        }

        private void SessionTimer_Tick(object sender, EventArgs e)
        {
            UpdateSessionTime();
        }

        private void UpdateSessionTime()
        {
            if (userBL.IsLoggedIn())
            {
                lblSessionStartVal.Text = userBL.GetFormattedSessionDuration();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userBL.IsLoggedIn())
                {
                    MessageBox.Show("Please login to update your profile.",
                        "Authentication Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Name is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtFullName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Validate email format
                if (!loginBL.ValidateEmail(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Update user information
                UserDTO updatedUser = new UserDTO
                {
                    Id = UserBL.CurrentUser.Id,
                    Name = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PasswordHash = UserBL.CurrentUser.PasswordHash,
                    Role = UserBL.CurrentUser.Role
                };

                userBL.UpdateUser(updatedUser);

                // Update session - refresh current user data
                UserDTO refreshedUser = userBL.GetUser(UserBL.CurrentUser.Id);
                userBL.StartSession(refreshedUser);

                // Log activity
                loginBL.LogActivity(userBL.GetCurrentUserId(), "update", "users",
                    userBL.GetCurrentUserId().ToString(), "Profile updated");

                MessageBox.Show("Profile updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userBL.IsLoggedIn())
                {
                    MessageBox.Show("Please login to change your password.",
                        "Authentication Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtCurrentPass.Text))
                {
                    MessageBox.Show("Current password is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtCurrentPass.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNewPass.Text))
                {
                    MessageBox.Show("New password is required.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtNewPass.Focus();
                    return;
                }

                if (txtNewPass.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtNewPass.Focus();
                    return;
                }

                if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("New password and confirmation do not match.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtConfirmPass.Focus();
                    return;
                }

                // Verify current password
                string currentPassHash = loginBL.HashPassword(txtCurrentPass.Text);
                if (currentPassHash != UserBL.CurrentUser.PasswordHash)
                {
                    MessageBox.Show("Current password is incorrect.",
                        "Authentication Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtCurrentPass.Clear();
                    txtCurrentPass.Focus();
                    return;
                }

                // Update password
                string newPassHash = loginBL.HashPassword(txtNewPass.Text);
                UserDTO updatedUser = new UserDTO
                {
                    Id = UserBL.CurrentUser.Id,
                    Name = UserBL.CurrentUser.Name,
                    Email = UserBL.CurrentUser.Email,
                    PasswordHash = newPassHash,
                    Role = UserBL.CurrentUser.Role
                };

                userBL.UpdateUser(updatedUser);

                // Update session - refresh current user data
                UserDTO refreshedUser = userBL.GetUser(UserBL.CurrentUser.Id);
                userBL.StartSession(refreshedUser);

                // Log activity
                loginBL.LogActivity(userBL.GetCurrentUserId(), "update", "users",
                    userBL.GetCurrentUserId().ToString(), "Password changed");

                MessageBox.Show("Password changed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Clear password fields
                txtCurrentPass.Clear();
                txtNewPass.Clear();
                txtConfirmPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing password: {ex.Message}",
                    "Password Change Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}