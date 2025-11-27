using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class UserDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                new SqlDataAdapter("SELECT id,name,email,role,created_at FROM users ORDER BY name", db.Con).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public UserDTO GetById(int id)
        {
            UserDTO u = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM users WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", id);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    u = new UserDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        Name = r.GetString(r.GetOrdinal("name")),
                        Email = r.GetString(r.GetOrdinal("email")),
                        PasswordHash = r.GetString(r.GetOrdinal("password_hash")),
                        Role = r.GetString(r.GetOrdinal("role"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return u;
        }

        public int Add(UserDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO users(name,email,password_hash,role)
                             VALUES(@n,@e,@p,@r); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@e", dto.Email);
                cmd.Parameters.AddWithValue("@p", dto.PasswordHash);
                cmd.Parameters.AddWithValue("@r", dto.Role);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }

        public void Update(UserDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE users
                             SET name=@n, email=@e, password_hash=@p, role=@r,
                                 updated_at=SYSUTCDATETIME()
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@e", dto.Email);
                cmd.Parameters.AddWithValue("@p", dto.PasswordHash);
                cmd.Parameters.AddWithValue("@r", dto.Role);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Delete(int id)
        {
            try
            {
                db.Con.Open();
                new SqlCommand("DELETE FROM users WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public UserDTO Login(string email, string hash)
        {
            UserDTO u = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM users WHERE email=@e AND password_hash=@p";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@p", hash);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    u = new UserDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        Name = r.GetString(r.GetOrdinal("name")),
                        Email = r.GetString(r.GetOrdinal("email")),
                        Role = r.GetString(r.GetOrdinal("role"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return u;
        }
    }
}