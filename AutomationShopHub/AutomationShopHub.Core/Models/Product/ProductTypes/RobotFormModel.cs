using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models.Product.ProductTypes
{
    public class RobotFormModel
    {


      [Required]
      [StringLength(30)]
      [Display(Name = "Model Reference")]
      public string ModelReference { get; set; } = null!;

      [Required]
      [Range(typeof(int), "3", "6")]
      [Display(Name = "Number of Axis")]
      public int NumberOfAxis { get; set; }

      [Required]
      [Range(typeof(decimal), "10.00", "30000.00")]
      public decimal Speed { get; set; }

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
      [Display(Name = "Guarantee period")]
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

      [Required]
      [Display(Name ="Robot Type")]
      public int RobotTypeId { get; set; }
      public IEnumerable<RobotTypeModel> RobotTypes { get; set; } = new List<RobotTypeModel>();

      [Required]
      [Display(Name = "Protocol Type")]
      public int CommunicationProtocolId { get; set; }
      public IEnumerable<IndustrialProtocolModel> IndustrialProtocols { get; set; } = new List<IndustrialProtocolModel>();
   }
}
