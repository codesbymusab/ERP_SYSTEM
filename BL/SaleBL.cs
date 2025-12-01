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

        public DataTable GetAllSalesByStatus(string status) => dl.GetAllByStatus(status);

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

        public int GetTotalSalesCount(string status) => dl.GetTotalSalesCount(status);

      

        public decimal GetTotalRevenue() => dl.GetTotalRevenue();

        
        public decimal GetTotalRevenue(DateTime from, DateTime to) => dl.GetTotalRevenue(from, to);

        public decimal GetTotalRevenue(DateTime? from, DateTime? to) => dl.GetTotalRevenue(from, to);
    
    
    
    }
}