using AutomationShopHub.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Controllers
{
   [Authorize]
   public class ProductController : Controller
   {
      public async Task<IActionResult> All()
      {
         var productModel = new ProductModel();
         return View(productModel);
      } 
      public async Task<IActionResult> Details(Guid id)
      {
         var productModel = new ProductDetailModel();
         return View(productModel);
      }
   }
}
