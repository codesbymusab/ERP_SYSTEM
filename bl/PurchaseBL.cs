using System;
using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class PurchaseBL
    {
        private readonly PurchaseDL dl = new PurchaseDL();

        public DataTable GetAllPurchases() => dl.GetAll();

        public PurchaseDTO GetPurchase(int id) => dl.GetById(id);

        public int AddPurchase(PurchaseDTO dto)
        {
            if (dto.SupplierId <= 0)
                throw new Exception("Supplier required.");
            if (dto.TotalAmount < 0)
                throw new Exception("Negative total amount.");
            return dl.Add(dto);
        }

        public void UpdatePurchase(PurchaseDTO dto) => dl.Update(dto);

        public void DeletePurchase(int id) => dl.Delete(id);
    }
}