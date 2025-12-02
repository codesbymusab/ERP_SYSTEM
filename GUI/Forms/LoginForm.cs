using System;
using System.Windows.Forms;
using ERP_System.BL;
using ERP_System.DTO;

namespace ERP_System.GUI.Forms
{
    public partial class LoginForm : Form
    {
        private MainPageForm mainPageForm = new MainPageForm();
        private readonly LoginBL loginBL = new LoginBL();
        private readonly UserBL userBL = new UserBL();

        public LoginForm()
        {
            InitializeComponent();
            // Set Enter key to trigger login
            this.AcceptButton = btnSignIn;

            // Wire up Forgot Password link (if it exists in designer)
            if (this.lnkForgotPassword != null)
            {
                this.lnkForgotPassword.Click += new System.EventHandler(this.lnkForgotPassword_Click);
                this.lnkForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                // Validate inputs
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter your email address.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter your password.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                // Validate email format
                if (!loginBL.ValidateEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Disable button to prevent multiple clicks
                btnSignIn.Enabled = false;
                btnSignIn.Text = "Signing in...";
                this.Cursor = Cursors.WaitCursor;

                // Authenticate user
                UserDTO user = loginBL.AuthenticateUser(email, password);

                if (user != null)
                {
                    // Start session using UserBL
                    userBL.StartSession(user);

                    // Show success message
                    MessageBox.Show($"Welcome back, {user.Name}!",
                        "Login Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Open main form
                    GmailEmailService emailService = new GmailEmailService();
                    mainPageForm.Show();
                    this.Hide();
                }
                else
                {
                    // Authentication failed
                    MessageBox.Show("Invalid email or password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    // Clear password field
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login:\n{ex.Message}",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable button
                btnSignIn.Enabled = true;
                btnSignIn.Text = "Sign In";
                this.Cursor = Cursors.Default;
            }
        }

        private void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                ForgetPasswordForm forgotPasswordForm = new ForgetPasswordForm();
                forgotPasswordForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Forgot Password form: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}