namespace AutomationShopHub.Core.Models.Product
{
   public class AllProductOrderModel
    {
      public int TotalProductsCount { get; set; }
      public IEnumerable<ProductOrderModel> Products { get; set; } = new List<ProductOrderModel>();
   }
}
