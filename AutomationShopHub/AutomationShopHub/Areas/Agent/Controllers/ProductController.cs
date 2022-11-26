using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize]
   [Area("Agent")]
   public class ProductController : Controller
   {
      private readonly IProductService productService;
      public ProductController(IProductService _productService)
      {
         productService = _productService;
      }

 
      [HttpGet]
      //TODO Mine Product Models
      public async Task<IActionResult> Mine(Guid id)
      {
         var productModel = new ProductModel();
         return View(productModel);
      }


      [HttpGet]
      [Route("Agent/Product/Add",Name ="area")]
      public async Task<IActionResult> Add()
      {
         var productModel = new ProductFormModel(); 
         productModel.Categories= await productService.AllCategories();
         productModel.Brands= await productService.AllBrands();

       return  View(productModel);

      }
      [HttpGet]
      [Route("Agent/Product/Add/Robot",Name = "addProduct")]
      public async Task<IActionResult> AddRobot()
      {
         var model = new RobotModel();

       return  View(model);

      }
      [HttpPost]
      public async Task<IActionResult> Add(ProductModel productModel)
      {
         Guid id = new Guid();

         return RedirectToAction("Details", new { id });
      }


      [HttpGet]
      public async Task<IActionResult> Edit(Guid id)
      {
         var productModel = new ProductModel();
         return View(productModel);
      }

      [HttpPost]
      public async Task<IActionResult> Edit(Guid id, ProductModel productModel)
      {

         return View("Details", new { id });
      }

      [HttpPost]
      public async Task<IActionResult> Delete(Guid id)
      {
         return RedirectToAction("All");
      } 



   }
}
