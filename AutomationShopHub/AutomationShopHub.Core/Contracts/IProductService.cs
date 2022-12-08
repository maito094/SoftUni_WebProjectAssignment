using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.Enum;
using AutomationShopHub.Core.Models.Product.ProductTypes;

namespace AutomationShopHub.Core.Contracts
{
    public interface IProductService
   {
      Task<ProductQueryModel> All(
         string? category = null,
         string? searchTerm = null,
         ProductSorting sorting = ProductSorting.Newest,
         int currentPage = 1,
         int productsPerPage = 1
         );
      IQueryable<ProductModel> AllProductsQuery();
      Task<IEnumerable<ProductModel>> AllProducts();
      Task<ProductModel> GetProductByIdAsync(Guid id);
      Task<bool> ProductExists(Guid id);

      Task<IEnumerable<CategoryModel>> AllCategories();
      Task<CategoryModel> GetCategory(int id);
      Task<bool> CategoryExists(int id);
      Task<BrandModel> GetBrand(int id);
      Task<bool> BrandExists(int id);
      Task<IEnumerable<BrandModel>> AllBrands();
      Task<PLCModel?> GetPLCByProductId(Guid guidId);
      IQueryable<PLCModel> AllPLCsQuery();
      Task<IEnumerable<RobotTypeModel>> AllRobotTypes();
      Task<RobotTypeModel> GetRobotType(int id);
      Task<RobotModel?> GetRobotByProductId( Guid guidId);
      Task<bool> RobotTypeExists(int id);

      Task<IEnumerable<IndustrialProtocolModel>> AllProtocolTypes();
      Task<IndustrialProtocolModel> GetProtocolType(int id);
      Task<bool> ProtocolExists(int id);

      Task<SensorModel?> GetSensorByProductId(Guid guidId);
      Task<VisionSystemModel?> GetVisionSystemByProductId(Guid guidId);


      Task<Guid> CreateProduct(ProductModel productModel);
      Task<int> CreateRobot(RobotModel robotModel);
      Task<int> CreatePLC(PLCModel plcModel);
      Task<int> CreateSensor(SensorModel sensorModel);
      Task<int> CreateVisionSystem(VisionSystemModel visionSystemModel);


      Task<IEnumerable<ProductModel>> AllProductsByAgentId(Guid agentId);
      Task<IEnumerable<ProductModel>> AllProductsByOrderByClientId(Guid clientId, Guid orderId);

   }
}
