using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   /// <summary>
   /// Magnetic
   /// Inductitive
   /// Capacitive
   /// Resistive
   /// Optical
   /// Laser
   /// </summary>
   public class SensorTypeModel
   {
      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Name { get; set; } = null!;

   }
}
