using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System.DL
{
    public class SupplierDL
    {
        private DBConnection dbCon = new DBConnection();

        public SupplierDTO GetById(int id)
        {
            SupplierDTO supplier = null;
            try
            {
                dbCon.Con.Open();
                const string q = @"
                    SELECT id, name, contact_name, phone, email, address
                    FROM suppliers
                    WHERE id = @id";
                using (var cmd = new SqlCommand(q, dbCon.Con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            supplier = new SupplierDTO
                            {
                                Id = r.GetInt32(r.GetOrdinal("id")),
                                Name = r.IsDBNull(r.GetOrdinal("name")) ? null : r.GetString(r.GetOrdinal("name")),
                                ContactName = r.IsDBNull(r.GetOrdinal("contact_name")) ? null : r.GetString(r.GetOrdinal("contact_name")),
                                Phone = r.IsDBNull(r.GetOrdinal("phone")) ? null : r.GetString(r.GetOrdinal("phone")),
                                Email = r.IsDBNull(r.GetOrdinal("email")) ? null : r.GetString(r.GetOrdinal("email")),
                                Address = r.IsDBNull(r.GetOrdinal("address")) ? null : r.GetString(r.GetOrdinal("address"))
                            };
                        }
                    }
                }
            }
            finally
            {
                dbCon.Con.Close();
            }
            return supplier;
        }
        public DataTable GetAllSuppliers()
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                new SqlDataAdapter("SELECT * FROM suppliers ORDER BY name", dbCon.Con).Fill(dt);
            }
            finally { dbCon.Con.Close(); }
            return dt;
        }

        public void AddSupplier(SupplierDTO dto)
        {
            try
            {
                dbCon.Con.Open();
                string q = @"INSERT INTO suppliers(name,contact_name,phone,email,address)
                             VALUES(@n,@cn,@p,@e,@a)";
                SqlCommand cmd = new SqlCommand(q, dbCon.Con);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@cn", string.IsNullOrWhiteSpace(dto.ContactName) ? (object)DBNull.Value : dto.ContactName);
                cmd.Parameters.AddWithValue("@p", string.IsNullOrWhiteSpace(dto.Phone) ? (object)DBNull.Value : dto.Phone);
                cmd.Parameters.AddWithValue("@e", string.IsNullOrWhiteSpace(dto.Email) ? (object)DBNull.Value : dto.Email);
                cmd.Parameters.AddWithValue("@a", string.IsNullOrWhiteSpace(dto.Address) ? (object)DBNull.Value : dto.Address);
                cmd.ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }

        public void UpdateSupplier(SupplierDTO dto)
        {
            try
            {
                dbCon.Con.Open();
                string q = @"UPDATE suppliers
                             SET name=@n, contact_name=@cn, phone=@p, email=@e, address=@a
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, dbCon.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@n", dto.Name);
                cmd.Parameters.AddWithValue("@cn", string.IsNullOrWhiteSpace(dto.ContactName) ? (object)DBNull.Value : dto.ContactName);
                cmd.Parameters.AddWithValue("@p", string.IsNullOrWhiteSpace(dto.Phone) ? (object)DBNull.Value : dto.Phone);
                cmd.Parameters.AddWithValue("@e", string.IsNullOrWhiteSpace(dto.Email) ? (object)DBNull.Value : dto.Email);
                cmd.Parameters.AddWithValue("@a", string.IsNullOrWhiteSpace(dto.Address) ? (object)DBNull.Value : dto.Address);
                cmd.ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }

        public void DeleteSupplier(int supplierId)
        {
            try
            {
                dbCon.Con.Open();
                new SqlCommand("DELETE FROM suppliers WHERE id=" + supplierId, dbCon.Con).ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }
       

        public int GetSupplierProductCount(int supplierId)
        {
            try
            {
                dbCon.Con.Open();
                string q = "SELECT COUNT(*) FROM products WHERE supplier_id = @sid";
                using (var cmd = new SqlCommand(q, dbCon.Con))
                {
                    cmd.Parameters.AddWithValue("@sid", supplierId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { dbCon.Con.Close(); }
        }
    }
}
