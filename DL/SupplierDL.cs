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
    }
}
