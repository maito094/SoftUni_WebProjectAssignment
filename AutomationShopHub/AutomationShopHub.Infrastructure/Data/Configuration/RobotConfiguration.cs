using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class RobotConfiguration : IEntityTypeConfiguration<Robot>
   {
      public void Configure(EntityTypeBuilder<Robot> builder)
      {
         builder.
            HasData(
            new Robot()
            {
               Id = 1,
               ModelReference = "RV-5AS-D",
               RobotTypeId = 1,
               NumberOfAxis = 6,
               Reach = 910.00M,
               Speed = 250.00M,
               Payload = 5M,
               CommunicationProtocolId = 6,
               ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
               GuaranteePeriod = 12,
               Price = 36000.00M,
               Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
               DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
               ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

            },
            new Robot()
            {
               Id = 2,
               ModelReference = "RV-4FRL",
               RobotTypeId = 4,
               NumberOfAxis = 6,
               Reach = 649.00M,
               Speed = 9048.00M,
               Payload = 4M,
               CommunicationProtocolId = 6,
               ProductId = new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
               GuaranteePeriod = 12,
               Price = 24000.00M,
               Description = "Industrial Robot RV-4FR-D 6-axis; +/- 0,02mm; 4kg; 649mm; IP40; incl. CR800 \n The Mitsubishi RV-4FRL robot is a 6-axis robot arm, it offers a 4.0 kg payload and 649 mm reach. The repeatability of the Mitsubishi RV-4FRL robot is 0.02 mm.\n Common applications of the Mitsubishi RV-4FRL robot include: arc welding, dispensing, remote tcp, and spot welding.",
               DatasheetUrl = "https://eu-assets.contentstack.com/v3/assets/blt5412ff9af9aef77f/blta5c4b84935903df0/62e796f9ccb3425e80d74d81/bfp-a3470t.pdf",
               ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/bltfab71d6a3325a818/617426bdb04cff6af9e6afb0/313088.jpg?fit=bounds&width=280&height=280"

            },
             new Robot()
             {
                Id = 3,
                ModelReference = "RH-12FRH",
                RobotTypeId = 3,
                NumberOfAxis = 4,
                Reach = 700.00M,
                Speed = 9048.00M,
                Payload = 12M,
                CommunicationProtocolId = 6,
                ProductId = new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"),
                GuaranteePeriod = 12,
                Price = 22000.00M,
                Description = "Industrial Robot RH-12FRH-D 4-axis; +/- 0,015mm; 12kg; 850/350mm; incl. CR800 \n The RH-FR series allows for fast palletizing, targeted re-sort, perfect fit: and all of this in record time.\n \"Next-generation intelligent functions\", \"Safe, collaborative work applications\", and \"FA-IT integration functions\".With these 3 key features, the FR Series is capable of handling virtually all your automation needs",
                DatasheetUrl = "https://eu-assets.contentstack.com/v3/assets/blt5412ff9af9aef77f/bltf2e83af069f9e12a/62e796d911ef5d6c4b64da8a/bfp-a3468t.pdf",
                ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt30a436c112f0dcc1/617427ea99d38b0f5a497792/313672.jpg?fit=bounds&width=280&height=280"

             },
             new Robot()
             {
                Id = 4,
                ModelReference = "CR-4iA",
                RobotTypeId = 1,
                NumberOfAxis = 6,
                Reach = 550.00M,
                Speed = 1000.00M,
                Payload = 4M,
                CommunicationProtocolId = 5,
                GuaranteePeriod = 12,
                ProductId = new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"),
                Price = 18000.00M,
                Description = "Hi, I am the smallest of the collaborative robot range, with six axis in my arm, and my maximum payload is 4kg. Similar to my fellow collaborative robots, I handle lightweight tasks that are tedious, highly manual. My compact nature enables me to perform smaller jobs in areas with limited space requirements. It is possible for me to be wall- or invert-mounted, offering me a wider range of motion without interfering with the operator’s workspace.",
                DatasheetUrl = "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/collaborative%20robots/datasheet-cr4ia-en.pdf?la=en",
                ImageUrl = "https://www.fanuc.eu/~/media/corporate/products/robots/collaborative/cr4ia/400x400/pr-whitebg-cr4ia.jpg?w=280"

             },
             new Robot()
             {
                Id = 5,
                ModelReference = "LR Mate 200iD/7L",
                RobotTypeId = 4,
                NumberOfAxis = 6,
                Reach = 911.00M,
                Speed = 1200.00M,
                Payload = 7M,
                CommunicationProtocolId = 5,
                GuaranteePeriod = 12,
                ProductId = new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"),
                Price = 18000.00M,
                Description = "Fast at handling small payloads, this compact multi-purpose industrial robot offers an enhanced reach. Like all LR Mate robots, it is also available with a range of options including integrated intelligent (vision & force) functionality, special application packages and standard IP67 protection.",
                DatasheetUrl = "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/lr-mate/datasheet%20lrmate-200id-7l.pdf?la=en",
                ImageUrl = "https://www.fanuc.eu/~/media/corporate/products/robots/lrmate/generic/400x600/int-ro-pr-lrm2007l-l-1.jpg?w=280"

             },
             new Robot()
             {
                Id = 6,
                ModelReference = "M-3iA/6A",
                RobotTypeId = 2,
                NumberOfAxis = 6,
                Reach = 1350.00M,
                Speed = 2400.00M,
                Payload = 6M,
                CommunicationProtocolId = 5,
                GuaranteePeriod = 12,
                ProductId = new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
                Price = 22000.00M,
                Description = "This high-speed 6-axis robot is perfect for picking, packaging and assembly. Its 3-axis wrist means it is capable of freely rotating workpieces and tools as required for assembly applications. Its clever design also means it makes best use of available workspace.",
                DatasheetUrl = "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/m-3ia/datasheet%20m-3ia-6a.pdf?la=en",
                ImageUrl = "https://www.fanuc.eu/~/media/corporate/products/robots/delta/m3/generic/400x600/int-ro-pr-m36a-1.jpg?w=280"

             }
             ,
             new Robot()
             {
                Id = 7,
                ModelReference = "M-3iA/6S",
                RobotTypeId = 2,
                NumberOfAxis = 4,
                Reach = 1350.00M,
                Speed = 2400.00M,
                Payload = 6M,
                CommunicationProtocolId = 5,
                GuaranteePeriod = 12,
                ProductId = new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"),
                Price = 18000.00M,
                Description = "Fittted with powerful servomotors for high acceleration and short cycle times, this model is ideal for high speed picking operations. Its four axes and high-speed single axis wrist provide increased dexterity, while its long reach makes it ideal for picking applications across multiple conveyors.",
                DatasheetUrl = "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/m-3ia/datasheet%20m-3ia-6s.pdf?la=en",
                ImageUrl = "https://www.fanuc.eu/~/media/corporate/products/robots/delta/m3/generic/400x600/int-ro-pr-m36s-1.jpg?w=280"

             }
            );
      }
   }
}
