using ERP_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_System.DL;

namespace ERP_System.BL
{
    public class ProductBL
    {
        private ProductDL prodDL = new ProductDL();

        public DataTable GetAllProducts() => prodDL.GetAllProducts();

        public void AddProduct(ProductDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name))
                throw new Exception("Product name is required.");
            if (dto.Stock < 0)
                throw new Exception("Stock cannot be negative.");
            prodDL.AddProduct(dto);
        }

        public void UpdateProduct(ProductDTO dto)
        {
            if (dto.Id <= 0)
                throw new Exception("Invalid product ID.");
            prodDL.UpdateProduct(dto);
        }

        public void DeleteProduct(int id) => prodDL.DeleteProduct(id);

        public DataTable GetLowStockProducts() => prodDL.GetLowStockProducts();

        private readonly ProductDL dl = new ProductDL();

        public int GetTotalProductCount() => prodDL.GetTotalProductCount();

        public decimal GetTotalInventoryValue() => prodDL.GetTotalInventoryValue();

        public int GetLowStockCount() => prodDL.GetLowStockCount();

        public int GetOutOfStockCount() => prodDL.GetOutOfStockCount();

       
        public ProductDTO GetProduct(int id) => prodDL.GetProductById(id);

        public DataTable GetProductsBySupplier(int sid) => prodDL.GetProductBySupplier(sid);

        public DataTable SearchProducts(string queryText) => prodDL.SearchProducts(queryText);


    }
}
