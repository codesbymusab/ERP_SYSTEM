using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class SaleDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT s.id, s.customer_name, s.date, s.total_amount, s.status,
                                    u.name AS created_by
                             FROM sales s
                             LEFT JOIN users u ON s.user_id = u.id
                             ORDER BY s.date DESC";
                new SqlDataAdapter(q, db.Con).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public SaleDTO GetById(int id)
        {
            SaleDTO s = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM sales WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", id);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    s = new SaleDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        CustomerName = r.GetString(r.GetOrdinal("customer_name")),
                        UserId = r.IsDBNull(r.GetOrdinal("user_id")) ? (int?)null : r.GetInt32(r.GetOrdinal("user_id")),
                        Date = r.GetDateTime(r.GetOrdinal("date")),
                        TotalAmount = r.GetDecimal(r.GetOrdinal("total_amount")),
                        Status = r.GetString(r.GetOrdinal("status"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return s;
        }

        public int Add(SaleDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO sales(customer_name,user_id,date,total_amount,status)
                             VALUES(@c,@u,@d,@t,@s); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@c", dto.CustomerName);
                cmd.Parameters.AddWithValue("@u", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@d", dto.Date);
                cmd.Parameters.AddWithValue("@t", dto.TotalAmount);
                cmd.Parameters.AddWithValue("@s", dto.Status);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }

        public void Update(SaleDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE sales
                             SET customer_name=@c, user_id=@u, date=@d,
                                 total_amount=@t, status=@s, updated_at=SYSUTCDATETIME()
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@c", dto.CustomerName);
                cmd.Parameters.AddWithValue("@u", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@d", dto.Date);
                cmd.Parameters.AddWithValue("@t", dto.TotalAmount);
                cmd.Parameters.AddWithValue("@s", dto.Status);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Delete(int id)
        {
            try
            {
                db.Con.Open();
                new SqlCommand("DELETE FROM sales WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}