using ERP_System.BL;
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

        /// <summary>
        /// Returns total number of products.
        /// </summary>
        public int GetTotalProductCount()
        {
            try
            {
                dbCon.Con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM products", dbCon.Con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { dbCon.Con.Close(); }
        }

       
        public decimal GetTotalInventoryValue()
        {
            try
            {
                dbCon.Con.Open();
                string q = @"SELECT SUM(CAST(stock AS DECIMAL(18,2)) * purchase_price) 
                     FROM products WHERE purchase_price IS NOT NULL";
                using (SqlCommand cmd = new SqlCommand(q, dbCon.Con))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0m;
                }
            }
            finally { dbCon.Con.Close(); }
        }

       
        public int GetLowStockCount()
        {
            try
            {
                dbCon.Con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM products WHERE stock <= low_stock_threshold", dbCon.Con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { dbCon.Con.Close(); }
        }

        
        public int GetOutOfStockCount()
        {
            try
            {
                dbCon.Con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM products WHERE stock = 0", dbCon.Con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            finally { dbCon.Con.Close(); }
        }

        /// <summary>
        /// Get a single product by its ID.
        /// </summary>
        public ProductDTO GetProductById(int id)
        {
            ProductDTO dto = null;
            try
            {
                dbCon.Con.Open();
                string q = @"SELECT p.id, p.sku, p.name, p.category, p.description, p.stock,
                            p.purchase_price, p.selling_price, p.supplier_id,
                            p.low_stock_threshold, s.name AS supplier_name
                     FROM products p
                     LEFT JOIN suppliers s ON p.supplier_id = s.id
                     WHERE p.id = @id";
                using (SqlCommand cmd = new SqlCommand(q, dbCon.Con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            dto = new ProductDTO
                            {
                                Id = r.GetInt32(r.GetOrdinal("id")),
                                SKU = r.IsDBNull(r.GetOrdinal("sku")) ? null : r.GetString(r.GetOrdinal("sku")),
                                Name = r.GetString(r.GetOrdinal("name")),
                                Category = r.IsDBNull(r.GetOrdinal("category")) ? null : r.GetString(r.GetOrdinal("category")),
                                Description = r.IsDBNull(r.GetOrdinal("description")) ? null : r.GetString(r.GetOrdinal("description")),
                                Stock = r.GetInt32(r.GetOrdinal("stock")),
                                PurchasePrice = r.IsDBNull(r.GetOrdinal("purchase_price")) ? (decimal?)null : r.GetDecimal(r.GetOrdinal("purchase_price")),
                                SellingPrice = r.IsDBNull(r.GetOrdinal("selling_price")) ? (decimal?)null : r.GetDecimal(r.GetOrdinal("selling_price")),
                                SupplierId = r.IsDBNull(r.GetOrdinal("supplier_id")) ? (int?)null : r.GetInt32(r.GetOrdinal("supplier_id")),
                                LowStockThreshold = r.GetInt32(r.GetOrdinal("low_stock_threshold")),
                            
                            };
                        }
                    }
                }
            }
            finally { dbCon.Con.Close(); }
            return dto;
        }

        public DataTable GetProductBySupplier(int sid)
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string q = @"SELECT p.id, p.sku, p.name, p.category, p.stock,
                                    p.purchase_price, p.selling_price, p.supplier_id,
                                    p.low_stock_threshold, s.name AS supplier_name
                             FROM products p
                             LEFT JOIN suppliers s ON p.supplier_id = s.id
                             WHERE supplier_id=@sid";
                SqlCommand cmd = new SqlCommand(q, dbCon.Con);


                cmd.Parameters.AddWithValue("@sid", sid);
                new SqlDataAdapter(cmd).Fill(dt);
            }

            finally { dbCon.Con.Close(); }
            return dt;
        }

       
        public DataTable SearchProducts(string queryText)
        {
            DataTable dt = new DataTable();
            try
            {
                dbCon.Con.Open();
                string q = @"SELECT p.id, p.sku, p.name, p.category, p.stock,
                            p.purchase_price, p.selling_price, p.supplier_id,
                            p.low_stock_threshold, s.name AS supplier_name
                     FROM products p
                     LEFT JOIN suppliers s ON p.supplier_id = s.id
                     WHERE p.name LIKE @q OR p.category LIKE @q OR p.sku LIKE @q
                     ORDER BY p.name";
                using (SqlCommand cmd = new SqlCommand(q, dbCon.Con))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + (queryText ?? string.Empty) + "%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally { dbCon.Con.Close(); }
            return dt;
        }

    }
}
