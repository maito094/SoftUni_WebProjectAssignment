using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutomationShopHub.Core.Services
{
   public class OrderSerivce : IOrderService
   {
      private readonly IRepository repo;
      private readonly IProductService productService;

      public OrderSerivce(IRepository _repo, IProductService _productService)
      {
         repo = _repo;
         productService = _productService;
      }

      public async Task<AllProductOrderModel> AllProductsByOrderByClientId(Guid clientId, string? orderId)
      {

         if (orderId == null)
         {
            throw new ArgumentException("Order is not Found!");
         }
         var orderGuid = new Guid(orderId);

         var orderProduct = repo.AllReadonly<OrderProduct>(o => o.OrderId == orderGuid);

         if (orderProduct == null)
         {
            throw new ArgumentException("No products Found!");

         }

         var products = repo.AllReadonly<Product>();

         //first.Join(second, f => f.b, s => s.b, (fir, sec) => fir);
         var productsResult = products.Join(orderProduct, p => p.Id, op => op.ProductId, (products, orderProduct) => products);



         var productOrderModel = await productsResult.Select(o => new ProductOrderModel()
         {
            Id = o.Id,
            Name = o.Name,
            Description = o.Description,
            CategoryId = o.CategoryId,
            CategoryName = o.Category.Name,
         }).ToListAsync();

         foreach (var o in productOrderModel)
         {
            o.ProductType = await productService.GetProductTypeByCategoryAndProductId(o.CategoryId, o.Id);
         }

         var allProductOrderModel = new AllProductOrderModel();
         allProductOrderModel.Products = productOrderModel;
         allProductOrderModel.TotalProductsCount = productOrderModel.Count();


         return allProductOrderModel;
      }

      public async Task ConfirmOrder(string orderId, decimal totalSum)
      {
         if (string.IsNullOrEmpty(orderId))
         {
            throw new ArgumentException("Order is not Found!");
         }

         var order = await repo.GetByIdAsync<Order>(new Guid(orderId));
         order.TotalAmount = totalSum;
         order.isConfirmed = true;
         await repo.SaveChangesAsync();
      }

      public async Task<Guid> CreateOrder(OrderModel model)
      {
         var order = new Order()
         {
            ClientId = model.ClientId,
            SalesAgentId = model.SalesAgentId,
            DeliveryAddress = model.DeliveryAddress,
            isDeleted = model.isDeleted,
            OrderDateCreated = model.OrderDateCreated,
            isConfirmed = model.isConfirmed,
            TotalAmount = model.TotalAmount,
         };

         await repo.AddAsync<Order>(order);
         await repo.SaveChangesAsync();

         return order.Id;
      }

      public async Task<OrderModel> GetOrderById(string orderId)
      {
         var order = await repo.GetByIdAsync<Order>(new Guid(orderId));

         return new OrderModel()
         {
            Id = order.Id,
            isConfirmed = order.isConfirmed,
            TotalAmount = order.TotalAmount,
            DeliveryAddress = order.DeliveryAddress,
            SalesAgentId = order.SalesAgentId,
            ClientId = order.ClientId,
            isDeleted = order.isDeleted,
            OrderDateCreated = order.OrderDateCreated

         };
      }



      public async Task<bool> isOrderedByClientWithId(Guid clientId, Guid productId, string? orderId = null)
      {
         bool isOrderd = false;
         if (orderId == null)
         {
            return isOrderd;
         }
         var order = await repo.GetByIdAsync<Order>(new Guid(orderId));

         if (order == null)
         {
            throw new NullReferenceException("Order not Found!");

         }

         var orderProduct = await repo.AllReadonly<OrderProduct>(o => o.OrderId == order.Id)
                                      .FirstOrDefaultAsync(o => o.ProductId == productId);

         if (order.ClientId != clientId)
         {
            throw new ArgumentException("Incorrect Client");
         }

         if (orderProduct != null)
         {
            isOrderd = true;
         }


         return isOrderd;
      }

      public async Task OrderProduct(OrderModel orderModel, ProductModel productModel)
      {


         var orderProduct = new OrderProduct()
         {
            OrderId = orderModel.Id,
            ProductId = productModel.Id
         };

         await repo.AddAsync<OrderProduct>(orderProduct);
         await repo.SaveChangesAsync();


      }

      public async Task RemoveFromOrder(Guid productId, string orderId)
      {
         var orderGuid = new Guid(orderId);
         object[] compositeKey = { orderGuid, productId };
         var orderProduct = await repo.GetByIdsAsync<OrderProduct>(compositeKey);

         repo.Delete<OrderProduct>(orderProduct);
         await repo.SaveChangesAsync();
      }
   }
}
