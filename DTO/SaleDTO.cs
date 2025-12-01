using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System.DTO
{
    public class SaleDTO
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int? UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public List<SaleItemDTO> Items{get; set;  } = new List<SaleItemDTO>();
    }
}
