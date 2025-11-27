using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class ActivityLogDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT al.id, al.action_type, al.entity_type, al.entity_id,
                                    al.details, al.created_at, u.name AS user_name
                             FROM activity_logs al
                             LEFT JOIN users u ON al.user_id = u.id
                             ORDER BY al.created_at DESC";
                new SqlDataAdapter(q, db.Con).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public int Add(ActivityLogDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO activity_logs(user_id,action_type,entity_type,entity_id,details)
                             VALUES(@u,@a,@et,@eid,@d); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@u", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@a", dto.ActionType);
                cmd.Parameters.AddWithValue("@et", string.IsNullOrWhiteSpace(dto.EntityType) ? (object)DBNull.Value : dto.EntityType);
                cmd.Parameters.AddWithValue("@eid", string.IsNullOrWhiteSpace(dto.EntityId) ? (object)DBNull.Value : dto.EntityId);
                cmd.Parameters.AddWithValue("@d", string.IsNullOrWhiteSpace(dto.Details) ? (object)DBNull.Value : dto.Details);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }
    }
}