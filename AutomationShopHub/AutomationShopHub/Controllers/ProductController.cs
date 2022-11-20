using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Controllers
{
   [Authorize]
   public class ProductController : Controller
   {
      private readonly IProductService productService;
      public ProductController(IProductService _productService)
      {
         productService = _productService;
      }

      public async Task<IActionResult> All()
      {
         var productModel = await productService.AllProducts();
         return View(productModel);
      }
      public async Task<IActionResult> Details(Guid id)
      {
         var productModel = new ProductDetailModel();
         return View(productModel);
      }
   }
}
