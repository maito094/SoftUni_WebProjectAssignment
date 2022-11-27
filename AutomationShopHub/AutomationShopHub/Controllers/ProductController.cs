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

      [HttpGet]
      public async Task<IActionResult> All()
      {
         var productModel = await productService.AllProducts();
         return View(productModel);
      }

      [HttpGet]
      //TODO Mine Product Models
      public async Task<IActionResult> Mine(Guid id)
      {
         var productModel = new ProductModel();
         return View(productModel);
      }

      [HttpGet]
      [Route("Product/Details/{guid}/{id}", Name = "getProductDetails")]
      public async Task<IActionResult> Details(Guid guidId, int id)
      {
         var productModel = new ProductDetailModel();
         productModel.Description = id.ToString();
         return View(productModel);
      }

      [HttpGet]
      public IActionResult Add()
      {
         var productModel = new ProductFormModel(); 
       return  View(productModel);

      }
      [HttpPost]
      public async Task<IActionResult> Add(ProductModel productModel)
      {
         Guid id = new Guid();

         return RedirectToAction(nameof(Details), new { id });
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

         return View(nameof(Details), new { id });
      }

      [HttpPost]
      public async Task<IActionResult> Delete(Guid id)
      {
         return RedirectToAction(nameof(All));
      } 
      [HttpPost]
      public async Task<IActionResult> Order(Guid id)
      {
         return RedirectToAction(nameof(Mine));
      }  
    


   }
}
