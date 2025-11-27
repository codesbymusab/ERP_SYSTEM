using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProject.DL;

namespace ERP_System.BL
{
    public class SupplierBL
    {
        private SupplierDL supDL = new SupplierDL();

        public DataTable GetAllSuppliers() => supDL.GetAllSuppliers();

        public void AddSupplier(SupplierDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new Exception("Supplier name is required.");
            supDL.AddSupplier(dto);
        }

        public void UpdateSupplier(SupplierDTO dto) => supDL.UpdateSupplier(dto);

        public void DeleteSupplier(int id) => supDL.DeleteSupplier(id);
    }
}
