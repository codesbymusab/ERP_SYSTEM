using ERP_System.DL;
using ERP_System.DTO;
using System.Data;

namespace ERP_System.BL
{
    public class AuditBL
    {
        private readonly AuditDL dl = new AuditDL();

        public int AddAuditLog(AuditLogDTO dto) => dl.AddAuditLog(dto);

        public DataTable GetAllAuditLogs() => dl.GetAllAuditLogs();
    }
}
