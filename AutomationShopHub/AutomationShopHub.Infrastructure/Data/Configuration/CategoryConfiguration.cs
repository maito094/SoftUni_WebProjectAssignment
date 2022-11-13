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
          Name = "Robots",
          Description= "Type of automated machine that can execute specific tasks with little or no human intervention and with speed and precision. A robot is a machine—especially one programmable by a computer—capable of carrying out a complex series of actions automatically. A robot can be guided by an external control device, or the control may be embedded within."

       },
       new Category()
       {
          Id = 2,
          Name = "PLCs",
          Description = "A programmable logic controller or programmable controller is an industrial computer that has been ruggedized and adapted for the control of manufacturing processes, such as assembly lines, machines, robotic devices, or any activity that requires high reliability, ease of programming, and process fault diagnosis."
       },
       new Category()
       {
          Id = 3,
          Name = "Sensors",
          Description = "Detect and measure some physical effect, providing this information to the control system."
       },
       new Category()
       {
          Id = 4,
          Name = "VisionSystem",
          Description = "Also known as Machinve Vision. Machine vision (MV) is the technology and methods used to provide imaging-based automatic inspection and analysis for such applications as automatic inspection, process control, and robot guidance, usually in industry. Machine vision refers to many technologies, software and hardware products, integrated systems, actions, methods and expertise."
       });

      }
   }
}
