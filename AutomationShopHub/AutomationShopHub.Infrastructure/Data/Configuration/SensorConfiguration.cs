using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class SensorConfiguration : IEntityTypeConfiguration<Sensor>
   {
      public void Configure(EntityTypeBuilder<Sensor> builder)
      {
         builder.
            HasData(
            new Sensor()
            {
               Id = 1,
               ModelReference = "CQ35-25NPP-KC1",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Capacitive proximity sensors",
               ProductId = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
               CommunicationProtocolId = 1,
               SensorTypeId = 3,
               GuaranteePeriod = 6,
               Price = 240.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

            },
            new Sensor()
            {
               Id = 2,
               ModelReference = "MM12-60APS-ZCK",
               isDiscreteType = true,
               isRangeAdjustable = false,
               Description = "Magnetic proximity sensors",
               ProductId = new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
               CommunicationProtocolId = 1,
               SensorTypeId = 1,
               GuaranteePeriod = 6,
               Price = 300.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/4/54/154/dataSheet_MM12-60APS-ZCK_1040070_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/5/05/305/IM0045305.png"

            },
            new Sensor()
            {
               Id = 3,
               ModelReference = "WTT4SLC-3B0062B03",
               isDiscreteType = false,
               isRangeAdjustable = true,
               Description = "MultiTask photoelectric sensors PowerProx",
               ProductId = new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"),
               CommunicationProtocolId = 8,
               SensorTypeId = 6,
               GuaranteePeriod = 6,
               Price = 650.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/2/72/672/dataSheet_WTT4SLC-3B0062B03_1118144_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/9/29/029/IM0079029.png"

            },
            new Sensor()
            {
               Id = 4,
               ModelReference = "UC30-21516B",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Ultrasonic sensors UC30 / UC30 - 2",
               ProductId = new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"),
               CommunicationProtocolId = 8,
               SensorTypeId = 4,
               GuaranteePeriod = 6,
               Price = 620.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/4/14/214/dataSheet_UC30-21516B_6068453_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/9/89/389/IM0057389.png"

            },
            new Sensor()
            {
               Id = 5,
               ModelReference = "IMS18-08BPOVC0S",
               isDiscreteType = true,
               isRangeAdjustable = false,
               Description = "Inductive proximity sensors IMS",
               ProductId = new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"),
               CommunicationProtocolId = 1,
               SensorTypeId = 2,
               GuaranteePeriod = 6,
               Price = 120.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/2/62/962/dataSheet_IMS18-08BPOVC0S_1097646_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/4/84/984/IM0083984.png"

            },
            new Sensor()
            {
               Id = 6,
               ModelReference = "WTB4FP-21311120ZZZ",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Miniature photoelectric sensors W4F",
               ProductId = new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"),
               CommunicationProtocolId = 1,
               SensorTypeId = 6,
               GuaranteePeriod = 6,
               Price = 280.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/1/51/151/dataSheet_WTB4FP-21311120ZZZ_1222999_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/7/07/707/IM0085707.png"

            },
            new Sensor()
            {
               Id = 7,
               ModelReference = "CSM-WP117A2P",
               isDiscreteType = false,
               isRangeAdjustable = true,
               Description = "Color sensors CSM",
               ProductId = new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"),
               CommunicationProtocolId = 8,
               SensorTypeId = 5,
               GuaranteePeriod = 6,
               Price = 400.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/4/44/444/dataSheet_CSM-WP117A2P_1067294_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/6/76/576/IM0100576.png"

            },
            new Sensor()
            {
               Id = 8,
               ModelReference = "IGK4008A2PKG/IO/US",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "inductive analogue sensor with IO-Link IG6084",
               ProductId = new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"),
               CommunicationProtocolId = 8,
               SensorTypeId = 2,
               GuaranteePeriod = 3,
               Price = 180.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/IG6084",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/4106e7f09ede1947bfdf514d1b76d2d1/-B900-FJPG/IG6084"

            },
            new Sensor()
            {
               Id = 9,
               ModelReference = "KQ-3120NFPKG",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Capacitive sensor KQ5100",
               ProductId = new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"),
               CommunicationProtocolId = 8,
               SensorTypeId = 3,
               GuaranteePeriod = 3,
               Price = 180.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/KQ5100",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/776a84cc38f1934ab331d7c520ed465c/-B900-FJPG/KQ5100"

            },
            new Sensor()
            {
               Id = 10,
               ModelReference = "UGQ00300EOKG/IO-Link/US",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Ultrasonic sensor UGT592",
               ProductId = new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"),
               CommunicationProtocolId = 8,
               SensorTypeId = 4,
               GuaranteePeriod = 3,
               Price = 280.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/UGT592?tab=details",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/3644e93c9899f449b727942f5853a10f/-B900-FJPG/UGT592"

            },
            new Sensor()
            {
               Id = 11,
               ModelReference = "MKT3028BBPOG/G/0,3M/ZH/AS",
               isDiscreteType = true,
               isRangeAdjustable = false,
               Description = "T-slot cylinder sensor MK5101",
               ProductId = new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"),
               CommunicationProtocolId = 1,
               SensorTypeId = 1,
               GuaranteePeriod = 3,
               Price = 120.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/MK5101?tab=details",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/079d1e50e71c7a44bf90b5c400347406/-B900-FJPG/MK5101"

            },
            new Sensor()
            {
               Id = 12,
               ModelReference = "O4H-FPKG/US100",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Diffuse reflection sensor with background suppression O4H500",
               ProductId = new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"),
               CommunicationProtocolId = 1,
               SensorTypeId = 6,
               GuaranteePeriod = 3,
               Price = 260.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/O4H500?tab=details",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/5098372aa1fa4349ad3e0d8b38514a65/-B900-FJPG/O4H500"

            },
            new Sensor()
            {
               Id = 13,
               ModelReference = "OGH-FPKG/US/CUBE",
               isDiscreteType = false,
               isRangeAdjustable = true,
               Description = "Diffuse reflection sensor with background suppression OGH580",
               ProductId = new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"),
               CommunicationProtocolId = 8,
               SensorTypeId = 5,
               GuaranteePeriod = 3,
               Price = 350.00M,
               DatasheetUrl = "https://www.ifm.com/de/en/product/OGH580?tab=details",
               ImageUrl = "https://media.ifm.com/CIP/mediadelivery/rendition/cd00bcfcb62fbe47924f6772ad77f4dc/-B900-FJPG/OGH580"

            }

            );
      }
   }
}
