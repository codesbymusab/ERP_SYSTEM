using System;
using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class UserBL
    {
        private readonly UserDL dl = new UserDL();

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
    }
}