using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class ClientConfiguration : IEntityTypeConfiguration<Client>
   {
      public void Configure(EntityTypeBuilder<Client> builder)
      {
         builder.
            HasData(

            new Client()
            {
               Id = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
               UserId = "49e48785-2dd4-43d8-9085-382f97dc4cf2",
               DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
               TelephoneNumber = "+359888123123",
               ImageProfileUrl = "https://www.kindpng.com/picc/m/153-1530388_mario-head-png-png-download-people-profile-pic.png"
            },
            new Client()
            {
               Id = new Guid("8bd3a0a0-00b2-4478-b29e-3203caed4a90"),
               UserId = "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
               DeliveryAddress = "Plovdiv \"Bulgaria\" Blvd. 42",
               TelephoneNumber = "+359888989898",
               ImageProfileUrl = "https://www.kindpng.com/picc/m/153-1530388_mario-head-png-png-download-people-profile-pic.png"
            }

            );
      }
   }
}
