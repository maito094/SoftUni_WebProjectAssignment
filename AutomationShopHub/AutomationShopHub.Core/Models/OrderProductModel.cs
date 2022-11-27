using AutomationShopHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationShopHub.Core.Models.Product;

namespace AutomationShopHub.Core.Models
{
    public class OrderProductModel
    {
      [Required]
      public Guid OrderId { get; set; }

      [ForeignKey(nameof(OrderId))]
      public Order Order { get; set; } = null!;

      [Required]
      public Guid ProductId { get; set; }

      [ForeignKey(nameof(ProductId))]
      public ProductModel Product { get; set; } = null!;
   }
}
