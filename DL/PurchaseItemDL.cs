using System.Data;
using System.Data.SqlClient;
using ERP_System.DTO;

namespace ERP_System.DL
{
    public class PurchaseItemDL
    {
        private readonly DBConnection db = new DBConnection();

        public DataTable GetByPurchaseId(int purchaseId)
        {
            DataTable dt = new DataTable();
            try
            {
                db.Con.Open();
                string q = @"SELECT pi.id, pi.quantity, pi.unit_price, pi.total_price,
                                    p.name AS product_name
                             FROM purchase_items pi
                             JOIN products p ON pi.product_id = p.id
                             WHERE pi.purchase_id=@pid";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@pid", purchaseId);
                new SqlDataAdapter(cmd).Fill(dt);
            }
            finally { db.Con.Close(); }
            return dt;
        }

        public void Add(PurchaseItemDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"INSERT INTO purchase_items(purchase_id,product_id,quantity,unit_price,total_price)
                             VALUES(@pid,@prid,@q,@up,@tp)";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@pid", dto.PurchaseId);
                cmd.Parameters.AddWithValue("@prid", dto.ProductId);
                cmd.Parameters.AddWithValue("@q", dto.Quantity);
                cmd.Parameters.AddWithValue("@up", dto.UnitPrice);
                cmd.Parameters.AddWithValue("@tp", dto.TotalPrice);
                cmd.ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }

        public void Update(PurchaseItemDTO dto)
        {
            try
            {
                db.Con.Open();
                string q = @"UPDATE purchase_items
                             SET product_id=@prid, quantity=@q, unit_price=@up, total_price=@tp
                             WHERE id=@id";
                SqlCommand cmd = new SqlCommand(q, db.Con);
                cmd.Parameters.AddWithValue("@id", dto.Id);
                cmd.Parameters.AddWithValue("@prid", dto.ProductId);
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
                new SqlCommand("DELETE FROM purchase_items WHERE id=" + id, db.Con).ExecuteNonQuery();
            }
            finally { db.Con.Close(); }
        }
    }
}