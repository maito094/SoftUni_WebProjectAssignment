using AutomationShopHub.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product
{
   public class ProductModel
   {


      public Guid Id { get; set; }

      [Required]
      [StringLength(50)]
      public string Name { get; set; } = null!;
      [Required]
      [StringLength(1500)]
      public string Description { get; set; } = null!;

      [Required]
      public int CategoryId { get; set; }

      [Required]
      public Category Category { get; set; } = null!;

      [Required]
      public int BrandId { get; set; }

      [Required]
      public Brand Brand { get; set; } = null!;

      public DateTime ProductDateAdded { get; set; }

      public DateTime ProductDateModified { get; set; }

      [Required]
      public Guid SalesAgentId { get; set; }

      public SalesAgent SalesAgent { get; set; } = null!;

      public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
      public List<Comment> Comments { get; set; } = new List<Comment>();

      public bool isDeleted { get; set; }

      public IProductType ProductType { get; set; } = null!;


   }
}
