namespace AutomationShopHub.Core.Models.Product
{
   public class ProductQueryModel
    {
      public int TotalProductsCount { get; set; }
      public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
   }
}
