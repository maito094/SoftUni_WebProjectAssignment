using AutomationShopHub.Core.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Models.Product
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


      [Display(Name = "Brand")]
      public int BrandId { get; set; }
      public IEnumerable<BrandModel> Brands { get; set; } = new List<BrandModel>();

      [Display(Name = "Category")]
      public int CategoryId { get; set; }
      public IEnumerable<CategoryModel> Categories { get; set; } = new List<CategoryModel>();

   }
}
