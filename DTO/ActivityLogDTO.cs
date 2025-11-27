using System;

namespace ERP_System.DTO
{
    public class ActivityLogDTO
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string ActionType { get; set; } 
        public string EntityType { get; set; } 
        public string EntityId { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}