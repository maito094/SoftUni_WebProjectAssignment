using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class OrderProduct
   {
      [Required]
      public Guid OrderId { get; set; }

      [ForeignKey(nameof(OrderId))]
      public Order Order { get; set; } = null!;

      [Required]
      public Guid ProductId { get; set; }

      [ForeignKey(nameof(ProductId))]
      public Product Product { get; set; } = null!;
   }
}
