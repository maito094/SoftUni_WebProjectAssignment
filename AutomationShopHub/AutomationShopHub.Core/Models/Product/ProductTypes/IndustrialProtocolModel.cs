using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   /// <summary>
   /// None
   /// EtherCat
   /// Profibus
   /// Profinet
   /// EthernetIP
   /// CC-Link
   /// Modbus
   /// IO-Link
   /// </summary>
   public class IndustrialProtocolModel
   {
      [Key]
      public int Id { get; set; }

      [Required]
      [StringLength(30)]
      public string Name { get; set; } = null!;

      [Required]
      [StringLength(1500)]
      public string Description { get; set; } = null!;

   }
}
