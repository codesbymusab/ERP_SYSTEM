using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string RoleTitle { get; set; }
        public decimal? Salary { get; set; }
        public string Status { get; set; }
    }
}
