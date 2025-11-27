using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class SaleItemBL
    {
        private readonly SaleItemDL dl = new SaleItemDL();

        public DataTable GetItems(int saleId) => dl.GetBySaleId(saleId);

        public void AddItem(SaleItemDTO dto) => dl.Add(dto);

        public void UpdateItem(SaleItemDTO dto) => dl.Update(dto);

        public void DeleteItem(int id) => dl.Delete(id);
    }
}