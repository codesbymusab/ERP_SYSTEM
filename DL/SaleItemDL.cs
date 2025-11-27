using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class SaleItemDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetBySaleId(int saleId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT si.id, si.quantity, si.unit_price, si.total_price,
                                    p.name AS product_name
                             FROM sale_items si
                             JOIN products p ON si.product_id = p.id
                             WHERE si.sale_id=@sid";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@sid", saleId);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public void Add(SaleItemDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO sale_items(sale_id,product_id,quantity,unit_price,total_price)
                             VALUES(@sid,@pid,@q,@up,@tp)";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@sid", dto.SaleId);
                cmd.Parameters.AddWithValue("@pid", dto.ProductId);
                cmd.Parameters.AddWithValue("@q", dto.Quantity);
                cmd.Parameters.AddWithValue("@up", dto.UnitPrice);
                cmd.Parameters.AddWithValue("@tp", dto.TotalPrice);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Update(SaleItemDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE sale_items
                             SET product_id=@pid, quantity=@q, unit_price=@up, total_price=@tp
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@pid", dto.ProductId);
                cmd.Parameters.AddWithValue("@q", dto.Quantity);
                cmd.Parameters.AddWithValue("@up", dto.UnitPrice);
                cmd.Parameters.AddWithValue("@tp", dto.TotalPrice);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Delete(int id)
        {
            try
            {
                db.Con.Open();
                new SqlCommand("DELETE FROM sale_items WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}