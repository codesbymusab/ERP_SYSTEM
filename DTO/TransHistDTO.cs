// File: ERP_System.DTO/TransactionDTO.cs
using System;

namespace ERP_System.DTO
{
    public class TransHistDTO
    {
        public int Id { get; set; }
        public string TransactionType { get; set; }    
        
        public int ReferenceId { get; set; }         
        public decimal Amount { get; set; }
        public string Status { get; set; }             
        public int? PerformedBy { get; set; }        
        public string PerformedByName { get; set; }  
        public DateTime PerformedAt { get; set; } = DateTime.UtcNow;
        public string Notes { get; set; }
       
    }
}
