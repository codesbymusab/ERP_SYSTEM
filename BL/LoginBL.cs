using System;
using System.Security.Cryptography;
using System.Text;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class LoginBL
    {
        private readonly LoginDL loginDL = new LoginDL();

        public UserDTO AuthenticateUser(string email, string password)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(email))
                throw new Exception("Email is required.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required.");

            // Hash the password
            string passwordHash = HashPassword(password);

            // Authenticate
            UserDTO user = loginDL.AuthenticateUser(email, passwordHash);

            if (user != null)
            {
                // Log the login activity
                loginDL.LogActivity(user.Id, "login", "users", user.Id.ToString(),
                    $"User {user.Name} logged in successfully");
            }

            return user;
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void LogActivity(int userId, string action, string entityType = null, string entityId = null, string details = null)
        {
            loginDL.LogActivity(userId, action, entityType, entityId, details);
        }
    }
}