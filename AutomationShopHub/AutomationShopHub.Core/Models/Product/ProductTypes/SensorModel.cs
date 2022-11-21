using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   public class SensorModel
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
      public bool isDiscreteType { get; set; }

      [Required]
      public bool isRangeAdjustable { get; set; }

      [Required]
      public int SensorTypeId { get; set; }

      [ForeignKey(nameof(SensorTypeId))]
      public SensorTypeModel Type { get; set; } = null!;

      [Required]
      public int CommunicationProtocolId { get; set; }

      [ForeignKey(nameof(CommunicationProtocolId))]
      public IndustrialProtocolModel Protocol { get; set; } = null!;

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
      [Range(typeof(decimal), "100.00", "10000.00")]
      public decimal Price { get; set; }

   }
}
