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
        public DataTable GetAllByStatus(string status)
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"
                    SELECT s.id,
                           s.customer_name,
                           s.date,
                           s.total_amount,
                           s.status,
                           u.name AS created_by
                    FROM sales s
                    LEFT JOIN users u ON s.user_id = u.id
                    WHERE s.status = @status
                    ORDER BY s.date DESC";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@status", status ?? (object)DBNull.Value);
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                db.Con.Close();
            }
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

        public int GetTotalSalesCount(string status = "paid")
        {
            try
            {
                db.Con.Open();
                const string q = "SELECT COUNT(*) FROM sales WHERE status = @status";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

       
        public decimal GetTotalRevenue(string completedStatus = "paid")
        {
            try
            {
                db.Con.Open();
                const string q = @"SELECT SUM(CAST(total_amount AS DECIMAL(18,2))) 
                                   FROM sales 
                                   WHERE status = @status AND total_amount IS NOT NULL";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@status", completedStatus);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0m;
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

        public decimal GetTotalRevenue(DateTime? from, DateTime? to, string completedStatus = "paid")
        {
            try
            {
                db.Con.Open();
                var sb = new System.Text.StringBuilder();
                sb.Append("SELECT SUM(CAST(total_amount AS DECIMAL(18,2))) FROM sales WHERE status = @status AND total_amount IS NOT NULL");

                if (from.HasValue) sb.Append(" AND adjusted_at >= @from"); // or sale_date column name
                if (to.HasValue) sb.Append(" AND adjusted_at <= @to");

                using (var cmd = new SqlCommand(sb.ToString(), db.Con))
                {
                    cmd.Parameters.AddWithValue("@status", completedStatus);
                    if (from.HasValue) cmd.Parameters.AddWithValue("@from", from.Value);
                    if (to.HasValue) cmd.Parameters.AddWithValue("@to", to.Value);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value && result != null ? Convert.ToDecimal(result) : 0m;
                }
            }
            finally
            {
                db.Con.Close();
            }
        }
    }
}