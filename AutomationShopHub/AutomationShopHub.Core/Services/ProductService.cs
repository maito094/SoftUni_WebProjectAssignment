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


      public IQueryable<PLCModel> AllPLCsQuery()
      {
         return repo.AllReadonly<PLC>()
                     .Include(pr => pr.Product)
                     .Include(pl => pl.Product.SalesAgent)
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

      //TODO Add all other products to the Query
      public IQueryable<ProductModel> AllProductsQuery()
      {
         var plcs = AllPLCsQuery();

         var products = plcs.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new PLCModel()
            {
               Id = pl.Id,
               ProductId= pl.ProductId,
               Product= pl.Product,
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
         }).AsQueryable();

         return products;
      }

      public async Task<IEnumerable<ProductModel>> AllProducts()
      {
         var plcs = AllPLCsQuery();

         var products = await plcs.Select(pl => new ProductModel()
         {
            Id = pl.ProductId,
            Name = pl.Product.Name,
            ProductType = new PLCModel()
            {
               Id = pl.Id,
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
         }).ToListAsync();

         return products;
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

      public async Task<ProductModel> GetProductByIdAsync(Guid id)
      {
         var product = await repo.AllReadonly<Product>()
            .Where(p => p.Id == id)
             .Include(c => c.Category)
             .Include(b => b.Brand)
             .Include(s => s.SalesAgent)
             .FirstOrDefaultAsync();

         return new ProductModel()
         {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            ProductDateAdded = product.ProductDateAdded,
            ProductDateModified = product.ProductDateModified,
            SalesAgentId = product.SalesAgentId,
            SalesAgent = new SalesAgentModel(),
            BrandId = product.BrandId,
            Brand = new BrandModel(),
            CategoryId = product.CategoryId,
            Category = new CategoryModel(),
            isDeleted = false,
            Comments = new List<CommentModel>(),
            OrderProducts = new List<OrderProductModel>(),

         };
      }

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

      public async Task<bool> CategoryExists(int id)
      {
         return await repo.AllReadonly<Category>().AnyAsync(c => c.Id == id);
      }

      public async Task<bool> BrandExists(int id)
      {
         return await repo.AllReadonly<Brand>().AnyAsync(b => b.Id == id);

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

      public async Task<bool> RobotTypeExists(int id)
      {
         return await repo.AllReadonly<RobotType>().AnyAsync(rt => rt.Id == id);

      }

      public async Task<bool> ProtocolExists(int id)
      {
         return await repo.AllReadonly<IndustrialProtocol>().AnyAsync(ip => ip.Id == id);

      }

      public Task<IEnumerable<PLCModel>> AllPLCs()
      {
         throw new NotImplementedException();
      }

      public async Task<ProductQueryModel> All(string? category = null, string? searchTerm = null, ProductSorting sorting = ProductSorting.Newest, int currentPage = 1, int productsPerPage = 1)
      {
         var productsList = new ProductQueryModel();

         var products = AllProductsQuery(); //repo.AllReadonly<Product>();

         if (string.IsNullOrEmpty(category) == false)
         {
            products = products
                     .Where(p => p.Category.Name == category);
         }

         if (string.IsNullOrEmpty(searchTerm) == false)
         {
            searchTerm = $"%{searchTerm.ToLower()}%";
            products = products
                     .Where(p => EF.Functions.Like(p.Name.ToLower(), searchTerm) ||
                        EF.Functions.Like(p.Description.ToLower(), searchTerm) ||
                       EF.Functions.Like(p.Brand.Name.ToLower(), searchTerm));
         }

         products = sorting switch
         {
            ProductSorting.Price => products
            .OrderBy(p => p.ProductType.Price),
            ProductSorting.Brand => products
            .OrderBy(p => p.Brand.Name),
            ProductSorting.Newest => products
            .OrderByDescending(p => p.ProductDateAdded),
            _ => products
            .OrderByDescending(p => p.ProductDateAdded),
         };

         productsList.Products = await products
           .Skip((currentPage - 1) * productsPerPage)
           .Take(productsPerPage)
           .ToListAsync();

         productsList.TotalProductsCount = await products.CountAsync();

         return productsList;
      }

      public async Task<IEnumerable<ProductModel>> AllProductsByAgentId(Guid agentId)
      {
         var products = AllProductsQuery().Where(p => p.SalesAgentId == agentId);


         return await products.ToListAsync();
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
   }
}
