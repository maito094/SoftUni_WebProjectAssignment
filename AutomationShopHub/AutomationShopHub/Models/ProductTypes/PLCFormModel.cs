using AutomationShopHub.Core.Models.Product.ProductTypes;
using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Models.ProductTypes
{
   public class PLCFormModel
    {

      public Guid productId { get; set; }


      [Required]
      [StringLength(30)]
      [Display(Name = "Model Reference")]

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
      [StringLength(1000)]
      public string Description { get; set; } = null!;

      [Required]
      [Range(typeof(int), "1", "60")]
      [Display(Name = "Guarantee period")]

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


      [Required]
      [Display(Name = "Protocol Type")]
      public int CommunicationProtocolId { get; set; }
      public IEnumerable<IndustrialProtocolModel> IndustrialProtocols { get; set; } = new List<IndustrialProtocolModel>();
   }
}
