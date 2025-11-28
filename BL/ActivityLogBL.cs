using ERP_System.DL;
using ERP_System.DTO;
using System;
using System.Data;

namespace ERP_System.BL
{
    public class ActivityLogBL
    {
        private readonly ActivityLogDL dl = new ActivityLogDL();

        public DataTable GetAllLogs() => dl.GetAll();

        public void Log(ActivityLogDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.ActionType))
                throw new Exception("Action type required.");
            dl.Add(dto);
        }
    }
}