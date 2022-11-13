using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class VisionSystemConfiguration : IEntityTypeConfiguration<VisionSystem>
   {
      public void Configure(EntityTypeBuilder<VisionSystem> builder)
      {
         builder.
            HasData(
            new VisionSystem()
            {
               Id = 1,
               ModelReference = "IV-H500CA",
               hasBuiltInController = true,
               hasBuiltInLens = true,
               hasBuiltInLight = true,
               Description = "Standard, Color, Automatic focus model IV - H500CA",
               ProductId = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 5000.00M,
               DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
               ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
            },
            new VisionSystem()
            {
               Id = 2,
               ModelReference = "IV-HG500CA",
               hasBuiltInController = false,
               hasBuiltInLens = true,
               hasBuiltInLight = true,
               Description = "Sensor Head, Standard, Color, Automatic focus model IV-HG500CA",
               ProductId = new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 3000.00M,
               DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_24HG5CA&downloadZipFlag=0",
               ImageUrl = "https://www.keyence.com/img/products/model/AS_68875_L.jpg"
            },
            new VisionSystem()
            {
               Id = 3,
               ModelReference = "is-2000-130",
               hasBuiltInController = true,
               hasBuiltInLens = true,
               hasBuiltInLight = true,
               Description = "Cognex In-Sight 2000 vision sensors combine the power of In-Sight vision systems with the simplicity and affordability of an industrial sensor.",
               ProductId = new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 3800.00M,
               DatasheetUrl = "https://www.manualslib.com/manual/1620089/Cognex-In-Sight-2000-Mini-Poe-Series.html#product-In-Sight%202000",
               ImageUrl = "https://www.cognex.com/library/media/products/in-sight-2000-vision-sensors/is2000-and-is2000-mini-cta.png?sc_lang=en-bg"
            },
            new VisionSystem()
            {
               Id = 4,
               ModelReference = "is-9912",
               hasBuiltInController = true,
               hasBuiltInLens = false,
               hasBuiltInLight = false,
               Description = "The In-Sight 9000 is a rugged, ultra-high-resolution line of standalone vision systems. With its ability to acquire and process exceptionally detailed images, the In-Sight 9000 delivers high accuracy part location, measurement, and inspection over a large area—even when mounted at longer distances.",
               ProductId = new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 18000.00M,
               DatasheetUrl = "https://www.manualslib.com/manual/2005617/Cognex-9000-Seriein-Sights.html",
               ImageUrl = "https://www.cognex.com/library/media/products/in-sight-9000/is9000-cta.jpg?sc_lang=en-bg"
            }


            );
      }
   }
}
