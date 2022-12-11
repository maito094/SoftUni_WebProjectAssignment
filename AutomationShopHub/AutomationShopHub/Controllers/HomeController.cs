using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Services;
using AutomationShopHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AutomationShopHub.Controllers
{
   public class HomeController : Controller
   {
      private readonly IProductService productService;
      public HomeController(IProductService _productService)
      {
         productService = _productService;
      }
      public async Task<IActionResult> Index()
      {
         AllProductsQueryModel query = new AllProductsQueryModel();
         
         var result = await productService.All(
         query.Category,
         query.SearchTerm,
         query.Sorting,
         query.CurrentPage,
         4);

         query.TotalProductsCount = result.TotalProductsCount;
         var categories = await productService.AllCategories();
         query.Categories = categories.Select(c => c.Name).ToList();
         query.Products = result.Products;

         return View(query);
      }



      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}