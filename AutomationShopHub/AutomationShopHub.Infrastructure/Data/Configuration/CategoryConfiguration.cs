using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
   {

      public void Configure(EntityTypeBuilder<Category> builder)
      {
         builder
       .HasData(new Category()
       {
          Id = 1,
          Name = "Robots"
       },
       new Category()
       {
          Id = 2,
          Name = "PLCs"
       },
       new Category()
       {
          Id = 3,
          Name = "Sensors"
       },
       new Category()
       {
          Id = 4,
          Name = "VisionSystem"
       });

      }
   }
}
