using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models.Product
{
    public class ProductQueryModel
    {
      public int TotalProductsCount { get; set; }
      public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
   }
}
