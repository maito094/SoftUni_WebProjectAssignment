using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
   {
      public void Configure(EntityTypeBuilder<Comment> builder)
      {
         builder.
            HasData(

             new Comment()
             {
                Id=new Guid("978c72d3-f4ff-4ace-bbd2-69110d153bea"),
                Content="Excellent product!",
                UserId= "49e48785-2dd4-43d8-9085-382f97dc4cf2",
                ReplyId=new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1")

             },
             new Comment()
             {
                Id=new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1"),
                Content="It is indeed!",
                UserId= "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
                

             },
             new Comment()
             {
                Id=new Guid("f7cd96d0-90a5-4d09-b05c-2bb5a92023e6"),
                Content="What would be the delivery date for this?",
                UserId= "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
                
             },
             new Comment()
             {
               Id = new Guid("dfb02da2-d26f-4658-b5da-22cf4521215d"),
               Content = "Is there any discount for a certain price point or quantity?",
               UserId = "49e48785-2dd4-43d8-9085-382f97dc4cf2"

             }


            );
      }
   }
}
