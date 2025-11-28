using System;
using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class SaleBL
    {
        private readonly SaleDL dl = new SaleDL();

        public DataTable GetAllSales() => dl.GetAll();

        public SaleDTO GetSale(int id) => dl.GetById(id);

        public int AddSale(SaleDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CustomerName))
                throw new Exception("Customer name required.");
            if (dto.TotalAmount < 0)
                throw new Exception("Negative total amount.");
            dto.Status = "draft";
            return dl.Add(dto);
        }

        public void UpdateSale(SaleDTO dto) => dl.Update(dto);

        public void DeleteSale(int id) => dl.Delete(id);
    }
}