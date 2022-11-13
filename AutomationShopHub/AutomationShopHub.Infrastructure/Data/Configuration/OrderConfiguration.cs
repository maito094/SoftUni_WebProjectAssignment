using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class OrderConfiguration : IEntityTypeConfiguration<Order>
   {
      public void Configure(EntityTypeBuilder<Order> builder)
      {
         builder.
            HasData(
            new Order()
            {
               Id = new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
               ClientId=new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
               SalesAgentId=new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
               DeliveryAddress= "Sofia \"Opalchenska\" Str. 105",
               OrderDateCreated=DateTime.Now.AddDays(-4),
               TotalAmount= 36000.00M,
               isDeleted=false
            },
             new Order()
             {
                Id = new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
                ClientId = new Guid("8bd3a0a0-00b2-4478-b29e-3203caed4a90"),
                SalesAgentId = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),
                DeliveryAddress = "Plovdiv \"Bulgaria\" Blvd. 42",
                OrderDateCreated = DateTime.Now.AddDays(5),
                TotalAmount = 22000.00M,
                isDeleted = false
             }
            );
      }
   }
}
