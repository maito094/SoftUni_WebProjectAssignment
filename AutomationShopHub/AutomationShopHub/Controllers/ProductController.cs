using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.Enum;
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
      public async Task<IActionResult> All([FromQuery] AllProductsQueryModel query)
      {
         var result = await productService.All(
            query.Category,
            query.SearchTerm,
            query.Sorting,
            query.CurrentPage,
            AllProductsQueryModel.ProductsPerPage);

         query.TotalProductsCount = result.TotalProductsCount;
         var categories = await productService.AllCategories();
         query.Categories = categories.Select(c => c.Name).ToList();
         query.Products = result.Products;

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
      [Route("Product/Details/{guidId}", Name = "getProductDetails")]
      public async Task<IActionResult> Details(Guid guidId)
      {
         if ((await productService.ProductExists(guidId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid Product!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }

         var product = await productService.GetProductByIdAsync(guidId);

         IProductType? productType;

         switch (product.Category.Name)
         {
            case nameof(ProductTypeEnum.Robot):
               productType = await productService.GetRobotByProductId(product.Id);
               break;
            case nameof(ProductTypeEnum.PLC):
               productType = await productService.GetPLCByProductId(product.Id);
               break;
            case nameof(ProductTypeEnum.Sensor):
               productType = await productService.GetSensorByProductId(product.Id);
               break;
            case nameof(ProductTypeEnum.VisionSystem):
               productType = await productService.GetVisionSystemByProductId(product.Id);
               break;


            default:
               TempData[MessageConstant.ErrorMessage] = "Invalid Category ";
               return RedirectToAction("Index", "Home", new { area = "" });
               break;
         }

         if (productType is null)
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid Product Type!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }

         var productModel = new ProductDetailModel()
         {
            Id = product.Id,
            ProductTypeId = productType.Id,
            ProductType = productType,
            Name = product.Name,
            Description = product.Description,
            ProductDateAdded = product.ProductDateAdded,
            Brand = product.Brand.Name,
            Category = product.Category.Name,
            SalesAgentEmail = product.SalesAgent.AgentName,
            SalesAgentPhoneNumber = product.SalesAgent.TelephoneNumber,
            SalesAgentProfileURL = product.SalesAgent.ImageProfileUrl,
            Comments = product.Comments

         };

         return View(productModel);
      }

      [HttpGet]
      public IActionResult Add()
      {
         var productModel = new ProductFormModel();
         return View(productModel);

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
