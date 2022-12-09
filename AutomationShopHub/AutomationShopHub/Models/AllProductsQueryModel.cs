using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.Enum;

namespace AutomationShopHub.Models
{
    public class AllProductsQueryModel
    {
      public const int ProductsPerPage = 3;

      public string? Category { get; set; }

      public string? SearchTerm { get; set; }

      public ProductSorting Sorting { get; set; }

      public int CurrentPage { get; set; } = 1;

      public int TotalProductsCount { get; set; }

      public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

      public IEnumerable<ProductModel> Products { get; set; }= Enumerable.Empty<ProductModel>();
   }
}
