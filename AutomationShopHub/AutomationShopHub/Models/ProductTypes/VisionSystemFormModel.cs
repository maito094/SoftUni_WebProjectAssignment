using AutomationShopHub.Core.Models.Product.ProductTypes;
using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Models.ProductTypes
{
    public class VisionSystemFormModel
    {
        [Required]
        [StringLength(30)]
        [Display(Name = "Model Reference")]

        public string ModelReference { get; set; } = null!;

        [Required]
        public bool hasBuiltInController { get; set; }

        [Required]
        public bool hasBuiltInLight { get; set; }

        [Required]
        public bool hasBuiltInLens { get; set; }

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
        [Range(typeof(decimal), "1000.00", "50000.00")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Protocol Type")]
        public int CommunicationProtocolId { get; set; }
        public IEnumerable<IndustrialProtocolModel> IndustrialProtocols { get; set; } = new List<IndustrialProtocolModel>();
    }
}
