using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Models;
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
      public async Task<IActionResult> All([FromQuery]AllProductsQueryModel query)
      {
         var result = await productService.All(
            query.Category,
            query.SearchTerm,
            query.Sorting,
            query.CurrentPage,
            AllProductsQueryModel.ProductsPerPage);

         query.TotalProductsCount = result.TotalProductsCount;
         var categories = await productService.AllCategories();
         query.Categories = categories.Select(c=>c.Name).ToList();
         query.Products=result.Products;

         //var productModel = await productService.AllProducts();
         //return View(productModel);
         return View(query);
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
