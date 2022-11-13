using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class SalesAgentConfiguration : IEntityTypeConfiguration<SalesAgent>
   {
      public void Configure(EntityTypeBuilder<SalesAgent> builder)
      {
         builder.
            HasData(
            new SalesAgent()
            {
               Id = new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"),
               TelephoneNumber = "+359895081023",
               UserId = "cca4b5a6-d054-40af-9d42-6288a33cfa8e",
               ImageProfileUrl = "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg"
            },
            new SalesAgent()
            {
               Id = new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"),
               TelephoneNumber = "+420899121223",
               UserId = "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2",
               ImageProfileUrl = "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg"
            },
            new SalesAgent()
            {
               Id = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
               TelephoneNumber = "+359898443311",
               UserId = "0fcfd061-6371-4fe8-95e3-f7a33f763ea2",
               ImageProfileUrl = "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg"
            }
           
            );
      }
   }
}
