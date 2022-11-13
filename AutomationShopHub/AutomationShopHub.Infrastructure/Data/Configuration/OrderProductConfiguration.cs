using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
   {
      public void Configure(EntityTypeBuilder<OrderProduct> builder)
      {
         builder.
            HasData(
            new OrderProduct()
            {
               OrderId=new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
               ProductId=new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
            },
            new OrderProduct()
            {
               OrderId = new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
               ProductId = new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
            },
            new OrderProduct()
            {
               OrderId = new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
               ProductId = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
            },
            new OrderProduct()
            {
               OrderId = new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
               ProductId = new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
            },
            new OrderProduct()
            {
               OrderId = new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
               ProductId = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
            }
            );
            
      }
   }
}
