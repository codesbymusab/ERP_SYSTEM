using System;
using System.Windows.Forms;
using ERP_System.BL;
using ERP_System.DTO;

namespace ERP_System.GUI.Forms
{
    // FIX: This matches the class name in the designer file.
    public partial class ForgetPasswordForm : Form
    {
        private readonly UserBL userBL = new UserBL();
        private readonly LoginBL loginBL = new LoginBL();
        private UserDTO foundUser;

        public ForgetPasswordForm()
        {
            InitializeComponent();
        }

        private void btnVerifyEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();

                // Validate email
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter your email address.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (!loginBL.ValidateEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Find user by email
                foundUser = FindUserByEmail(email);

                if (foundUser != null)
                {
                    // Show password reset panel
                    pnlEmailVerification.Visible = false;
                    pnlPasswordReset.Visible = true;
                    lblUserName.Text = $"Reset password for: {foundUser.Name}";
                }
                else
                {
                    MessageBox.Show("No account found with this email address.",
                        "Email Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying email: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (foundUser == null)
                {
                    MessageBox.Show("Please verify your email first.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    MessageBox.Show("Please enter a new password.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }

                if (txtNewPassword.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtNewPassword.Focus();
                    return;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }

                // Hash the new password
                string newPasswordHash = loginBL.HashPassword(txtNewPassword.Text);

                // Update user password
                UserDTO updatedUser = new UserDTO
                {
                    Id = foundUser.Id,
                    Name = foundUser.Name,
                    Email = foundUser.Email,
                    PasswordHash = newPasswordHash,
                    Role = foundUser.Role
                };

                userBL.UpdateUser(updatedUser);

                // Log activity
                loginBL.LogActivity(foundUser.Id, "password_reset", "users",
                    foundUser.Id.ToString(), "Password reset via forgot password");

                MessageBox.Show("Password reset successful! You can now login with your new password.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting password: {ex.Message}",
                    "Reset Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPasswordReset.Visible = false;
            pnlEmailVerification.Visible = true;
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            foundUser = null;
        }

        private UserDTO FindUserByEmail(string email)
        {
            // Get all users and find by email
            var allUsers = userBL.GetAllUsers();
            foreach (System.Data.DataRow row in allUsers.Rows)
            {
                if (row["email"].ToString().Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return userBL.GetUser(Convert.ToInt32(row["id"]));
                }
            }
            return null;
        }
    }
}