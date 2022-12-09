using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.Enum;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;

namespace AutomationShopHub.Core.Services
{
   public class ProductService : IProductService
   {
      private readonly IRepository repo;

      public ProductService(IRepository _repo)
      {
         repo = _repo;
      }


      public IQueryable<PLCModel> AllPLCsQuery()
      {
         return repo.AllReadonly<PLC>()
                     .Include(pr => pr.Product)
                     .Include(pl => pl.Product.SalesAgent)
                     .Where(p => !p.Product.isDeleted)
                     .Select(p => new PLCModel()
                     {
                        Id = p.Id,
                        ProductId = p.ProductId,
                        Product = new ProductModel()
                        {
                           Id = p.ProductId,
                           BrandId = p.Product.BrandId,
                           Brand = new BrandModel()
                           {
                              Id = p.Product.Brand.Id,
                              Name = p.Product.Brand.Name,
                              Description = p.Product.Brand.Description,
                           },
                           ProductDateAdded = p.Product.ProductDateAdded,
                           ProductDateModified = p.Product.ProductDateModified,
                           CategoryId = p.Product.CategoryId,
                           Category = new CategoryModel()
                           {
                              Id = p.Product.Category.Id,
                              Name = p.Product.Category.Name,
                              Description = p.Product.Category.Description,
                           },
                           Description = p.Description,
                           isDeleted = p.Product.isDeleted,
                           Name = p.Product.Name,
                           SalesAgentId = p.Product.SalesAgentId,
                           SalesAgent = new SalesAgentModel()
                           {
                              SalesAgentId = p.Product.SalesAgent.Id,
                              ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                              TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                              AgentName = p.Product.SalesAgent.User.UserName,
                              AgentUserId = p.Product.SalesAgent.UserId
                           }


                        },
                        CommunicationProtocolId = p.CommunicationProtocolId,
                        Protocol = new IndustrialProtocolModel()
                        {
                           Id = p.Protocol.Id,
                           Name = p.Protocol.Name,
                           Description = p.Protocol.Description,

                        },
                        Price = p.Price,
                        GuaranteePeriod = p.GuaranteePeriod,
                        MaxInputsOutputs = p.MaxInputsOutputs,
                        ScanTime = p.ScanTime,
                        Description = p.Description,
                        ModelReference = p.ModelReference,
                        DatasheetUrl = p.DatasheetUrl,
                        ImageUrl = p.ImageUrl

                     }).AsQueryable();
      }

      public IQueryable<RobotModel> AllRobotsQuery()
      {
         return repo.AllReadonly<Robot>()
                     .Include(pr => pr.Product)
                     .Include(pl => pl.Product.SalesAgent)
                     .Where(p => !p.Product.isDeleted)
                     .Select(p => new RobotModel()
                     {
                        Id = p.Id,
                        ProductId = p.ProductId,
                        Product = new ProductModel()
                        {
                           Id = p.ProductId,
                           BrandId = p.Product.BrandId,
                           Brand = new BrandModel()
                           {
                              Id = p.Product.Brand.Id,
                              Name = p.Product.Brand.Name,
                              Description = p.Product.Brand.Description,
                           },
                           ProductDateAdded = p.Product.ProductDateAdded,
                           ProductDateModified = p.Product.ProductDateModified,
                           CategoryId = p.Product.CategoryId,
                           Category = new CategoryModel()
                           {
                              Id = p.Product.Category.Id,
                              Name = p.Product.Category.Name,
                              Description = p.Product.Category.Description,
                           },
                           Description = p.Description,
                           isDeleted = p.Product.isDeleted,
                           Name = p.Product.Name,
                           SalesAgentId = p.Product.SalesAgentId,
                           SalesAgent = new SalesAgentModel()
                           {
                              SalesAgentId = p.Product.SalesAgent.Id,
                              ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                              TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                              AgentName = p.Product.SalesAgent.User.UserName,
                              AgentUserId = p.Product.SalesAgent.UserId
                           }


                        },
                        CommunicationProtocolId = p.CommunicationProtocolId,
                        IndustrialProtocols = new IndustrialProtocolModel()
                        {
                           Id = p.Protocol.Id,
                           Name = p.Protocol.Name,
                           Description = p.Protocol.Description,

                        },
                        RobotTypeId = p.RobotTypeId,
                        RobotType = new RobotTypeModel()
                        {
                           Id = p.Type.Id,
                           Name = p.Type.Name,
                        },
                        Price = p.Price,
                        GuaranteePeriod = p.GuaranteePeriod,
                        NumberOfAxis = p.NumberOfAxis,
                        Payload = p.Payload,
                        Reach = p.Reach,
                        Speed = p.Speed,
                        Description = p.Description,
                        ModelReference = p.ModelReference,
                        DatasheetUrl = p.DatasheetUrl,
                        ImageUrl = p.ImageUrl

                     }).AsQueryable();
      }

      public IQueryable<SensorModel> AllSensorsQuery()
      {
         return repo.AllReadonly<Sensor>()
                    .Include(pr => pr.Product)
                    .Include(pl => pl.Product.SalesAgent)
                    .Where(p => !p.Product.isDeleted)
                    .Select(p => new SensorModel()
                    {
                       Id = p.Id,
                       ProductId = p.ProductId,
                       Product = new ProductModel()
                       {
                          Id = p.ProductId,
                          BrandId = p.Product.BrandId,
                          Brand = new BrandModel()
                          {
                             Id = p.Product.Brand.Id,
                             Name = p.Product.Brand.Name,
                             Description = p.Product.Brand.Description,
                          },
                          ProductDateAdded = p.Product.ProductDateAdded,
                          ProductDateModified = p.Product.ProductDateModified,
                          CategoryId = p.Product.CategoryId,
                          Category = new CategoryModel()
                          {
                             Id = p.Product.Category.Id,
                             Name = p.Product.Category.Name,
                             Description = p.Product.Category.Description,
                          },
                          Description = p.Description,
                          isDeleted = p.Product.isDeleted,
                          Name = p.Product.Name,
                          SalesAgentId = p.Product.SalesAgentId,
                          SalesAgent = new SalesAgentModel()
                          {
                             SalesAgentId = p.Product.SalesAgent.Id,
                             ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                             TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                             AgentName = p.Product.SalesAgent.User.UserName,
                             AgentUserId = p.Product.SalesAgent.UserId
                          }


                       },
                       CommunicationProtocolId = p.CommunicationProtocolId,
                       Protocol = new IndustrialProtocolModel()
                       {
                          Id = p.Protocol.Id,
                          Name = p.Protocol.Name,
                          Description = p.Protocol.Description,

                       },
                       SensorTypeId = p.SensorTypeId,
                       Type = new SensorTypeModel()
                       {
                          Id = p.Type.Id,
                          Name = p.Type.Name,
                       },
                       Price = p.Price,
                       GuaranteePeriod = p.GuaranteePeriod,
                       isRangeAdjustable = p.isRangeAdjustable,
                       isDiscreteType = p.isDiscreteType,
                       Description = p.Description,
                       ModelReference = p.ModelReference,
                       DatasheetUrl = p.DatasheetUrl,
                       ImageUrl = p.ImageUrl

                    }).AsQueryable();
      }

      public IQueryable<VisionSystemModel> AllVisionSystemsQuery()
      {
         return repo.AllReadonly<VisionSystem>()
                     .Include(pr => pr.Product)
                     .Include(pl => pl.Product.SalesAgent)
                     .Where(p => !p.Product.isDeleted)
                     .Select(p => new VisionSystemModel()
                     {
                        Id = p.Id,
                        ProductId = p.ProductId,
                        Product = new ProductModel()
                        {
                           Id = p.ProductId,
                           BrandId = p.Product.BrandId,
                           Brand = new BrandModel()
                           {
                              Id = p.Product.Brand.Id,
                              Name = p.Product.Brand.Name,
                              Description = p.Product.Brand.Description,
                           },
                           ProductDateAdded = p.Product.ProductDateAdded,
                           ProductDateModified = p.Product.ProductDateModified,
                           CategoryId = p.Product.CategoryId,
                           Category = new CategoryModel()
                           {
                              Id = p.Product.Category.Id,
                              Name = p.Product.Category.Name,
                              Description = p.Product.Category.Description,
                           },
                           Description = p.Description,
                           isDeleted = p.Product.isDeleted,
                           Name = p.Product.Name,
                           SalesAgentId = p.Product.SalesAgentId,
                           SalesAgent = new SalesAgentModel()
                           {
                              SalesAgentId = p.Product.SalesAgent.Id,
                              ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                              TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                              AgentName = p.Product.SalesAgent.User.UserName,
                              AgentUserId = p.Product.SalesAgent.UserId
                           }


                        },
                        CommunicationProtocolId = p.CommunicationProtocolId,
                        Protocol = new IndustrialProtocolModel()
                        {
                           Id = p.Protocol.Id,
                           Name = p.Protocol.Name,
                           Description = p.Protocol.Description,

                        },
                        Price = p.Price,
                        GuaranteePeriod = p.GuaranteePeriod,
                        hasBuiltInController = p.hasBuiltInController,
                        hasBuiltInLens = p.hasBuiltInLens,
                        hasBuiltInLight = p.hasBuiltInLight,
                        Description = p.Description,
                        ModelReference = p.ModelReference,
                        DatasheetUrl = p.DatasheetUrl,
                        ImageUrl = p.ImageUrl

                     }).AsQueryable();
      }

      public IEnumerable<IQueryable<ProductModel>> AllProductsQuery()
      {
         var plcs = AllPLCsQuery();
         var robots = AllRobotsQuery();
         var sensors = AllSensorsQuery();
         var visionSystems = AllVisionSystemsQuery();

         var plcModels = plcs.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new PLCModel()
            {
               Id = pl.Id,
               ProductId = pl.ProductId,
               Product = pl.Product,
               Description = pl.Description,
               Price = pl.Price,
               CommunicationProtocolId = pl.CommunicationProtocolId,
               Protocol = new IndustrialProtocolModel()
               {
                  Id = pl.Protocol.Id,
                  Name = pl.Protocol.Name,
                  Description = pl.Protocol.Description,
               },
               GuaranteePeriod = pl.GuaranteePeriod,
               ScanTime = pl.ScanTime,
               MaxInputsOutputs = pl.MaxInputsOutputs,
               ModelReference = pl.ModelReference,
               DatasheetUrl = pl.DatasheetUrl,
               ImageUrl = pl.ImageUrl
            },
            ProductDateAdded = pl.Product.ProductDateAdded,
            ProductDateModified = pl.Product.ProductDateModified,
            OrderProducts = pl.Product.OrderProducts,
            BrandId = pl.Product.BrandId,
            Brand = pl.Product.Brand,
            CategoryId = pl.Product.CategoryId,
            Category = pl.Product.Category,
            Comments = pl.Product.Comments,
            Description = pl.Product.Description,
            isDeleted = pl.Product.isDeleted,
            SalesAgentId = pl.Product.SalesAgentId,
            SalesAgent = new SalesAgentModel()
            {
               SalesAgentId = pl.Product.SalesAgentId,
               ImageProfileUrl = pl.Product.SalesAgent.ImageProfileUrl,
               TelephoneNumber = pl.Product.SalesAgent.TelephoneNumber,
               AgentName = pl.Product.SalesAgent.AgentName,
               AgentUserId = pl.Product.SalesAgent.AgentUserId
            }
         });
         var robotModels = robots.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new RobotModel()
            {
               Id = pl.Id,
               ProductId = pl.ProductId,
               Product = pl.Product,
               Description = pl.Description,
               Price = pl.Price,
               CommunicationProtocolId = pl.CommunicationProtocolId,
               IndustrialProtocols = new IndustrialProtocolModel()
               {
                  Id = pl.IndustrialProtocols.Id,
                  Name = pl.IndustrialProtocols.Name,
                  Description = pl.IndustrialProtocols.Description,
               },
               GuaranteePeriod = pl.GuaranteePeriod,
               Reach = pl.Reach,
               Speed = pl.Speed,
               NumberOfAxis = pl.NumberOfAxis,
               Payload = pl.Payload,
               RobotTypeId = pl.RobotTypeId,
               RobotType = new RobotTypeModel()
               {
                  Id = pl.RobotType.Id,
                  Name = pl.RobotType.Name,
               },
               ModelReference = pl.ModelReference,
               DatasheetUrl = pl.DatasheetUrl,
               ImageUrl = pl.ImageUrl
            },
            ProductDateAdded = pl.Product.ProductDateAdded,
            ProductDateModified = pl.Product.ProductDateModified,
            OrderProducts = pl.Product.OrderProducts,
            BrandId = pl.Product.BrandId,
            Brand = pl.Product.Brand,
            CategoryId = pl.Product.CategoryId,
            Category = pl.Product.Category,
            Comments = pl.Product.Comments,
            Description = pl.Product.Description,
            isDeleted = pl.Product.isDeleted,
            SalesAgentId = pl.Product.SalesAgentId,
            SalesAgent = new SalesAgentModel()
            {
               SalesAgentId = pl.Product.SalesAgentId,
               ImageProfileUrl = pl.Product.SalesAgent.ImageProfileUrl,
               TelephoneNumber = pl.Product.SalesAgent.TelephoneNumber,
               AgentName = pl.Product.SalesAgent.AgentName,
               AgentUserId = pl.Product.SalesAgent.AgentUserId
            }
         });
         var sensorModels = sensors.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new SensorModel()
            {
               Id = pl.Id,
               ProductId = pl.ProductId,
               Product = pl.Product,
               Description = pl.Description,
               Price = pl.Price,
               CommunicationProtocolId = pl.CommunicationProtocolId,
               Protocol = new IndustrialProtocolModel()
               {
                  Id = pl.Protocol.Id,
                  Name = pl.Protocol.Name,
                  Description = pl.Protocol.Description,
               },
               GuaranteePeriod = pl.GuaranteePeriod,
               isRangeAdjustable = pl.isRangeAdjustable,
               isDiscreteType = pl.isDiscreteType,
               SensorTypeId = pl.SensorTypeId,
               Type = new SensorTypeModel()
               {
                  Id = pl.Type.Id,
                  Name = pl.Type.Name,
               },
               ModelReference = pl.ModelReference,
               DatasheetUrl = pl.DatasheetUrl,
               ImageUrl = pl.ImageUrl
            },
            ProductDateAdded = pl.Product.ProductDateAdded,
            ProductDateModified = pl.Product.ProductDateModified,
            OrderProducts = pl.Product.OrderProducts,
            BrandId = pl.Product.BrandId,
            Brand = pl.Product.Brand,
            CategoryId = pl.Product.CategoryId,
            Category = pl.Product.Category,
            Comments = pl.Product.Comments,
            Description = pl.Product.Description,
            isDeleted = pl.Product.isDeleted,
            SalesAgentId = pl.Product.SalesAgentId,
            SalesAgent = new SalesAgentModel()
            {
               SalesAgentId = pl.Product.SalesAgentId,
               ImageProfileUrl = pl.Product.SalesAgent.ImageProfileUrl,
               TelephoneNumber = pl.Product.SalesAgent.TelephoneNumber,
               AgentName = pl.Product.SalesAgent.AgentName,
               AgentUserId = pl.Product.SalesAgent.AgentUserId
            }
         });
         var visionSystemModels = visionSystems.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new VisionSystemModel()
            {
               Id = pl.Id,
               ProductId = pl.ProductId,
               Product = pl.Product,
               Description = pl.Description,
               Price = pl.Price,
               CommunicationProtocolId = pl.CommunicationProtocolId,
               Protocol = new IndustrialProtocolModel()
               {
                  Id = pl.Protocol.Id,
                  Name = pl.Protocol.Name,
                  Description = pl.Protocol.Description,
               },
               GuaranteePeriod = pl.GuaranteePeriod,
               hasBuiltInController = pl.hasBuiltInController,
               hasBuiltInLens = pl.hasBuiltInLens,
               hasBuiltInLight = pl.hasBuiltInLight,
               ModelReference = pl.ModelReference,
               DatasheetUrl = pl.DatasheetUrl,
               ImageUrl = pl.ImageUrl
            },
            ProductDateAdded = pl.Product.ProductDateAdded,
            ProductDateModified = pl.Product.ProductDateModified,
            OrderProducts = pl.Product.OrderProducts,
            BrandId = pl.Product.BrandId,
            Brand = pl.Product.Brand,
            CategoryId = pl.Product.CategoryId,
            Category = pl.Product.Category,
            Comments = pl.Product.Comments,
            Description = pl.Product.Description,
            isDeleted = pl.Product.isDeleted,
            SalesAgentId = pl.Product.SalesAgentId,
            SalesAgent = new SalesAgentModel()
            {
               SalesAgentId = pl.Product.SalesAgentId,
               ImageProfileUrl = pl.Product.SalesAgent.ImageProfileUrl,
               TelephoneNumber = pl.Product.SalesAgent.TelephoneNumber,
               AgentName = pl.Product.SalesAgent.AgentName,
               AgentUserId = pl.Product.SalesAgent.AgentUserId
            }
         });

         IEnumerable<IQueryable<ProductModel>> products =
            new List<IQueryable<ProductModel>>() { plcModels, robotModels, sensorModels, visionSystemModels };

         return products;
      }

      public async Task<bool> ProductExists(Guid id)
      {
         return await repo.AllReadonly<Product>()
        .AnyAsync(p => p.Id == id && !p.isDeleted);
      }


      public async Task<Guid> CreateProduct(ProductModel productModel)
      {

         Product product = new Product()
         {
            Name = productModel.Name,
            Description = productModel.Description,
            ProductDateAdded = productModel.ProductDateAdded,
            BrandId = productModel.BrandId,
            CategoryId = productModel.CategoryId,
            SalesAgentId = productModel.SalesAgentId,
            isDeleted = false,
            ProductDateModified = productModel.ProductDateModified

         };

         await repo.AddAsync<Product>(product);
         await repo.SaveChangesAsync();

         return product.Id;

      }

      public async Task<int> CreateRobot(RobotModel robotModel)
      {
         Robot robot = new Robot()
         {
            ProductId = robotModel.ProductId,
            CommunicationProtocolId = robotModel.CommunicationProtocolId,
            RobotTypeId = robotModel.RobotTypeId,
            ModelReference = robotModel.ModelReference,
            Description = robotModel.Description,
            NumberOfAxis = robotModel.NumberOfAxis,
            GuaranteePeriod = robotModel.GuaranteePeriod,
            Payload = robotModel.Payload,
            Reach = robotModel.Reach,
            Speed = robotModel.Speed,
            Price = robotModel.Price,
            DatasheetUrl = robotModel.DatasheetUrl,
            ImageUrl = robotModel.ImageUrl
         };
         await repo.AddAsync<Robot>(robot);
         await repo.SaveChangesAsync();

         return robot.Id;
      }

      public async Task<int> CreatePLC(PLCModel plcModel)
      {
         PLC plc = new PLC()
         {
            ProductId = plcModel.ProductId,
            CommunicationProtocolId = plcModel.CommunicationProtocolId,
            ModelReference = plcModel.ModelReference,
            Description = plcModel.Description,
            GuaranteePeriod = plcModel.GuaranteePeriod,
            MaxInputsOutputs = plcModel.MaxInputsOutputs,
            ScanTime = plcModel.ScanTime,
            Price = plcModel.Price,
            DatasheetUrl = plcModel.DatasheetUrl,
            ImageUrl = plcModel.ImageUrl
         };
         await repo.AddAsync<PLC>(plc);
         await repo.SaveChangesAsync();

         return plc.Id;
      }

      public async Task<int> CreateSensor(SensorModel sensorModel)
      {
         Sensor sensor = new Sensor()
         {
            ProductId = sensorModel.ProductId,
            CommunicationProtocolId = sensorModel.CommunicationProtocolId,
            SensorTypeId = sensorModel.SensorTypeId,
            isRangeAdjustable = sensorModel.isRangeAdjustable,
            isDiscreteType = sensorModel.isDiscreteType,
            ModelReference = sensorModel.ModelReference,
            Description = sensorModel.Description,
            GuaranteePeriod = sensorModel.GuaranteePeriod,
            Price = sensorModel.Price,
            DatasheetUrl = sensorModel.DatasheetUrl,
            ImageUrl = sensorModel.ImageUrl
         };
         await repo.AddAsync<Sensor>(sensor);
         await repo.SaveChangesAsync();

         return sensor.Id;
      }

      public async Task<int> CreateVisionSystem(VisionSystemModel visionSystemModel)
      {
         VisionSystem visionSystem = new VisionSystem()
         {
            ProductId = visionSystemModel.ProductId,
            CommunicationProtocolId = visionSystemModel.CommunicationProtocolId,
            ModelReference = visionSystemModel.ModelReference,
            Description = visionSystemModel.Description,
            GuaranteePeriod = visionSystemModel.GuaranteePeriod,
            hasBuiltInController = visionSystemModel.hasBuiltInController,
            hasBuiltInLens = visionSystemModel.hasBuiltInLens,
            hasBuiltInLight = visionSystemModel.hasBuiltInLight,
            Price = visionSystemModel.Price,
            DatasheetUrl = visionSystemModel.DatasheetUrl,
            ImageUrl = visionSystemModel.ImageUrl
         };
         await repo.AddAsync<VisionSystem>(visionSystem);
         await repo.SaveChangesAsync();

         return visionSystem.Id;
      }

      public async Task<ProductModel> GetProductByIdAsync(Guid id)
      {
         var product = await repo.AllReadonly<Product>()
            .Where(p => p.Id == id && !p.isDeleted)
             .Include(c => c.Category)
             .Include(b => b.Brand)
             .Include(s => s.SalesAgent)
             .Include(c => c.Comments)
             .Include(op => op.OrderProducts)
             .Include(u => u.SalesAgent.User)
             .FirstOrDefaultAsync();

         return new ProductModel()
         {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ProductDateAdded = product.ProductDateAdded,
            ProductDateModified = product.ProductDateModified,
            SalesAgentId = product.SalesAgentId,
            SalesAgent = new SalesAgentModel()
            {
               SalesAgentId = product.SalesAgentId,
               AgentUserId = product.SalesAgent.UserId,
               AgentName = product.SalesAgent.User.UserName,
               ImageProfileUrl = product.SalesAgent.ImageProfileUrl,
               TelephoneNumber = product.SalesAgent.TelephoneNumber,
            },
            BrandId = product.BrandId,
            Brand = new BrandModel()
            {
               Id = product.Brand.Id,
               Name = product.Brand.Name,
               Description = product.Brand.Description,
            },
            CategoryId = product.CategoryId,
            Category = new CategoryModel()
            {
               Id = product.Category.Id,
               Name = product.Category.Name,
               Description = product.Category.Description
            },
            isDeleted = false,
            Comments = new List<CommentModel>(product.Comments.Select(c => new CommentModel()
            {
               Id = c.Id,
               Content = c.Content,
               UserId = c.UserId,
               Replies = new List<CommentModel>()

            })),
            OrderProducts = new List<OrderProductModel>(product.OrderProducts.Select(op => new OrderProductModel()
            {
               OrderId = op.OrderId,
               ProductId = op.ProductId,
               Product = new ProductModel()
               {
                  Id = op.ProductId,
                  Name = op.Product.Name,
               },
               Order = op.Order,
            }))

         };
      }

      // Robot Types
      public async Task<IEnumerable<RobotTypeModel>> AllRobotTypes()
      {
         return await repo.AllReadonly<RobotType>()
                    .OrderBy(rt => rt.Id)
                    .Select(rt => new RobotTypeModel()
                    {
                       Id = rt.Id,
                       Name = rt.Name
                    })
                    .ToListAsync();
      }
      public async Task<RobotTypeModel> GetRobotType(int id)
      {
         var robotType = await repo.GetByIdAsyncAsNoTracking<RobotType>(id);

         return new RobotTypeModel()
         {
            Id = robotType.Id,
            Name = robotType.Name
         };
      }
      public async Task<bool> RobotTypeExists(int id)
      {
         return await repo.AllReadonly<RobotType>().AnyAsync(rt => rt.Id == id);

      }

      // Protocol Types
      public async Task<IEnumerable<IndustrialProtocolModel>> AllProtocolTypes()
      {
         return await repo.AllReadonly<IndustrialProtocol>()
                          .OrderBy(ip => ip.Id)
                          .Select(ip => new IndustrialProtocolModel()
                          {
                             Id = ip.Id,
                             Name = ip.Name
                          })
                          .ToListAsync();
      }
      public async Task<IndustrialProtocolModel> GetProtocolType(int id)
      {
         var protocolType = await repo.GetByIdAsyncAsNoTracking<IndustrialProtocol>(id);

         return new IndustrialProtocolModel()
         {
            Id = protocolType.Id,
            Name = protocolType.Name,
            Description = protocolType.Description,
         };
      }
      public async Task<bool> ProtocolExists(int id)
      {
         return await repo.AllReadonly<IndustrialProtocol>().AnyAsync(ip => ip.Id == id);

      }

      // Sensor Types
      public async Task<IEnumerable<SensorTypeModel>> AllSensorTypes()
      {
         return await repo.AllReadonly<SensorType>()
                         .OrderBy(ip => ip.Id)
                         .Select(ip => new SensorTypeModel()
                         {
                            Id = ip.Id,
                            Name = ip.Name
                         })
                         .ToListAsync();
      }
      public async Task<SensorTypeModel> GetSensorType(int id)
      {
         var sensorType = await repo.GetByIdAsyncAsNoTracking<SensorType>(id);

         return new SensorTypeModel()
         {
            Id = sensorType.Id,
            Name = sensorType.Name
         };
      }
      public async Task<bool> SensorTypeExists(int id)
      {
         return await repo.AllReadonly<SensorType>().AnyAsync(ip => ip.Id == id);
      }

      // Categories
      public async Task<IEnumerable<CategoryModel>> AllCategories()
      {
         return await repo.AllReadonly<Category>()
            .OrderBy(c => c.Name)
            .Select(c => new CategoryModel()
            {
               Id = c.Id,
               Name = c.Name,
               Description = c.Description,
            })
            .ToListAsync();
      }
      public async Task<CategoryModel> GetCategory(int id)
      {

         var category = await repo.GetByIdAsyncAsNoTracking<Category>(id);

         return new CategoryModel()
         {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
         };

      }
      public async Task<bool> CategoryExists(int id)
      {
         return await repo.AllReadonly<Category>().AnyAsync(c => c.Id == id);
      }

      // Brands
      public async Task<IEnumerable<BrandModel>> AllBrands()
      {
         return await repo.AllReadonly<Brand>()
            .OrderBy(b => b.Name)
            .Select(b => new BrandModel()
            {
               Id = b.Id,
               Name = b.Name,
               Description = b.Description,
            })
            .ToListAsync();
      }
      public async Task<BrandModel> GetBrand(int id)
      {
         var category = await repo.GetByIdAsyncAsNoTracking<Brand>(id);


         return new BrandModel()
         {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
         };
      }
      public async Task<bool> BrandExists(int id)
      {
         return await repo.AllReadonly<Brand>().AnyAsync(b => b.Id == id);

      }


      public async Task<RobotModel?> GetRobotByProductId(Guid guidId)
      {
         var robot = await repo.AllReadonly<Robot>()
            .Select(r => new RobotModel()
            {
               Id = r.Id,
               NumberOfAxis = r.NumberOfAxis,
               Description = r.Description,
               GuaranteePeriod = r.GuaranteePeriod,
               Payload = r.Payload,
               Reach = r.Reach,
               ModelReference = r.ModelReference,
               Price = r.Price,
               Speed = r.Speed,
               CommunicationProtocolId = r.CommunicationProtocolId,
               IndustrialProtocols = new IndustrialProtocolModel()
               {
                  Id = r.Protocol.Id,
                  Name = r.Protocol.Name,
                  Description = r.Protocol.Description
               },
               DatasheetUrl = r.DatasheetUrl,
               ImageUrl = r.ImageUrl,
               ProductId = r.ProductId,
               RobotTypeId = r.RobotTypeId,
               RobotType = new RobotTypeModel()
               {
                  Id = r.Type.Id,
                  Name = r.Type.Name
               }


            })
            .FirstOrDefaultAsync(r => r.ProductId == guidId);

         return robot;
      }

      public async Task<PLCModel?> GetPLCByProductId(Guid guidId)
      {
         var plc = await repo.AllReadonly<PLC>()
            .Select(r => new PLCModel()
            {
               Id = r.Id,
               Description = r.Description,
               GuaranteePeriod = r.GuaranteePeriod,
               ModelReference = r.ModelReference,
               Price = r.Price,
               CommunicationProtocolId = r.CommunicationProtocolId,
               Protocol = new IndustrialProtocolModel()
               {
                  Id = r.Protocol.Id,
                  Name = r.Protocol.Name,
                  Description = r.Protocol.Description
               },
               DatasheetUrl = r.DatasheetUrl,
               ImageUrl = r.ImageUrl,
               ProductId = r.ProductId,
               MaxInputsOutputs = r.MaxInputsOutputs,
               ScanTime = r.ScanTime,


            })
            .FirstOrDefaultAsync(r => r.ProductId == guidId);

         return plc;
      }

      public async Task<SensorModel?> GetSensorByProductId(Guid guidId)
      {
         var sensor = await repo.AllReadonly<Sensor>()
           .Select(r => new SensorModel()
           {
              Id = r.Id,
              Description = r.Description,
              GuaranteePeriod = r.GuaranteePeriod,
              ModelReference = r.ModelReference,
              Price = r.Price,
              CommunicationProtocolId = r.CommunicationProtocolId,
              Protocol = new IndustrialProtocolModel()
              {
                 Id = r.Protocol.Id,
                 Name = r.Protocol.Name,
                 Description = r.Protocol.Description
              },
              DatasheetUrl = r.DatasheetUrl,
              ImageUrl = r.ImageUrl,
              ProductId = r.ProductId,
              SensorTypeId = r.SensorTypeId,
              Type = new SensorTypeModel()
              {
                 Id = r.Type.Id,
                 Name = r.Type.Name

              },
              isRangeAdjustable = r.isRangeAdjustable,
              isDiscreteType = r.isDiscreteType,

           })
           .FirstOrDefaultAsync(r => r.ProductId == guidId);

         return sensor;
      }

      public async Task<VisionSystemModel?> GetVisionSystemByProductId(Guid guidId)
      {
         var visionSystem = await repo.AllReadonly<VisionSystem>()
         .Select(r => new VisionSystemModel()
         {
            Id = r.Id,
            Description = r.Description,
            GuaranteePeriod = r.GuaranteePeriod,
            ModelReference = r.ModelReference,
            Price = r.Price,
            CommunicationProtocolId = r.CommunicationProtocolId,
            Protocol = new IndustrialProtocolModel()
            {
               Id = r.Protocol.Id,
               Name = r.Protocol.Name,
               Description = r.Protocol.Description
            },
            DatasheetUrl = r.DatasheetUrl,
            ImageUrl = r.ImageUrl,
            ProductId = r.ProductId,
            hasBuiltInController = r.hasBuiltInController,
            hasBuiltInLens = r.hasBuiltInLens,
            hasBuiltInLight = r.hasBuiltInLight,

         })
         .FirstOrDefaultAsync(r => r.ProductId == guidId);

         return visionSystem;
      }




      public async Task<ProductQueryModel> All(string? category = null, string? searchTerm = null, ProductSorting sorting = ProductSorting.Newest, int currentPage = 1, int productsPerPage = 1)
      {
         var productsList = new ProductQueryModel();

         var products = AllProductsQuery();

         if (string.IsNullOrEmpty(category) == false)
         {
            products = products.Where(p => p.All(pc => pc.Category.Name == category));
         }

         if (string.IsNullOrEmpty(searchTerm) == false)
         {
            searchTerm = $"%{searchTerm.ToLower()}%";

            products = products.Select(ps => ps.Where(p => EF.Functions.Like(p.Name.ToLower(), searchTerm) ||
                        EF.Functions.Like(p.Description.ToLower(), searchTerm) ||
                       EF.Functions.Like(p.Brand.Name.ToLower(), searchTerm)));

         }

         products = sorting switch
         {
            ProductSorting.Price => products.Select(ps => ps.OrderBy(p => p.ProductType.Price))
            ,
            ProductSorting.Brand => products.Select(ps => ps.OrderBy(p => p.Brand.Name))
            ,
            ProductSorting.Newest => products.Select(ps => ps.OrderByDescending(p => p.ProductDateAdded))
            ,
            _ => products.Select(ps => ps.OrderByDescending(p => p.ProductDateAdded))
         };


         List<ProductModel> prodList = new List<ProductModel>();

         foreach (var prod in products)
         {
            var prodType = await prod.ToListAsync();
            prodList.AddRange(prodType);

         }

         prodList = sorting switch
         {
            ProductSorting.Price => prodList.OrderBy(p => p.ProductType.Price).ToList()
         ,
            ProductSorting.Brand => prodList.OrderBy(p => p.Brand.Name).ToList()
         ,
            ProductSorting.Newest => prodList.OrderByDescending(p => p.ProductDateAdded).ToList()
         ,
            _ => prodList.OrderByDescending(p => p.ProductDateAdded).ToList()
         };

         productsList.TotalProductsCount = products.Select(ps => ps.Count()).Sum();

         productsList.Products = prodList
                           .Skip((currentPage - 1) * productsPerPage)
                           .Take(productsPerPage);


         return productsList;
      }

      public async Task<IEnumerable<ProductModel>> AllProductsByAgentId(Guid agentId)
      {
         var products = AllProductsQuery();

         products = products.Select(ps => ps.Where(p => p.SalesAgentId == agentId));

         List<ProductModel> prodList = new List<ProductModel>();

         foreach (var prod in products)
         {
            var prodType = await prod.ToListAsync();
            prodList.AddRange(prodType);

         }

         return prodList;
      }

      //TODO Find a way to include sub-product components
      public async Task<IEnumerable<ProductModel>> AllProductsByOrderByClientId(Guid clientId, Guid orderId)
      {
         throw new NotImplementedException();
         var orderProducts = repo.AllReadonly<OrderProduct>()
                           .Include(op => op.Product)
                           .Include(op => op.Order)
                           .Where(o => o.Order.ClientId == clientId && o.OrderId == orderId)
                           .Select(p => new ProductModel()
                           {
                              Id = p.ProductId,
                              ProductDateAdded = p.Product.ProductDateAdded,
                              ProductDateModified = p.Product.ProductDateModified,
                              BrandId = p.Product.BrandId,
                              Brand = new BrandModel()
                              {
                                 Id = p.Product.BrandId,
                                 Name = p.Product.Brand.Name,
                                 Description = p.Product.Brand.Description,
                              },
                              CategoryId = p.Product.CategoryId,
                              Category = new CategoryModel()
                              {
                                 Id = p.Product.CategoryId,
                                 Name = p.Product.Category.Name,
                                 Description = p.Product.Category.Description,
                              },
                              SalesAgentId = p.Product.SalesAgentId,
                              SalesAgent = new SalesAgentModel()
                              {
                                 AgentUserId = p.Product.SalesAgent.UserId,
                                 AgentName = p.Product.SalesAgent.User.UserName,
                                 SalesAgentId = p.Product.SalesAgentId,
                                 TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                                 ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                              },
                              isDeleted = p.Product.isDeleted,
                              Name = p.Product.Name,
                              Description = p.Product.Description,
                              Comments = new List<CommentModel>(
                                         p.Product.Comments.Select(c => new CommentModel()
                                         {
                                            Id = c.Id,
                                            UserId = c.UserId,
                                            Content = c.Content,
                                            Replies = new List<CommentModel>(
                                           c.Replies.Select(r => new CommentModel()
                                           {
                                              Id = r.Id,
                                              Content = r.Content,
                                              UserId = r.UserId
                                           }))
                                         }))

                           }).AsQueryable();


         return await orderProducts.ToListAsync();
      }

      public async Task Edit(Guid productGuid, string name, string description, int brandId, int categoryId, DateTime dateModified)
      {

         var product = await repo.GetByIdAsync<Product>(productGuid); ;

         product.Name = name;
         product.Description = description;
         product.BrandId = brandId;
         product.CategoryId = categoryId;
         product.ProductDateModified = dateModified;

         await repo.SaveChangesAsync();

      }

      public async Task EditRobot(int id, string description, int protocolId, int robotTypeId, string modelReference, int guaranteePeriod, decimal reach, decimal speed, decimal payload, int numberOfAxis, string dataSheetUrl, string ImageUrl, decimal price)
      {
         var robot = await repo.GetByIdAsync<Robot>(id);
         robot.Description = description;
         robot.CommunicationProtocolId = protocolId;
         robot.RobotTypeId = robotTypeId;
         robot.ModelReference = modelReference;
         robot.GuaranteePeriod = guaranteePeriod;
         robot.Reach = reach;
         robot.Speed = speed;
         robot.Payload = payload;
         robot.NumberOfAxis = numberOfAxis;
         robot.DatasheetUrl = dataSheetUrl;
         robot.ImageUrl = ImageUrl;
         robot.Price = price;

         await repo.SaveChangesAsync();
      }

      public async Task EditPLC(int id, string description, int protocolId, string modelReference, int guaranteePeriod, int maxInputsOutputs, decimal scanTime, string dataSheetUrl, string ImageUrl, decimal price)
      {
         var plc = await repo.GetByIdAsync<PLC>(id);


         plc.Description = description;
         plc.CommunicationProtocolId = protocolId;
         plc.ModelReference = modelReference;
         plc.GuaranteePeriod = guaranteePeriod;
         plc.MaxInputsOutputs = maxInputsOutputs;
         plc.ScanTime = scanTime;
         plc.DatasheetUrl = dataSheetUrl;
         plc.ImageUrl = ImageUrl;
         plc.Price = price;

         await repo.SaveChangesAsync();
      }

      public async Task EditSensor(int id, string description, int protocolId, int sensorTypeId, string modelReference, int guaranteePeriod, bool isDiscreteType, bool isRangeAdjustable, string dataSheetUrl, string ImageUrl, decimal price)
      {
         var sensor = await repo.GetByIdAsync<Sensor>(id);

         sensor.Description = description;
         sensor.CommunicationProtocolId = protocolId;
         sensor.SensorTypeId = sensorTypeId;
         sensor.ModelReference = modelReference;
         sensor.GuaranteePeriod = guaranteePeriod;
         sensor.isDiscreteType = isDiscreteType;
         sensor.isRangeAdjustable = isRangeAdjustable;
         sensor.DatasheetUrl = dataSheetUrl;
         sensor.ImageUrl = ImageUrl;
         sensor.Price = price;

         await repo.SaveChangesAsync();
      }

      public async Task EditVisionSystem(int id, string description, int protocolId, string modelReference, int guaranteePeriod, bool hasBuiltInController, bool hasBuiltInLight, bool hasBuiltInLens, string dataSheetUrl, string ImageUrl, decimal price)
      {
         var visionSystem = await repo.GetByIdAsync<VisionSystem>(id);

         visionSystem.Description = description;
         visionSystem.CommunicationProtocolId = protocolId;
         visionSystem.ModelReference = modelReference;
         visionSystem.GuaranteePeriod = guaranteePeriod;
         visionSystem.hasBuiltInController = hasBuiltInController;
         visionSystem.hasBuiltInLight = hasBuiltInLight;
         visionSystem.hasBuiltInLens = hasBuiltInLens;
         visionSystem.DatasheetUrl = dataSheetUrl;
         visionSystem.ImageUrl = ImageUrl;
         visionSystem.Price = price;


         await repo.SaveChangesAsync();
      }

      public async Task<bool> HasAgentWithId(Guid productGuid, Guid agentId)
      {
         var product = await repo.GetByIdAsync<Product>(productGuid);
         return product.SalesAgentId == agentId;
      }

      public async Task Delete(Guid productId)
      {
         var product = await repo.GetByIdAsync<Product>(productId);

         product.isDeleted = true;

         await repo.SaveChangesAsync();
      }
   }
}
