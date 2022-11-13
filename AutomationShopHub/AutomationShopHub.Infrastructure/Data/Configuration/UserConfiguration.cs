using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
   {
      public void Configure(EntityTypeBuilder<IdentityUser> builder)
      {
         builder.
            HasData(SeedUsers());
      }

      private List<IdentityUser> SeedUsers()
      {
         var users = new List<IdentityUser>();
         var hasher = new PasswordHasher<IdentityUser>();

         var salesAgentIdentityUser1 = new IdentityUser()
         {
            Id = "0fcfd061-6371-4fe8-95e3-f7a33f763ea2",
            UserName = "SalesAgent_1@mail.com",
            NormalizedUserName = "salesagent_1@mail.com",
            Email = "SalesAgent_1@mail.com",
            NormalizedEmail = "salesagent_1@mail.com"
         };
         salesAgentIdentityUser1.PasswordHash = hasher.HashPassword(salesAgentIdentityUser1, "SalesAgent_1");

         users.Add(salesAgentIdentityUser1);

         var salesAgentIdentityUser2 = new IdentityUser()
         {
            Id = "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2",
            UserName = "SalesAgent_2@mail.com",
            NormalizedUserName = "salesagent_2@mail.com",
            Email = "SalesAgent_2@mail.com",
            NormalizedEmail = "salesagent_2@mail.com"
         };
         salesAgentIdentityUser2.PasswordHash = hasher.HashPassword(salesAgentIdentityUser2, "SalesAgent_2");

         users.Add(salesAgentIdentityUser2);

         var salesAgentIdentityUser3 = new IdentityUser()
         {
            Id = "cca4b5a6-d054-40af-9d42-6288a33cfa8e",
            UserName = "SalesAgent_3@mail.com",
            NormalizedUserName = "salesagent_3@mail.com",
            Email = "SalesAgent_3@mail.com",
            NormalizedEmail = "salesagent_2@mail.com"
         };
         salesAgentIdentityUser3.PasswordHash = hasher.HashPassword(salesAgentIdentityUser3, "SalesAgent_3");

         users.Add(salesAgentIdentityUser3);      

         var clientIdentityUser1 = new IdentityUser()
         {
            Id = "49e48785-2dd4-43d8-9085-382f97dc4cf2",
            UserName = "Client_1@mail.com",
            NormalizedUserName = "client_1@mail.com",
            Email = "Client_1@mail.com",
            NormalizedEmail = "client_1@mail.com"
         };
         clientIdentityUser1.PasswordHash = hasher.HashPassword(clientIdentityUser1, "Client_1");

         users.Add(clientIdentityUser1);

         var clientIdentityUser2 = new IdentityUser()
         {
            Id = "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
            UserName = "Client_2@mail.com",
            NormalizedUserName = "client_2@mail.com",
            Email = "Client_2@mail.com",
            NormalizedEmail = "client_2@mail.com"
         };
         clientIdentityUser2.PasswordHash = hasher.HashPassword(clientIdentityUser2, "Client_2");

         users.Add(clientIdentityUser2);

         return users;
      }
   }
}
