using System;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class LoginDL
    {
        private readonly DBConnection db = new DBConnection();

        public UserDTO AuthenticateUser(string email, string passwordHash)
        {
            UserDTO user = null;
            try
            {
                db.Con.Open();
                string query = @"SELECT id, name, email, password_hash, role, created_at 
                                FROM users 
                                WHERE email = @email AND password_hash = @pass";

                SqlCommand cmd = new SqlCommand(query, db.Con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", passwordHash);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    user = new UserDTO
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        PasswordHash = reader.GetString(reader.GetOrdinal("password_hash")),
                        Role = reader.GetString(reader.GetOrdinal("role"))
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Database error during authentication: " + ex.Message);
            }
            finally
            {
                db.Con.Close();
            }

            return user;
        }

        public bool LogActivity(int userId, string actionType, string entityType = null, string entityId = null, string details = null)
        {
            try
            {
                db.Con.Open();
                string query = @"INSERT INTO activity_logs (user_id, action_type, entity_type, entity_id, details, created_at)
                                VALUES (@uid, @action, @entity, @eid, @details, SYSUTCDATETIME())";

                SqlCommand cmd = new SqlCommand(query, db.Con);
                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@action", actionType);
                cmd.Parameters.AddWithValue("@entity", (object)entityType ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@eid", (object)entityId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@details", (object)details ?? DBNull.Value);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                db.Con.Close();
            }
        }
    }
}