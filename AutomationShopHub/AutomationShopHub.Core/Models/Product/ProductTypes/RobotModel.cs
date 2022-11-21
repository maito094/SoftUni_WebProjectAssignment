using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   public class RobotModel : IProductType
   {
      [Key]
      public int Id { get; set; }

      [Required]
      public Guid ProductId { get; set; }

      [ForeignKey(nameof(ProductId))]
      public ProductModel Product { get; set; } = null!;

      [Required]
      [StringLength(30)]
      public string ModelReference { get; set; } = null!;

      [Required]
      public int CommunicationProtocolId { get; set; }

      public IndustrialProtocolModel Protocol { get; set; } = null!;

      [Required]
      [Range(typeof(int), "3", "6")]
      public int NumberOfAxis { get; set; }

      [Required]
      [Range(typeof(decimal), "10.00", "30000.00")]
      public decimal Speed { get; set; }

      [Required]
      public int RobotTypeId { get; set; }

      [ForeignKey(nameof(RobotTypeId))]
      public RobotTypeModel Type { get; set; } = null!;

      [Required]
      [Range(typeof(decimal), "100.00", "10000.00")]
      public decimal Reach { get; set; }

      [Required]
      [Range(typeof(decimal), "1.00", "1000.00")]
      public decimal Payload { get; set; }

      [Required]
      [StringLength(1000)]
      public string Description { get; set; } = null!;

      [Required]
      [Range(typeof(int), "1", "60")]
      public int GuaranteePeriod { get; set; }

      [Required]
      [StringLength(512)]
      public string ImageUrl { get; set; } = null!;

      [Required]
      [StringLength(512)]
      public string DatasheetUrl { get; set; } = null!;

      [Required]
      [Range(typeof(decimal), "10.00", "1000000.00")]
      public decimal Price { get; set; }

   }
}
