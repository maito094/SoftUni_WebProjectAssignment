using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Services;
using AutomationShopHub.Infrastructure.Data;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace AutomationShopHub.UnitTests
{
   [TestFixture]

   public class OrderServiceTests
   {


      private IRepository repo;
      private IProductService productService;
      private IOrderService orderService;
      private ApplicationDbContext applicationDbContext;


      [SetUp]
      public void Setup()
      {
         var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("ProductDb")
            .Options;

         applicationDbContext = new ApplicationDbContext(contextOptions);

         applicationDbContext.Database.EnsureDeleted();
         applicationDbContext.Database.EnsureCreated();

      }


      [Test]
      public async Task TestIsOrderedByClientWithId()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);

         var mockOrder =
                       new Order()
                       {
                          Id = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                          ClientId = new Guid("db6835cf-47d6-4b65-b419-0596b140e29b"),
                          SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
                          DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
                          OrderDateCreated = DateTime.Now.AddDays(-4),
                          TotalAmount = 36000.00M,
                          isDeleted = false,
                          isConfirmed = false
                       };

         var mockOrderProduct =
                        new OrderProduct()
                        {
                           OrderId = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                           ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                        };

         await repo.AddAsync<Order>(mockOrder);
         await repo.AddAsync<OrderProduct>(mockOrderProduct);
         await repo.SaveChangesAsync();


         var isOrdered = await orderService.isOrderedByClientWithId(
            mockOrder.ClientId,
            mockOrderProduct.ProductId,
            "6646843b-ca65-4b00-a052-b0727e03d6ad");

         Assert.True(isOrdered);


      }


      [Test]
      public async Task TestIsOrderedByClientWithId_OrderIdIsNull()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);

         var mockOrder =
                       new Order()
                       {
                          Id = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                          ClientId = new Guid("db6835cf-47d6-4b65-b419-0596b140e29b"),
                          SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
                          DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
                          OrderDateCreated = DateTime.Now.AddDays(-4),
                          TotalAmount = 36000.00M,
                          isDeleted = false,
                          isConfirmed = false
                       };

         var mockOrderProduct =
                        new OrderProduct()
                        {
                           OrderId = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                           ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                        };

         await repo.AddAsync<Order>(mockOrder);
         await repo.AddAsync<OrderProduct>(mockOrderProduct);
         await repo.SaveChangesAsync();


         var isOrdered = await orderService.isOrderedByClientWithId(
            mockOrder.ClientId,
            mockOrderProduct.ProductId);

         Assert.False(isOrdered);


      }


      [Test]
      public async Task TestIsOrderedByClientWithId_OrderIsNull()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);

         var mockOrder =
                       new Order()
                       {
                          Id = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                          ClientId = new Guid("db6835cf-47d6-4b65-b419-0596b140e29b"),
                          SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
                          DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
                          OrderDateCreated = DateTime.Now.AddDays(-4),
                          TotalAmount = 36000.00M,
                          isDeleted = false,
                          isConfirmed = false
                       };

         var mockOrderProduct =
                        new OrderProduct()
                        {
                           OrderId = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                           ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                        };

         await repo.AddAsync<Order>(mockOrder);
         await repo.AddAsync<OrderProduct>(mockOrderProduct);
         await repo.SaveChangesAsync();


         Assert.ThrowsAsync<NullReferenceException>(() => orderService.isOrderedByClientWithId(
            mockOrder.ClientId,
            mockOrderProduct.ProductId,
            "403889bc-c7ec-455f-af18-fe64fbf58240"));


      }

      [Test]
      public async Task TestIsOrderedByClientWithId_IncorrectClient()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);

         var mockOrder =
                       new Order()
                       {
                          Id = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                          ClientId = new Guid("db6835cf-47d6-4b65-b419-0596b140e29b"),
                          SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
                          DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
                          OrderDateCreated = DateTime.Now.AddDays(-4),
                          TotalAmount = 36000.00M,
                          isDeleted = false,
                          isConfirmed = false
                       };

         var mockOrderProduct =
                        new OrderProduct()
                        {
                           OrderId = new Guid("6646843b-ca65-4b00-a052-b0727e03d6ad"),
                           ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                        };

         await repo.AddAsync<Order>(mockOrder);
         await repo.AddAsync<OrderProduct>(mockOrderProduct);
         await repo.SaveChangesAsync();


         Assert.ThrowsAsync<ArgumentException>(() => orderService.isOrderedByClientWithId(
            new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            mockOrderProduct.ProductId,
            "6646843b-ca65-4b00-a052-b0727e03d6ad"));


      }


      [Test]
      public async Task TestOrderProduct()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrderModel = new OrderModel()
         {
            Id = new Guid("299f8424-31cc-4825-a713-b73611489d82"),
            isConfirmed = false,
            isDeleted = false,
            DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            TotalAmount = 36000.00M,
            ClientId = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
            OrderDateCreated = DateTime.Now.AddDays(-4),

         };

         var mockProduct = new ProductModel()
         {
            Id = new Guid("b74855c3-a4fa-419f-92df-6056679ed69a"),
            Name = "RV-4FRL",
            ProductDateAdded = DateTime.Now.AddMonths(-3),
            BrandId = 1,
            CategoryId = 1,
            Description = "This is a Mitsubishi Electrics Robot",
            isDeleted = false,
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
         };



         await orderService.OrderProduct(mockOrderModel, mockProduct);

         var orderProduct = await repo.AllReadonly<OrderProduct>(o => o.OrderId == mockOrderModel.Id)
                                      .FirstOrDefaultAsync(o => o.ProductId == mockProduct.Id);

         Assert.NotNull(orderProduct);


      }


      [Test]
      public async Task TestRemoveFromOrder()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrderProduct =
                      new OrderProduct()
                      {
                         OrderId = new Guid("983b42ae-6b41-4484-a5cf-6d8e1a084c40"),
                         ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                      };

         await repo.AddAsync<OrderProduct>(mockOrderProduct);
         await repo.SaveChangesAsync();

         await orderService.RemoveFromOrder(mockOrderProduct.ProductId, "983b42ae-6b41-4484-a5cf-6d8e1a084c40");

         var nullOrderProduct = await repo.AllReadonly<OrderProduct>(o => o.OrderId == mockOrderProduct.OrderId).FirstOrDefaultAsync();

         Assert.Null(nullOrderProduct);


      }


      [Test]
      public async Task TestGetOrderById()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrder = new Order()
         {
            Id = new Guid("983b42ae-6b41-4484-a5cf-6d8e1a084c40"),
            isConfirmed = false,
            isDeleted = false,
            DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            TotalAmount = 36000.00M,
            ClientId = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
            OrderDateCreated = DateTime.Now.AddDays(-4),

         };


         await repo.AddAsync(mockOrder);
         await repo.SaveChangesAsync();


         var order = await orderService.GetOrderById("983b42ae-6b41-4484-a5cf-6d8e1a084c40");


         Assert.That(order, Is.Not.Null);
         Assert.That(order.DeliveryAddress.Equals(mockOrder.DeliveryAddress), Is.True);


      }

      [Test]
      public async Task TestCreateOrder()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrderModel = new OrderModel()
         {
            Id = new Guid("983b42ae-6b41-4484-a5cf-6d8e1a084c40"),
            isConfirmed = false,
            isDeleted = false,
            DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            TotalAmount = 36000.00M,
            ClientId = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
            OrderDateCreated = DateTime.Now.AddDays(-4),

         };


         var orderId = await orderService.CreateOrder(mockOrderModel);

         var order = await repo.GetByIdAsync<Order>(orderId);

         Assert.That(order, Is.Not.Null);
         Assert.That(order.DeliveryAddress.Equals(mockOrderModel.DeliveryAddress), Is.True);


      }


      [Test]
      public async Task TestConfirmOrder()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrder = new Order()
         {
            Id = new Guid("983b42ae-6b41-4484-a5cf-6d8e1a084c40"),
            isConfirmed = false,
            isDeleted = false,
            DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            TotalAmount = 0.00M,
            ClientId = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
            OrderDateCreated = DateTime.Now.AddDays(-4),

         };

         await repo.AddAsync(mockOrder);
         await repo.SaveChangesAsync();



         await orderService.ConfirmOrder("983b42ae-6b41-4484-a5cf-6d8e1a084c40", 36000);

         var order = await repo.GetByIdAsync<Order>(mockOrder.Id);

         Assert.That(order, Is.Not.Null);
         Assert.That(order.isConfirmed, Is.True);
         Assert.That(order.TotalAmount.Equals(36000), Is.True);


      }



      [Test]
      public async Task TestConfirmOrder_ThrowsArgumentException()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);
         orderService = new OrderSerivce(repo, productService);


         var mockOrder = new Order()
         {
            Id = new Guid("983b42ae-6b41-4484-a5cf-6d8e1a084c40"),
            isConfirmed = false,
            isDeleted = false,
            DeliveryAddress = "Sofia \"Opalchenska\" Str. 105",
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            TotalAmount = 0.00M,
            ClientId = new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"),
            OrderDateCreated = DateTime.Now.AddDays(-4),

         };

         await repo.AddAsync(mockOrder);
         await repo.SaveChangesAsync();


         Assert.ThrowsAsync<ArgumentException>(() => orderService.ConfirmOrder("", 36000));


      }



      [TearDown]
      public void TearDown()
      {
         applicationDbContext.Dispose();
      }

   }
}
