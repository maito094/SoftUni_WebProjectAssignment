using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product
{
   public class ProductFormModel
   {

      [Key]
      public Guid Id { get; set; }

      [Required]
      [StringLength(50)]
      public string Name { get; set; } = null!;

      [Required]
      [StringLength(1500)]
      public string Description { get; set; } = null!;

      [StringLength(20, MinimumLength = 3)]
      public string Category { get; set; } = null!;

      [StringLength(30, MinimumLength = 3)]
      public string Brand { get; set; } = null!;

      [StringLength(50, MinimumLength = 3)]
      public string SalesAgent { get; set; } = null!;

   }
}
