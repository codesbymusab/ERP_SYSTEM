using System;
using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class EmployeeDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT e.id, e.name, e.department, e.role_title, e.salary,
                                    e.status, e.user_id, u.name AS user_name
                             FROM employees e
                             LEFT JOIN users u ON e.user_id = u.id";
                new SqlDataAdapter(q, db.Con).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public EmployeeDTO GetById(int id)
        {
            EmployeeDTO emp = null;
            try
            {
                db.Con.Open();
                string q = "SELECT * FROM employees WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", id);
                var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    emp = new EmployeeDTO
                    {
                        Id = r.GetInt32(r.GetOrdinal("id")),
                        UserId = r.IsDBNull(r.GetOrdinal("user_id")) ? (int?)null : r.GetInt32(r.GetOrdinal("user_id")),
                        Name = r.GetString(r.GetOrdinal("name")),
                        Department = r.IsDBNull(r.GetOrdinal("department")) ? null : r.GetString(r.GetOrdinal("department")),
                        RoleTitle = r.IsDBNull(r.GetOrdinal("role_title")) ? null : r.GetString(r.GetOrdinal("role_title")),
                        Salary = r.IsDBNull(r.GetOrdinal("salary")) ? (decimal?)null : r.GetDecimal(r.GetOrdinal("salary")),
                        Status = r.GetString(r.GetOrdinal("status"))
                    };
                }
                r.Close();
            }
            finally { db.Con.Close(); }
            return emp;
        }

        public int Add(EmployeeDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO employees(user_id,name,department,role_title,salary,status)
                             VALUES(@uid,@n,@d,@r,@s,@st); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@uid", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@d", string.IsNullOrWhiteSpace(dto.Department) ? (object)DBNull.Value : dto.Department);
                cmd.Parameters.AddWithValue("@r", string.IsNullOrWhiteSpace(dto.RoleTitle) ? (object)DBNull.Value : dto.RoleTitle);
                cmd.Parameters.AddWithValue("@s", dto.Salary ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@st", dto.Status);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally { db.Con.Close(); }
        }

        public void Update(EmployeeDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE employees
                             SET user_id=@uid, name=@n, department=@d, role_title=@r,
                                 salary=@s, status=@st, updated_at=SYSUTCDATETIME()
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@uid", dto.UserId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@d", string.IsNullOrWhiteSpace(dto.Department) ? (object)DBNull.Value : dto.Department);
                cmd.Parameters.AddWithValue("@r", string.IsNullOrWhiteSpace(dto.RoleTitle) ? (object)DBNull.Value : dto.RoleTitle);
                cmd.Parameters.AddWithValue("@s", dto.Salary ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@st", dto.Status);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Delete(int id)
        {
            try
            {
                db.Con.Open();
                new SqlCommand("DELETE FROM employees WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}