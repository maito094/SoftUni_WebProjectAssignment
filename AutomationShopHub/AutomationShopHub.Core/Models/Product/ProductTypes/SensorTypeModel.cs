using System.ComponentModel.DataAnnotations;

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
