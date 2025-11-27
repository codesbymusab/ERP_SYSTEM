using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_System.DTO
{
        public class ProductDTO
        {
            public int Id { get; set; }
            public string SKU { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public int Stock { get; set; }
            public decimal? PurchasePrice { get; set; }
            public decimal? SellingPrice { get; set; }
            public int? SupplierId { get; set; }
            public int LowStockThreshold { get; set; }
        }
    }
}
