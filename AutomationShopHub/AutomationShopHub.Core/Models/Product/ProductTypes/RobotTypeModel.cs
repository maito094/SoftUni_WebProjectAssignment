using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   /// <summary>
   /// Cobots
   /// Delta
   /// SCARA
   /// 6-Axis
   /// </summary>
   public class RobotTypeModel
   {

      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Name { get; set; } = null!;

   }
}
