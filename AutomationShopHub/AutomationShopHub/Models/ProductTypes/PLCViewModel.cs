using AutomationShopHub.Core.Models.Product.ProductTypes;
using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Models.ProductTypes
{
    public class PLCViewModel
    {
      public string ModelReference { get; set; } = null!;

      public int MaxInputsOutputs { get; set; }

      /// <summary>
      /// ScanTime is the time of PLC scan cycle. The lower the better. Measured in milliseconds.
      /// </summary>
      public decimal ScanTime { get; set; }

      public string Protocol { get; set; } = null!;

      public string Description { get; set; } = null!;

      public int GuaranteePeriod { get; set; }

      public string ImageUrl { get; set; } = null!;

      public string DatasheetUrl { get; set; } = null!;

      public decimal Price { get; set; }
   }
}
