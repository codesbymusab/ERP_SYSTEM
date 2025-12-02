using System;
using System.Collections.Generic;

namespace ERP_System.DTO
{
    public class PurchaseDTO
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int? UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<PurchaseItemDTO> Items{ get; set; } = new List<PurchaseItemDTO>();

    }
}