using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class SensorTypeConfiguration : IEntityTypeConfiguration<SensorType>
   {
      public void Configure(EntityTypeBuilder<SensorType> builder)
      {
         builder.HasData(
            new SensorType()
            {
               Id=1,
               Name="Magnetic"
            },
            new SensorType()
            {
               Id=2,
               Name="Inductive"
            },
            new SensorType()
            {
               Id=3,
               Name="Capacitive"
            },
            new SensorType()
            {
               Id=4,
               Name="Resistive"
            },
            new SensorType()
            {
               Id=5,
               Name="Optical"
            },
            new SensorType()
            {
               Id=6,
               Name="Laser"
            }
            );
      }
   }
}
