using System;
using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class AttendanceBL
    {
        private readonly AttendanceDL dl = new AttendanceDL();

        public DataTable GetAttendanceByEmployee(int empId) => dl.GetByEmployee(empId);

        public AttendanceDTO GetAttendance(int empId, DateTime date) => dl.GetByEmpDate(empId, date);

        public int AddAttendance(AttendanceDTO dto)
        {
            if (dto.EmployeeId <= 0)
                throw new Exception("Invalid employee.");
            if (dl.GetByEmpDate(dto.EmployeeId, dto.Date) != null)
                throw new Exception("Attendance already recorded for this date.");
            return dl.Add(dto);
        }

        public void UpdateAttendance(AttendanceDTO dto) => dl.Update(dto);

        public void DeleteAttendance(int id) => dl.Delete(id);
    }
}