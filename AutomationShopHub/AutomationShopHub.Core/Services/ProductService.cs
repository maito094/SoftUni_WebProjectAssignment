using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
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

        public async Task<IEnumerable<ProductModel>> AllProducts()
        {
            return await repo.AllReadonly<Product>()
                        .Select(p=> new ProductModel()
                        {
                            Id=p.Id,
                            Name = p.Name,
                            SalesAgent=p.SalesAgent.User.UserName,
                            Brand=p.Brand.Name,
                            Category=p.Category.Name
                        })
                        .ToListAsync();
        }
    }
}
