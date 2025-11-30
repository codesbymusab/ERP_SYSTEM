using System;
using System.Data;
using System.Net;
using System.Net.Sockets;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class UserBL
    {
        private readonly UserDL dl = new UserDL();

        // Session Management Properties
        public static UserDTO CurrentUser { get; private set; }
        public static DateTime LoginTime { get; private set; }
        public static string IPAddress { get; private set; }
        public static DateTime LastLoginTime { get; private set; }

        // User Management Methods
        public DataTable GetAllUsers() => dl.GetAll();

        public UserDTO GetUser(int id) => dl.GetById(id);

        public int AddUser(UserDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.PasswordHash))
                throw new Exception("Email and password required.");
            if (new UserDL().Login(dto.Email, dto.PasswordHash) != null)
                throw new Exception("Email already registered.");
            return dl.Add(dto);
        }

        public void UpdateUser(UserDTO dto)
        {
            if (dto.Id <= 0)
                throw new Exception("Invalid user ID.");
            dl.Update(dto);
        }

        public void DeleteUser(int id) => dl.Delete(id);

        public UserDTO Authenticate(string email, string hash) => dl.Login(email, hash);

        // Session Management Methods
        public void StartSession(UserDTO user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null");

            CurrentUser = user;
            LoginTime = DateTime.Now;
            LastLoginTime = DateTime.Now;
            IPAddress = GetLocalIPAddress();
        }

        public void EndSession()
        {
            CurrentUser = null;
            LoginTime = DateTime.MinValue;
            IPAddress = null;
            LastLoginTime = DateTime.MinValue;
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public string GetLocalIPAddress()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPAddress[] addresses = Dns.GetHostAddresses(hostName);

                foreach (IPAddress address in addresses)
                {
                    if (address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        return address.ToString();
                    }
                }
                return "127.0.0.1";
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }

        public TimeSpan GetSessionDuration()
        {
            if (LoginTime == DateTime.MinValue)
                return TimeSpan.Zero;

            return DateTime.Now - LoginTime;
        }

        public string GetFormattedSessionDuration()
        {
            TimeSpan duration = GetSessionDuration();
            return $"{duration.Hours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";
        }

        // Get current user information
        public UserDTO GetCurrentUser()
        {
            return CurrentUser;
        }

        public string GetCurrentUserRole()
        {
            return CurrentUser?.Role ?? "Guest";
        }

        public int GetCurrentUserId()
        {
            return CurrentUser?.Id ?? 0;
        }
    }
}