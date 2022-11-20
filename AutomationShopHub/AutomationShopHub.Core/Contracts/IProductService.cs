using AutomationShopHub.Core.Models.Product;

namespace AutomationShopHub.Core.Contracts
{
    public interface IProductService
   {
      Task<IEnumerable<ProductModel>> AllProducts();
   }
}
