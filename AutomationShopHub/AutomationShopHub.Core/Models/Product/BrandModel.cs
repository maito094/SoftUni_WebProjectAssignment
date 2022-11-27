using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product
{
   public class BrandModel
    {
      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(60)]
      public string Name { get; set; } = null!;

      [Required]
      [StringLength(1000)]
      public string Description { get; set; } = null!;
   }
}
