using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.Enum;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using System.Linq;

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
      IEnumerable<IQueryable<ProductModel>> AllProductsQuery();
      Task<ProductModel> GetProductByIdAsync(Guid id);
      Task<bool> ProductExists(Guid id);


      Task<IEnumerable<CategoryModel>> AllCategories();
      Task<CategoryModel> GetCategory(int id);
      Task<bool> CategoryExists(int id);
      Task<IEnumerable<BrandModel>> AllBrands();
      Task<BrandModel> GetBrand(int id);
      Task<bool> BrandExists(int id);

      IQueryable<PLCModel> AllPLCsQuery();
      IQueryable<RobotModel> AllRobotsQuery();
      IQueryable<SensorModel> AllSensorsQuery();
      IQueryable<VisionSystemModel> AllVisionSystemsQuery();

      Task<PLCModel?> GetPLCByProductId(Guid guidId);
      Task<RobotModel?> GetRobotByProductId( Guid guidId);
      Task<SensorModel?> GetSensorByProductId(Guid guidId);
      Task<VisionSystemModel?> GetVisionSystemByProductId(Guid guidId);

      Task<IEnumerable<RobotTypeModel>> AllRobotTypes();
      Task<RobotTypeModel> GetRobotType(int id);
      Task<bool> RobotTypeExists(int id);

      Task<IEnumerable<SensorTypeModel>> AllSensorTypes();
      Task<SensorTypeModel> GetSensorType(int id);
      Task<bool> SensorTypeExists(int id);

      Task<IEnumerable<IndustrialProtocolModel>> AllProtocolTypes();
      Task<IndustrialProtocolModel> GetProtocolType(int id);
      Task<bool> ProtocolExists(int id);


      Task<Guid> CreateProduct(ProductModel productModel);
      Task<int> CreateRobot(RobotModel robotModel);
      Task<int> CreatePLC(PLCModel plcModel);
      Task<int> CreateSensor(SensorModel sensorModel);
      Task<int> CreateVisionSystem(VisionSystemModel visionSystemModel);


      Task Edit(Guid productGuid, string name, string description, int brandId, int categoryId, DateTime dateModified);
      Task EditRobot(int id, string description, int protocolId, int robotTypeId, string modelReference, int guaranteePeriod, decimal reach, decimal speed, decimal payload, int numberOfAxis, string dataSheetUrl, string ImageUrl, decimal price);
      Task EditPLC(int id, string description, int protocolId, string modelReference, int guaranteePeriod, int maxInputsOutputs, decimal scanTime, string dataSheetUrl, string ImageUrl, decimal price);
      Task EditSensor(int id, string description, int protocolId, int sensorTypeId, string modelReference, int guaranteePeriod, bool isDiscreteType, bool isRangeAdjustable, string dataSheetUrl, string ImageUrl, decimal price);
      Task EditVisionSystem(int id, string description, int protocolId, string modelReference, int guaranteePeriod, bool hasBuiltInController, bool hasBuiltInLight, bool hasBuiltInLens, string dataSheetUrl, string ImageUrl, decimal price);

      Task<bool> HasAgentWithId(Guid productGuid, Guid agentId);
      Task<IEnumerable<ProductModel>> AllProductsByAgentId(Guid agentId);
      Task<IEnumerable<ProductModel>> AllProductsByOrderByClientId(Guid clientId, Guid orderId);


      Task Delete(Guid productId);
   }
}
