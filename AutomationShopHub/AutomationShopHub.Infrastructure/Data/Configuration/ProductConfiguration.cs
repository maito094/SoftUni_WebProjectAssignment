using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class ProductConfiguration : IEntityTypeConfiguration<Product>
   {
      public void Configure(EntityTypeBuilder<Product> builder)
      {
         builder.
            HasData(
            new Product()
            {
               Id = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
               Name = "RV-5AS-D",
               ProductDateAdded = DateTime.Now.AddDays(13),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
               Name = "RV-4FRL",
               ProductDateAdded = DateTime.Now.AddMonths(-3),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"),
               Name = "RH-12FRH",
               ProductDateAdded = DateTime.Now.AddDays(-15),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"),
               Name = "CR-4iA",
               ProductDateAdded = DateTime.Now.AddDays(2),
               BrandId = 3,
               CategoryId = 1,
               Description = "This is a FANUC Corp. Robot",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"),
               Name = "LR Mate 200iD/7L",
               ProductDateAdded = DateTime.Now.AddDays(12),
               BrandId = 3,
               CategoryId = 1,
               Description = "This is a FANUC Corp. Robot",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
               Name = "M-3iA/6A",
               ProductDateAdded = DateTime.Now.AddDays(-2),
               BrandId = 3,
               CategoryId = 1,
               Description = "This is a FANUC Corp. Robot",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"),
               Name = "M-3iA/6S",
               ProductDateAdded = DateTime.Now.AddDays(-22),
               BrandId = 3,
               CategoryId = 1,
               Description = "This is a FANUC Corp. Robot",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
               Name = "CQ35-25NPP-KC1",
               ProductDateAdded = DateTime.Now.AddDays(-7),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
               Name = "MM12-60APS-ZCK",
               ProductDateAdded = DateTime.Now.AddDays(-17),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"),
               Name = "WTT4SLC-3B0062B03",
               ProductDateAdded = DateTime.Now.AddDays(13),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"),
               Name= "UC30-21516B",
               ProductDateAdded = DateTime.Now.AddDays(-5),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),

            },
            new Product()
            {
               Id = new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"),
               Name = "IMS18-08BPOVC0S",
               ProductDateAdded = DateTime.Now.AddDays(-2),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),

            },
            new Product()
            {
               Id = new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"),
               Name = "WTB4FP-21311120ZZZ",
               ProductDateAdded = DateTime.Now.AddDays(-8),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is a SICK automation product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),

            },
            new Product()
            {
               Id = new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"),
               Name = "CSM-WP117A2P",
               ProductDateAdded = DateTime.Now.AddMonths(-3),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"),
               Name = "IGK4008A2PKG/IO/US",
               ProductDateAdded = DateTime.Now.AddMonths(-2),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"),
               Name = "KQ-3120NFPKG",
               ProductDateAdded = DateTime.Now.AddMonths(-1),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"),
               Name = "UGQ00300EOKG/IO-Link/US",
               ProductDateAdded = DateTime.Now.AddMonths(-2).AddDays(2),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"),
               Name = "MKT3028BBPOG/G/0,3M/ZH/AS",
               ProductDateAdded = DateTime.Now.AddDays(-21),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"),
               Name = "O4H-FPKG/US100",
               ProductDateAdded = DateTime.Now.AddMonths(-2).AddDays(22),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"),
               Name = "OGH-FPKG/US/CUBE",
               ProductDateAdded = DateTime.Now.AddMonths(-2).AddDays(7),
               BrandId = 11,
               CategoryId = 3,
               Description = "This is an IFM Electronics product sensor",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"),
               Name = "MELSEC-Q25PRHCPU",
               ProductDateAdded = DateTime.Now.AddMonths(-5).AddDays(2),
               BrandId = 1,
               CategoryId = 2,
               Description = "This is a Mitsubishi Electrics product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("21585ca4-fb50-46ab-a840-f985e1594856"),
               Name = "MELSEC iQ-F FX5U",
               ProductDateAdded = DateTime.Now.AddMonths(-6).AddDays(7),
               BrandId = 1,
               CategoryId = 2,
               Description = "This is a Mitsubishi Electrics product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"),
               Name = "MELSEC iQ-R-R120PCPU",
               ProductDateAdded = DateTime.Now.AddMonths(-3).AddDays(17),
               BrandId = 1,
               CategoryId = 2,
               Description = "This is a Mitsubishi Electrics product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"),
               Name = "SIMATIC S7-400",
               ProductDateAdded = DateTime.Now.AddMonths(-1).AddDays(7),
               BrandId = 7,
               CategoryId = 2,
               Description = "This is a Siemens product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),

            },
            new Product()
            {
               Id = new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"),
               Name = "SIMATIC S7-1200",
               ProductDateAdded = DateTime.Now.AddMonths(-5).AddDays(12),
               BrandId = 7,
               CategoryId = 2,
               Description = "This is a Siemens product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),

            },
            new Product()
            {
               Id = new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"),
               Name = "C6915-0020",
               ProductDateAdded = DateTime.Now.AddMonths(-4).AddDays(1),
               BrandId = 5,
               CategoryId = 2,
               Description = "This is a Beckhoff product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
               Name = "CP6501-0001-0090",
               ProductDateAdded = DateTime.Now.AddMonths(-4).AddDays(9),
               BrandId = 5,
               CategoryId = 2,
               Description = "This is a Beckhoff product PLCs",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
               Name = "IV-H500CA",
               ProductDateAdded = DateTime.Now.AddMonths(-2).AddDays(7),
               BrandId = 15,
               CategoryId = 4,
               Description = "This is a Keyence product Vision System",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
               Name = "IV-HG500CA",
               ProductDateAdded = DateTime.Now.AddMonths(0).AddDays(7),
               BrandId = 15,
               CategoryId = 4,
               Description = "This is a Keyence product Vision System",
               isDeleted = false,
               SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),

            },
            new Product()
            {
               Id = new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"),
               Name = "is-2000-130",
               ProductDateAdded = DateTime.Now.AddMonths(-3).AddDays(27),
               BrandId = 16,
               CategoryId = 4,
               Description = "This is a Cognex product Vision System",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
            new Product()
            {
               Id = new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"),
               Name = "is-9912",
               ProductDateAdded = DateTime.Now.AddMonths(-2).AddDays(13),
               BrandId = 16,
               CategoryId = 4,
               Description = "This is a Cognex product Vision System",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            }


            );
      }
   }
}
