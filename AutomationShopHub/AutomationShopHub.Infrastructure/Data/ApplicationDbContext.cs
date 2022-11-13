using AutomationShopHub.Infrastructure.Data.Configuration;
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

      public DbSet<SalesAgent> SalesAgents { get; set; } = null!;
      public DbSet<Client> Clients { get; set; } = null!;
      public DbSet<IndustrialProtocol> IndustrialProtocols { get; set; } = null!;
      public DbSet<VisionSystem> VisionSystems { get; set; } = null!;
      public DbSet<PLC> PLCs { get; set; } = null!;
      public DbSet<SensorType> SensorTypes { get; set; } = null!;
      public DbSet<Sensor> Sensors { get; set; } = null!;
      public DbSet<RobotType> RobotTypes { get; set; } = null!;
      public DbSet<Robot> Robots { get; set; } = null!;
      public DbSet<Product> Products { get; set; } = null!;
      public DbSet<Order> Orders { get; set; } = null!;
      public DbSet<Comment> Comments { get; set; } = null!;
      public DbSet<Category> Categories { get; set; } = null!;
      public DbSet<Brand> Brands { get; set; } = null!;



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
           .HasMany(p => p.Comments)
           .WithOne()
           .OnDelete(DeleteBehavior.Restrict);

         builder.ApplyConfiguration(new UserConfiguration());
         builder.ApplyConfiguration(new SalesAgentConfiguration());
         builder.ApplyConfiguration(new ClientConfiguration());

         builder.ApplyConfiguration(new BrandConfiguration());
         builder.ApplyConfiguration(new CategoryConfiguration());
         builder.ApplyConfiguration(new IndustrialProtocolConfiguration());        
         builder.ApplyConfiguration(new RobotTypeConfiguration());
         builder.ApplyConfiguration(new SensorTypeConfiguration());

         builder.ApplyConfiguration(new ProductConfiguration());
         builder.ApplyConfiguration(new RobotConfiguration());
         builder.ApplyConfiguration(new SensorConfiguration());
         builder.ApplyConfiguration(new VisionSystemConfiguration());
         builder.ApplyConfiguration(new PLCsConfiguration());

         builder.ApplyConfiguration(new OrderConfiguration());
         builder.ApplyConfiguration(new OrderProductConfiguration());


         base.OnModelCreating(builder);
      }


   }
}