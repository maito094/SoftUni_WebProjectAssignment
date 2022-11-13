using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class RobotTypeConfiguration : IEntityTypeConfiguration<RobotType>
   {
      public void Configure(EntityTypeBuilder<RobotType> builder)
      {
         builder.
            HasData(
            new RobotType()
            {
               Id=1,
               Name="Cobot",
            },
            new RobotType()
            {
               Id=2,
               Name="Delta",
            },
            new RobotType()
            {
               Id=3,
               Name="SCARA",
            },
            new RobotType()
            {
               Id=4,
               Name="6-Axis",
            }
            );
      }
   }
}
