using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Entities.ProductTypes
{
   public class PLC
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
      [Range(typeof(int), "0", "16383")]
      public int MaxInputsOutputs { get; set; }

      /// <summary>
      /// ScanTime is the time of PLC scan cycle. The lower the better. Measured in milliseconds.
      /// </summary>
      [Required]
      [Range(typeof(decimal), "0.001", "100")]
      public decimal ScanTime { get; set; }

      [Required]
      public int CommunicationProtocolId { get; set; }

      [ForeignKey(nameof(CommunicationProtocolId))]
      public IndustrialProtocol Protocol { get; set; } = null!;

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
      [Range(typeof(decimal), "500.00", "10000.00")]
      public decimal Price { get; set; }
   }
}
