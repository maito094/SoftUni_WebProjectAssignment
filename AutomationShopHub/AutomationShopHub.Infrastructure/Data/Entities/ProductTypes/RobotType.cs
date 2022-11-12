using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Infrastructure.Data.Entities.ProductTypes
{
   /// <summary>
   /// Cobots
   /// Delta
   /// SCARA
   /// 6-Axis
   /// </summary>
   public class RobotType
   {

      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Name { get; set; } = null!;

   }
}
