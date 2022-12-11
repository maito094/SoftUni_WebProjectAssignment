using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;

namespace AutomationShopHub.Core.Contracts
{
   public interface IOrderService
    {
      Task<AllProductOrderModel> AllProductsByOrderByClientId(Guid clientId, string? orderId = null);
      Task<bool> isOrderedByClientWithId(Guid clientId, Guid productId, string? orderId = null);

      Task<OrderModel> GetOrderById(string orderId);
      Task<Guid> CreateOrder(OrderModel model);
      Task OrderProduct(OrderModel orderModel, ProductModel productModel);
      Task RemoveFromOrder(Guid productId, string orderId);

      Task ConfirmOrder(string orderId,decimal totalSum);

   }
}
