using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
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

      public async Task<IEnumerable<PLCModel>> AllPLCs()
      {

         return await repo.AllReadonly<PLC>()
                                          .Select(p => new PLCModel()
                                          {
                                             Id = p.Id,
                                             ProductId = p.ProductId,
                                             Product = new ProductModel()
                                             {
                                                Id = p.ProductId,
                                                BrandId = p.Product.BrandId,
                                                Brand = p.Product.Brand,
                                                ProductDateAdded = p.Product.ProductDateAdded,
                                                ProductDateModified = p.Product.ProductDateModified,
                                                OrderProducts = p.Product.OrderProducts,
                                                CategoryId = p.Product.CategoryId,
                                                Category = p.Product.Category,
                                                Comments = p.Product.Comments,
                                                Description = p.Description,
                                                isDeleted = p.Product.isDeleted,
                                                Name = p.Product.Name,
                                                SalesAgentId = p.Product.SalesAgentId,
                                                SalesAgent = new SalesAgent()
                                                {
                                                   Id = p.Product.SalesAgent.Id,
                                                   ImageProfileUrl = p.Product.SalesAgent.ImageProfileUrl,
                                                   Orders = p.Product.SalesAgent.Orders,
                                                   TelephoneNumber = p.Product.SalesAgent.TelephoneNumber,
                                                   UserId = p.Product.SalesAgent.UserId,
                                                   User = p.Product.SalesAgent.User
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

                                          }).ToListAsync();
      }

      public async Task<IEnumerable<ProductModel>> AllProducts()
      {
         var plcs = await AllPLCs();

         var products = plcs.Select(pl => new ProductModel()
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
               DatasheetUrl=pl.DatasheetUrl,
               ImageUrl=pl.ImageUrl
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
            SalesAgent = new SalesAgent()
            {
                Id=pl.Product.SalesAgent.Id,
                ImageProfileUrl=pl.Product.SalesAgent.ImageProfileUrl,
                Orders=pl.Product.SalesAgent.Orders,
                TelephoneNumber=pl.Product.SalesAgent.TelephoneNumber,
                UserId=pl.Product.SalesAgent.UserId,
                User=pl.Product.SalesAgent.User
            }
         });


         //List<ProductModel> product = await repo.AllReadonly<Product>()
         //            .Select(p => new ProductModel()
         //            {
         //               Id = p.Id,
         //               Name = p.Name,
         //               SalesAgent = p.SalesAgent.User.UserName,
         //               Brand = p.Brand.Name,
         //               Category = p.Category.Name

         //            })
         //            .ToListAsync();



         return products;
      }
   }
}
