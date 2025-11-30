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

        public int GetPresentCount(DateTime date)
        {
            try
            {
                db.Con.Open();
                const string q = @"
            SELECT COUNT(DISTINCT a.employee_id)
            FROM attendance a
            WHERE a.[date] = @date AND a.status = @status";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@status", "present");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { db.Con.Close(); }
        }

        public int GetAbsentCount(DateTime date)
        {
            try
            {
                db.Con.Open();
                const string q = @"
            SELECT COUNT(DISTINCT a.employee_id)
            FROM attendance a
            WHERE a.[date] = @date AND a.status = @status";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@status", "absent");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { db.Con.Close(); }
        }

        public int GetLateCount(DateTime date)
        {
            try
            {
                db.Con.Open();
                const string q = @"
            SELECT COUNT(DISTINCT a.employee_id)
            FROM attendance a
            WHERE a.[date] = @date AND a.status = @status";
                using (var cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    cmd.Parameters.AddWithValue("@status", "late");
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { db.Con.Close(); }
        }
        
        public DataTable GetAttendanceByDate(DateTime date)
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();

                string q = @"
            SELECT 
                e.id AS employee_id,
                e.name AS employee_name,
                e.department,
                e.role_title,
                a.[date] AS attendance_date,
                a.check_in_at,
                a.check_out_at,
                CASE 
                    WHEN a.id IS NULL THEN 'not_recorded'
                    ELSE a.status
                END AS attendance_status
            FROM employees e
            LEFT JOIN attendance a
                ON a.employee_id = e.id AND a.[date] = @date
            ORDER BY e.name;
        ";

                using (SqlCommand cmd = new SqlCommand(q, db.Con))
                {
                    cmd.Parameters.AddWithValue("@date", date.Date);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
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
       
        public void CheckIn(int employeeId, DateTime dateTime)
        {
            try
            {
                db.Con.Open();

                // check if attendance row exists for that date
                string qFind = "SELECT id FROM attendance WHERE employee_id = @eid AND [date] = @date";
                using (var cmdFind = new SqlCommand(qFind, db.Con))
                {
                    cmdFind.Parameters.AddWithValue("@eid", employeeId);
                    cmdFind.Parameters.AddWithValue("@date", dateTime.Date);
                    var existing = cmdFind.ExecuteScalar();

                    if (existing != null && existing != DBNull.Value)
                    {
                        // update existing row: set check_in_at and status = 'present'
                        string qUpdate = @"UPDATE attendance
                                   SET check_in_at = @checkin, status = @status, updated_at = SYSUTCDATETIME()
                                   WHERE id = @id";
                        using (var cmdUpd = new SqlCommand(qUpdate, db.Con))
                        {
                            cmdUpd.Parameters.AddWithValue("@checkin", dateTime);
                            cmdUpd.Parameters.AddWithValue("@status", "present");
                            cmdUpd.Parameters.AddWithValue("@id", Convert.ToInt32(existing));
                            cmdUpd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // insert new attendance row
                        string qInsert = @"INSERT INTO attendance (employee_id, [date], check_in_at, status, created_at, updated_at)
                                   VALUES (@eid, @date, @checkin, @status, SYSUTCDATETIME(), SYSUTCDATETIME())";
                        using (var cmdIns = new SqlCommand(qInsert, db.Con))
                        {
                            cmdIns.Parameters.AddWithValue("@eid", employeeId);
                            cmdIns.Parameters.AddWithValue("@date", dateTime.Date);
                            cmdIns.Parameters.AddWithValue("@checkin", dateTime);
                            cmdIns.Parameters.AddWithValue("@status", "present");
                            cmdIns.ExecuteNonQuery();
                        }
                    }
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

       
        public void CheckOut(int employeeId, DateTime dateTime)
        {
            try
            {
                db.Con.Open();

                string qFind = "SELECT id FROM attendance WHERE employee_id = @eid AND [date] = @date";
                using (var cmdFind = new SqlCommand(qFind, db.Con))
                {
                    cmdFind.Parameters.AddWithValue("@eid", employeeId);
                    cmdFind.Parameters.AddWithValue("@date", dateTime.Date);
                    var existing = cmdFind.ExecuteScalar();

                    if (existing != null && existing != DBNull.Value)
                    {
                        // update existing row: set check_out_at
                        string qUpdate = @"UPDATE attendance
                                   SET check_out_at = @checkout, updated_at = SYSUTCDATETIME()
                                   WHERE id = @id";
                        using (var cmdUpd = new SqlCommand(qUpdate, db.Con))
                        {
                            cmdUpd.Parameters.AddWithValue("@checkout", dateTime);
                            cmdUpd.Parameters.AddWithValue("@id", Convert.ToInt32(existing));
                            cmdUpd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // insert new attendance row with only check_out_at (rare but handle it)
                        string qInsert = @"INSERT INTO attendance (employee_id, [date], check_out_at, status, created_at, updated_at)
                                   VALUES (@eid, @date, @checkout, @status, SYSUTCDATETIME(), SYSUTCDATETIME())";
                        using (var cmdIns = new SqlCommand(qInsert, db.Con))
                        {
                            cmdIns.Parameters.AddWithValue("@eid", employeeId);
                            cmdIns.Parameters.AddWithValue("@date", dateTime.Date);
                            cmdIns.Parameters.AddWithValue("@checkout", dateTime);
                            cmdIns.Parameters.AddWithValue("@status", "present");
                            cmdIns.ExecuteNonQuery();
                        }
                    }
                }
            }
            finally
            {
                db.Con.Close();
            }
        }

    }
}