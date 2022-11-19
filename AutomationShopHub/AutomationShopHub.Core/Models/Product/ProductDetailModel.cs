using AutomationShopHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models.Product
{
   public class ProductDetailModel
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

      public List<Comment> Comments { get; set; } = new List<Comment>();
   }
}
