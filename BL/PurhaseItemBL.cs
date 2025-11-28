using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class PurchaseItemBL
    {
        private readonly PurchaseItemDL dl = new PurchaseItemDL();

        public DataTable GetItems(int purchaseId) => dl.GetByPurchaseId(purchaseId);

        public void AddItem(PurchaseItemDTO dto) => dl.Add(dto);

        public void UpdateItem(PurchaseItemDTO dto) => dl.Update(dto);

        public void DeleteItem(int id) => dl.Delete(id);
    }
}