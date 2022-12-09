using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
   public class SensorFormModel
   {
      [Required]
      [StringLength(30)]
      [Display(Name = "Model Reference")]
      public string ModelReference { get; set; } = null!;

      [Required]
      [Display(Name = "Discrete Type")]
      public bool isDiscreteType { get; set; }

      [Required]
      [Display(Name = "Range adjustable")]
      public bool isRangeAdjustable { get; set; }

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
      [Range(typeof(decimal), "100.00", "10000.00")]
      public decimal Price { get; set; }

      [Required]
      [Display(Name = "Sensor Type")]
      public int SensorTypeId { get; set; }
      public IEnumerable<SensorTypeModel> SensorTypes { get; set; } = new List<SensorTypeModel>();

      [Required]
      [Display(Name = "Protocol Type")]
      public int CommunicationProtocolId { get; set; }
      public IEnumerable<IndustrialProtocolModel> IndustrialProtocols { get; set; } = new List<IndustrialProtocolModel>();
   }
}
