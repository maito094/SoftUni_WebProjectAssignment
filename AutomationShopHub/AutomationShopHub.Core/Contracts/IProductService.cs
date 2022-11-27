using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;

namespace AutomationShopHub.Core.Contracts
{
    public interface IProductService
   {
      Task<IEnumerable<ProductModel>> AllProducts();
      Task<ProductModel> GetProductByIdAsync(Guid id);
      Task<IEnumerable<CategoryModel>> AllCategories();
      Task<CategoryModel> GetCategory(int id);
      Task<bool> CategoryExists(int id);
      Task<BrandModel> GetBrand(int id);
      Task<bool> BrandExists(int id);
      Task<IEnumerable<BrandModel>> AllBrands();
      Task<IEnumerable<PLCModel>> AllPLCs();
      IQueryable<PLCModel> AllPLCsQuery();
      Task<IEnumerable<RobotTypeModel>> AllRobotTypes();
      Task<RobotTypeModel> GetRobotType(int id);
      Task<bool> RobotTypeExists(int id);

      Task<IEnumerable<IndustrialProtocolModel>> AllProtocolTypes();
      Task<IndustrialProtocolModel> GetProtocolType(int id);
      Task<bool> ProtocolExists(int id);


      Task<Guid> CreateProduct(ProductModel productModel);
      Task<int> CreateRobot(RobotModel robotModel);


   }
}
