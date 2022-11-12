using AutomationShopHub.Infrastructure.Data.Entities;
using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutomationShopHub.Infrastructure.Data
{
   public class ApplicationDbContext : IdentityDbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }

      public DbSet<SalesAgent> SalesAgents { get; set; }
      public DbSet<Client> Clients { get; set; }
      public DbSet<IndustrialProtocol> IndustrialProtocols { get; set; }
      public DbSet<VisionSystem> VisionSystems { get; set; }
      public DbSet<PLC> PLCs { get; set; }
      public DbSet<SensorType> SensorTypes { get; set; }
      public DbSet<Sensor> Sensors { get; set; }
      public DbSet<RobotType> RobotTypes { get; set; }
      public DbSet<Robot> Robots { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<Comment> Comments { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<Brand> Brands { get; set; }



      protected override void OnModelCreating(ModelBuilder builder)
      {

         builder.Entity<OrderProduct>()
            .HasKey(x => new { x.OrderId, x.ProductId });


         builder.Entity<Order>()
            .HasMany(o => o.OrderProducts)
            .WithOne(o => o.Order)
            .HasForeignKey(o => o.OrderId);

         builder.Entity<Client>()
            .HasMany(o => o.Orders)
            .WithOne(c => c.Client)
            .OnDelete(DeleteBehavior.Restrict);
         
         builder.Entity<SalesAgent>()
            .HasMany(o => o.Orders)
            .WithOne(s => s.SalesAgent)
            .OnDelete(DeleteBehavior.Restrict);

          builder.Entity<Product>()
            .HasMany(p=>p.Comments)
            .WithOne()
            .OnDelete(DeleteBehavior.Restrict);




         base.OnModelCreating(builder);
      }


   }
}