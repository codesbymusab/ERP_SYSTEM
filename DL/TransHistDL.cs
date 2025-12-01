// File: ERP_System.DL/TransactionDL.cs
using ERP_System.DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ERP_System.DL
{
    public class TransHistDL
    {
        private readonly DBConnection db = new DBConnection();

       
        public int AddTransaction(TransHistDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            try
            {
                db.Con.Open();
                const string q = @"
                    INSERT INTO dbo.transaction_history
                        (transaction_type, reference_id, amount, status,
                         performed_by, performed_by_name, performed_at, notes)
                    VALUES
                        (@transaction_type,@reference_id, @amount, @status,
                         @performed_by, @performed_by_name, @performed_at, @notes);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@transaction_type", dto.TransactionType ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@reference_id", dto.ReferenceId);
                    cmd.Parameters.AddWithValue("@amount", dto.Amount);
                    cmd.Parameters.AddWithValue("@status", dto.Status ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@performed_by", dto.PerformedBy.HasValue ? (object)dto.PerformedBy.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@performed_by_name", dto.PerformedByName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@performed_at", dto.PerformedAt);
                    cmd.Parameters.AddWithValue("@notes", dto.Notes ?? (object)DBNull.Value);
                   
                    object res = cmd.ExecuteScalar();
                    return res != null ? Convert.ToInt32(res) : 0;
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

        public DataTable GetAllTransactions()
        {
            var dt = new DataTable();
            try
            {
                db.Con.Open();
                const string q = @"
                    SELECT id, transaction_type,reference_id, amount, status,
                           performed_by, performed_by_name, performed_at, notes
                    FROM dbo.transaction_history
                    ORDER BY performed_at DESC";
                using (var cmd = new SqlCommand(q, db.Con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            finally
            {
                db.Con.Close();
            }
            return dt;
        }

      
        public DataTable GetTransactionsByType(string transactionType)
        {
            var dt = new DataTable();
            try
            {
                db.Con.Open();
                const string q = @"
                    SELECT id, transaction_type,reference_id, amount, status,
                           performed_by, performed_by_name, performed_at, notes
                    FROM dbo.transaction_history
                    WHERE transaction_type = @type
                    ORDER BY performed_at DESC";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@type", transactionType ?? (object)DBNull.Value);
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


    }
}
