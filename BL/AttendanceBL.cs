using System;
using System.Data;
using System.Runtime.CompilerServices;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class AttendanceBL
    {
        private readonly AttendanceDL dl = new AttendanceDL();
        private readonly EmployeeDL e_dl = new EmployeeDL();

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

        public int GetPresentCount(DateTime? date = null)
        {
            var d = date ?? DateTime.Today;
            return dl.GetPresentCount(d);
        }


        public int GetAbsentCount(DateTime? date = null)
        {
            var d = date ?? DateTime.Today;
            return dl.GetAbsentCount(d);
        }


        public decimal GetAttendancePercentage(DateTime? date = null)
        {
            var d = date ?? DateTime.Today;
            int total = e_dl.GetTotalCount();
            if (total <= 0) return 0m;

            int present = dl.GetPresentCount(d);
            decimal pct = (decimal)present / total * 100m;
            return Math.Round(pct, 2);
        }
        public DataTable GetDateAttendance(DateTime date) => dl.GetAttendanceByDate(date);

      
        public void CheckInEmployee(int employeeId, DateTime dateTime)
        {
            if (employeeId <= 0) throw new ArgumentException("Invalid employee id.", nameof(employeeId));
            dl.CheckIn(employeeId, dateTime);
        }

        
        public void CheckOutEmployee(int employeeId, DateTime dateTime)
        {
            if (employeeId <= 0) throw new ArgumentException("Invalid employee id.", nameof(employeeId));
            dl.CheckOut(employeeId, dateTime);
        }

    }
}