using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class Category
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
