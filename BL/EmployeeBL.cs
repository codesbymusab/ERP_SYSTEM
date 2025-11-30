using System;
using System.Data;
using ERP_System.DL;
using ERP_System.DTO;

namespace ERP_System.BL
{
    public class EmployeeBL
    {
        private readonly EmployeeDL dl = new EmployeeDL();

        public DataTable GetAllEmployees() => dl.GetAll();

        public DataTable SearchEmployees(string q) => dl.Search(q);

        public EmployeeDTO GetEmployee(int id) => dl.GetById(id);

        public int AddEmployee(EmployeeDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new Exception("Name required.");
            dto.Status = string.IsNullOrWhiteSpace(dto.Status) ? "active" : dto.Status;
            return dl.Add(dto);
        }

        public void UpdateEmployee(EmployeeDTO dto)
        {
            if (dto.Id <= 0)
                throw new Exception("Invalid ID.");
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new Exception("Name required.");
            dl.Update(dto);
        }

        public void DeleteEmployee(int id) => dl.Delete(id);

        public int GetTotalCount() => dl.GetCount();

       
        public int GetTotalEmployeesCount() => dl.GetTotalCount();

        public int GetActiveEmployeesCount() => dl.GetActiveCount();

        public int GetOnLeaveEmployeesCount => dl.GetOnLeaveCount();

       
        public int GetDepartmentsCount() => dl.GetDepartmentsCount();

       
       

    }
}
