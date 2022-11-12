using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class Product
   {
      [Key]
      public Guid Id { get; set; }

      [Required]
      [StringLength(50)]
      public string Name { get; set; } = null!;

      [Required]
      [StringLength(1500)]
      public string Description { get; set; } = null!;

      [Required]
      public int CategoryId { get; set; }

      [ForeignKey(nameof(CategoryId))]
      public Category Category { get; set; } = null!;

      [Required]
      public int BrandId { get; set; }

      [ForeignKey(nameof(BrandId))]
      public Brand Brand { get; set; } = null!;

      public DateTime ProductDateAdded { get; set; }

      public DateTime ProductDateModified { get; set; }

      [Required]
      public Guid SalesAgentId { get; set; }

      [ForeignKey(nameof(SalesAgentId))]
      public SalesAgent SalesAgent { get; set; } = null!;

      public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
      public List<Comment> Comments { get; set; } = new List<Comment>();

      public bool isDeleted { get; set; }
   }
}
