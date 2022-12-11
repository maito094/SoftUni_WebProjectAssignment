using AutomationShopHub.Core.Models.Product;

namespace AutomationShopHub.Core.Models
{
   public class ProductOrderModel
   {
      public Guid Id { get; set; }

      public string Name { get; set; } = null!;

      public string Description { get; set; } = null!;

      public int CategoryId { get; set; }

      public string CategoryName { get; set; } = null!;
      public IProductType? ProductType { get; set; }

   }
}
