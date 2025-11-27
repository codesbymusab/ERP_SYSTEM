using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class PurchaseDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT ph.id, ph.date, ph.total_amount, ph.notes,
                                    s.name AS supplier_name, u.name AS created_by
                             FROM purchases ph
                             JOIN suppliers s ON ph.supplier_id = s.id
                             LEFT JOIN users u ON ph.user_id = u.id
                             ORDER BY ph.date DESC";
                new SqlDataAdapter(q, db.Con).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public PurchaseDTO GetById(int id)
        {
            PurchaseDTO p = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM purchases WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", id);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    p = new PurchaseDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        SupplierId = r.GetInt32(r.GetOrdinal("supplier_id")),
                        UserId = r.IsDBNull(r.GetOrdinal("user_id")) ? (int?)null : r.GetInt32(r.GetOrdinal("user_id")),
                        Date = r.GetDateTime(r.GetOrdinal("date")),
                        TotalAmount = r.GetDecimal(r.GetOrdinal("total_amount")),
                        Notes = r.IsDBNull(r.GetOrdinal("notes")) ? null : r.GetString(r.GetOrdinal("notes"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return p;
        }

        public int Add(PurchaseDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO purchases(supplier_id,user_id,date,total_amount,notes)
                             VALUES(@s,@u,@d,@t,@n); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@s", dto.SupplierId);
                cmd.Parameters.AddWithValue("@u", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@d", dto.Date);
                cmd.Parameters.AddWithValue("@t", dto.TotalAmount);
                cmd.Parameters.AddWithValue("@n", string.IsNullOrWhiteSpace(dto.Notes) ? (object)DBNull.Value : dto.Notes);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }

        public void Update(PurchaseDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE purchases
                             SET supplier_id=@s, user_id=@u, date=@d,
                                 total_amount=@t, notes=@n, updated_at=SYSUTCDATETIME()
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@s", dto.SupplierId);
                cmd.Parameters.AddWithValue("@u", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@d", dto.Date);
                cmd.Parameters.AddWithValue("@t", dto.TotalAmount);
                cmd.Parameters.AddWithValue("@n", string.IsNullOrWhiteSpace(dto.Notes) ? (object)DBNull.Value : dto.Notes);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Delete(int id)
        {
            try
            {
                db.Con.Open();
                new SqlCommand("DELETE FROM purchases WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}