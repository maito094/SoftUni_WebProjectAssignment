using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;

namespace AutomationShopHub.Core.Contracts
{
    public interface IProductService
   {
      Task<IEnumerable<ProductModel>> AllProducts();
      Task<IEnumerable<ProductCategoryModel>> AllCategories();
      Task<IEnumerable<ProductBrandModel>> AllBrands();
      Task<IEnumerable<PLCModel>> AllPLCs();


   }
}
