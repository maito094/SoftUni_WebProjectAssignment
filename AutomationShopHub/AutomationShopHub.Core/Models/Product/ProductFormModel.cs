using AutomationShopHub.Infrastructure.Data.Entities;
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

     
      [Display(Name="Brand")]
      public int BrandId { get; set; }
      public IEnumerable<ProductBrandModel> Brands { get; set; } = new List<ProductBrandModel>();

        [Display(Name="Category")]
      public int CategoryId { get; set; }
      public IEnumerable<ProductCategoryModel> Categories { get; set; } = new List<ProductCategoryModel>();


   }
}
