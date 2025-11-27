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
    public class ProductDL
    {
        private DBConnection dbCon = new DBConnection();

        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string q = @"SELECT p.id, p.sku, p.name, p.category, p.stock,
                                    p.purchase_price, p.selling_price, p.supplier_id,
                                    p.low_stock_threshold, s.name AS supplier_name
                             FROM products p
                             LEFT JOIN suppliers s ON p.supplier_id = s.id";
                new SqlDataAdapter(q, dbCon.Con).Fill(dt);
            }
            finally { dbCon.Con.Close(); }
            return dt;
        }

        public void AddProduct(ProductDTO dto)
        {
            try
            {
                dbCon.Con.Open();
                string q = @"INSERT INTO products(sku,name,category,description,stock,
                                                purchase_price,selling_price,supplier_id,
                                                low_stock_threshold)
                             VALUES(@sku,@name,@cat,@desc,@stock,@pp,@sp,@sup,@lst)";
                SqlCommand cmd = new SqlCommand(q, dbCon.Con);
                cmd.Parameters.AddWithValue("@sku", string.IsNullOrWhiteSpace(dto.SKU) ? (object)DBNull.Value : dto.SKU);
                cmd.Parameters.AddWithValue("@name", dto.Name);
                cmd.Parameters.AddWithValue("@cat", string.IsNullOrWhiteSpace(dto.Category) ? (object)DBNull.Value : dto.Category);
                cmd.Parameters.AddWithValue("@desc", string.IsNullOrWhiteSpace(dto.Description) ? (object)DBNull.Value : dto.Description);
                cmd.Parameters.AddWithValue("@stock", dto.Stock);
                cmd.Parameters.AddWithValue("@pp", dto.PurchasePrice ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@sp", dto.SellingPrice ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@sup", dto.SupplierId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@lst", dto.LowStockThreshold);
                cmd.ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }

        public void UpdateProduct(ProductDTO dto)
        {
            try
            {
                dbCon.Con.Open();
                string q = @"UPDATE products
                             SET sku=@sku, name=@name, category=@cat,
                                 description=@desc, stock=@stock,
                                 purchase_price=@pp, selling_price=@sp,
                                 supplier_id=@sup, low_stock_threshold=@lst
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, dbCon.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@sku", string.IsNullOrWhiteSpace(dto.SKU) ? (object)DBNull.Value : dto.SKU);
                cmd.Parameters.AddWithValue("@name", dto.Name);
                cmd.Parameters.AddWithValue("@cat", string.IsNullOrWhiteSpace(dto.Category) ? (object)DBNull.Value : dto.Category);
                cmd.Parameters.AddWithValue("@desc", string.IsNullOrWhiteSpace(dto.Description) ? (object)DBNull.Value : dto.Description);
                cmd.Parameters.AddWithValue("@stock", dto.Stock);
                cmd.Parameters.AddWithValue("@pp", dto.PurchasePrice ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@sp", dto.SellingPrice ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@sup", dto.SupplierId ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@lst", dto.LowStockThreshold);
                cmd.ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                dbCon.Con.Open();
                new SqlCommand("DELETE FROM products WHERE id=" + productId, dbCon.Con).ExecuteNonQuery();
            }
            finally { dbCon.Con.Close(); }
        }

        public DataTable GetLowStockProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string q = "SELECT * FROM products WHERE stock <= low_stock_threshold";
                new SqlDataAdapter(q, dbCon.Con).Fill(dt);
            }
            finally { dbCon.Con.Close(); }
            return dt;
        }
    }
}
