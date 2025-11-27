using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class AttendanceDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetByEmployee(int empId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT a.id, a.date, a.check_in_at, a.check_out_at, a.status
                             FROM attendance a
                             WHERE a.employee_id=@eid
                             ORDER BY a.date DESC";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@eid", empId);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public AttendanceDTO GetByEmpDate(int empId, DateTime date)
        {
            AttendanceDTO a = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM attendance WHERE employee_id=@e AND date=@d";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@e", empId);
                cmd.Parameters.AddWithValue("@d", date);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    a = new AttendanceDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        EmployeeId = r.GetInt32(r.GetOrdinal("employee_id")),
                        Date = r.GetDateTime(r.GetOrdinal("date")),
                        CheckInAt = r.IsDBNull(r.GetOrdinal("check_in_at")) ? (DateTime?)null : r.GetDateTime(r.GetOrdinal("check_in_at")),
                        CheckOutAt = r.IsDBNull(r.GetOrdinal("check_out_at")) ? (DateTime?)null : r.GetDateTime(r.GetOrdinal("check_out_at")),
                        Status = r.GetString(r.GetOrdinal("status"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return a;
        }

        public int Add(AttendanceDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO attendance(employee_id,date,check_in_at,check_out_at,status)
                             VALUES(@e,@d,@in,@out,@s); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@e", dto.EmployeeId);
                cmd.Parameters.AddWithValue("@d", dto.Date);
                cmd.Parameters.AddWithValue("@in", dto.CheckInAt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@out", dto.CheckOutAt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@s", dto.Status);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }

        public void Update(AttendanceDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE attendance
                             SET check_in_at=@in, check_out_at=@out, status=@s,
                                 updated_at=SYSUTCDATETIME()
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@in", dto.CheckInAt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@out", dto.CheckOutAt ?? (object)DBNull.Value);
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
                new SqlCommand("DELETE FROM attendance WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}