using System;

namespace ERP_System.DTO
{
    public class AuditLogDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string AdjustmentType { get; set; }   
        public int Quantity { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public string AdjustedBy { get; set; }      
        public DateTime AdjustedAt { get; set; }
        public int PreviousStock { get; set; }
        public int NewStock { get; set; }
    }
}
