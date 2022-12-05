using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using AutomationShopHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize(Roles ="Agent")]
   [Area("Agent")]
   
   public class ProductController : Controller
   {
      private readonly IProductService productService;
      private readonly IAgentService agentService;
      public ProductController(IProductService _productService,
         IAgentService _agentService)
      {
         productService = _productService;
         agentService = _agentService;
      }


      [HttpGet]
      //TODO Mine Product Models
      public async Task<IActionResult> Mine()
      {
         IEnumerable<ProductModel> myProducts;

         var userId = User.Id();
         if ((await agentService.ExistById(userId))==false)
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid Agent!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }
         var agent = await agentService.GetAgentByUserId(userId);
         myProducts = await productService.AllProductsByAgentId(agent.SalesAgentId);


         var productModel = new ProductQueryModel();
         productModel.Products = myProducts;
         productModel.TotalProductsCount = myProducts.Count();

         return View(productModel);
      }


      [HttpGet]
      [Route("Agent/Product/Add", Name = "area")]
      public async Task<IActionResult> Add()
      {
         var productModel = new ProductFormModel()
         {
            Categories = await productService.AllCategories(),
            Brands = await productService.AllBrands()
         };

         return View(productModel);

      }

      [HttpPost]
      [Route("Agent/Product/Add", Name = "area")]
      public async Task<IActionResult> Add(ProductFormModel model)
      {

         if ((await productService.CategoryExists(model.CategoryId)) == false)
         {
            ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
         }
         if ((await productService.BrandExists(model.BrandId)) == false)
         {
            ModelState.AddModelError(nameof(model.BrandId), "Brand does not exist!");
         }

         if (!ModelState.IsValid)
         {
            model.Categories = await productService.AllCategories();
            model.Brands= await productService.AllBrands();
            return View(model);
         }

         var salesAgentUserId = User.Id();
         var salesAgentModel = await agentService.GetAgentByUserId(salesAgentUserId);
         var productModel = new ProductModel()
         {
            Id = model.Id,
            CategoryId = model.CategoryId,
            Category = await productService.GetCategory(model.CategoryId),
            BrandId = model.BrandId,
            Brand = await productService.GetBrand(model.BrandId),
            isDeleted = false,
            ProductDateAdded = DateTime.Now,
            Name = model.Name,
            Description = model.Description,
            SalesAgentId = salesAgentModel.SalesAgentId,
            SalesAgent = salesAgentModel,

         };

         var productId = await productService.CreateProduct(productModel);

         return RedirectToAction($"Add{productModel.Category.Name}", new { id = productId });

      }

      [HttpGet]
      [Route("Agent/Product/Add/Robot/{id}", Name = "addProduct")]
      public async Task<IActionResult> AddRobot(Guid id)
      {
         var productModel = new ProductModel();
         var salesAgentModel = new SalesAgentModel();

         try
         {
            productModel = await productService.GetProductByIdAsync(id);
            salesAgentModel = await agentService.GetAgentByUserId(User.Id());
         }
         catch (Exception)
         {

            return BadRequest();
         }

         if (productModel.SalesAgentId != salesAgentModel.SalesAgentId)
         {
            return BadRequest();
         }

         var model = new RobotFormModel()
         {
            IndustrialProtocols = await productService.AllProtocolTypes(),
            RobotTypes = await productService.AllRobotTypes()
         };

         return View(model);

      }
      [HttpPost]
      [Route("Agent/Product/Add/Robot/{id}", Name = "addProduct")]
      public async Task<IActionResult> AddRobot(RobotFormModel modelForm, Guid id)
      {
         var salesAgentModel = new SalesAgentModel();
         var productModel = new ProductModel();

         try
         {
            productModel = await productService.GetProductByIdAsync(id);
            salesAgentModel = await agentService.GetAgentByUserId(User.Id());
         }
         catch (Exception)
         {

            return BadRequest();
         }
         

         if ((await productService.RobotTypeExists(modelForm.RobotTypeId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.RobotTypeId), "Robot type does not exist!");
         }
         if ((await productService.ProtocolExists(modelForm.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.CommunicationProtocolId), "Robot type does not exist!");
         }



         if (!ModelState.IsValid)
         {
            modelForm.RobotTypes= await productService.AllRobotTypes();
            modelForm.IndustrialProtocols=await productService.AllProtocolTypes();
            return View(modelForm);
         }

         if (productModel.SalesAgentId != salesAgentModel.SalesAgentId)
         {
            return BadRequest();
         }

         var model = new RobotModel()
         {
            ProductId = productModel.Id,
            Product = productModel,
            RobotTypeId = modelForm.RobotTypeId,
            RobotType = await productService.GetRobotType(modelForm.RobotTypeId),
            CommunicationProtocolId = modelForm.CommunicationProtocolId,
            IndustrialProtocols = await productService.GetProtocolType(modelForm.CommunicationProtocolId),
            ModelReference = modelForm.ModelReference,
            Description = modelForm.Description,
            NumberOfAxis = modelForm.NumberOfAxis,
            Payload = modelForm.Payload,
            Reach = modelForm.Reach,
            Speed = modelForm.Speed,
            Price = modelForm.Price,
            GuaranteePeriod = modelForm.GuaranteePeriod,
            DatasheetUrl = modelForm.DatasheetUrl,
            ImageUrl = modelForm.ImageUrl,
         };

         int robotId = await productService.CreateRobot(model);

         return RedirectToAction($"Details", new { area = "", guid= model.ProductId, id = robotId });
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
