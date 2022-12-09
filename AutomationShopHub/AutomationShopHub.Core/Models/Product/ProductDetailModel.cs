using AutomationShopHub.Infrastructure.Data.Entities;

namespace AutomationShopHub.Core.Models.Product
{
   public class ProductDetailModel
   {
      public Guid Id { get; set; }
      public int ProductTypeId { get; set; }

      public string Name { get; set; } = null!;

      public string Description { get; set; } = null!;

      public string Category { get; set; } = null!;

      public string Brand { get; set; } = null!;
      public string SalesAgentPhoneNumber { get; set; } = null!;
      public string SalesAgentEmail { get; set; } = null!;
      public string? SalesAgentProfileURL { get; set; }

      public IProductType ProductType { get; set; } = null!;
      public DateTime ProductDateAdded { get; set; }

      public List<CommentModel> Comments { get; set; } = new List<CommentModel>();
   }
}
