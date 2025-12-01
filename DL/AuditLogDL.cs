using ERP_System.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ERP_System.DL
{
    public class AuditDL
    {
        private readonly DBConnection db = new DBConnection();

        public int AddAuditLog(AuditLogDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"
                    INSERT INTO audit_log
                        (product_id, product_name, adjustment_type, quantity, reason, notes,
                         adjusted_by, adjusted_at, previous_stock, new_stock)
                    VALUES
                        (@product_id, @product_name, @adjustment_type, @quantity, @reason, @notes,
                         @adjusted_by, @adjusted_at, @previous_stock, @new_stock);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@product_id", dto.ProductId);
                    cmd.Parameters.AddWithValue("@product_name", dto.ProductName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@adjustment_type", dto.AdjustmentType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@quantity", dto.Quantity);
                    cmd.Parameters.AddWithValue("@reason", string.IsNullOrWhiteSpace(dto.Reason) ? (object)DBNull.Value : dto.Reason);
                    cmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(dto.Notes) ? (object)DBNull.Value : dto.Notes);
                    cmd.Parameters.AddWithValue("@adjusted_by", dto.AdjustedBy ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@adjusted_at", dto.AdjustedAt);
                    cmd.Parameters.AddWithValue("@previous_stock", dto.PreviousStock);
                    cmd.Parameters.AddWithValue("@new_stock", dto.NewStock);

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

      
        public DataTable GetAllAuditLogs()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"
                    SELECT id, product_id, product_name, adjustment_type, quantity, reason, notes,
                           adjusted_by, adjusted_at, previous_stock, new_stock
                    FROM audit_log
                    ORDER BY adjusted_at DESC";
                new SqlDataAdapter(q, db.Con).Fill(dt);
            }
            finally
            {
                db.Con.Close();
            }
            return dt;
        }
    }
}
