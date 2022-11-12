using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Entities.ProductTypes
{
   /// <summary>
   /// Magnetic
   /// Inductitive
   /// Capacitive
   /// Resistive
   /// Optical
   /// Laser
   /// </summary>
   public class SensorType
   {
      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Name { get; set; } = null!;

   }
}
