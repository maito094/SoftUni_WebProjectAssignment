using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Entities.ProductTypes
{
   public class VisionSystem
   {
      [Key]
      public int Id { get; set; }

      [Required]
      public Guid ProductId { get; set; }

      [ForeignKey(nameof(ProductId))]
      public Product Product { get; set; } = null!;

      [Required]
      [StringLength(30)]
      public string ModelReference { get; set; } = null!;

      [Required]
      public bool hasBuiltInController { get; set; }
      
      [Required]
      public bool hasBuiltInLight { get; set; }
      
      [Required]
      public bool hasBuiltInLens { get; set; }

      [Required]
      public int CommunicationProtocolId { get; set; }

      [ForeignKey(nameof(CommunicationProtocolId))]
      public IndustrialProtocol Protocol { get; set; } = null!;

      [Required]
      [StringLength(1000)]
      public string Description { get; set; } = null!;

      [Required]
      public int GuaranteePeriod { get; set; }

      [Required]
      public string ImageUrl { get; set; } = null!;

      [Required]
      public string DatasheetUrl { get; set; } = null!;

      [Required]
      [Range(typeof(decimal), "1000.00", "50000.00")]
      public decimal Price { get; set; }

   }
}
