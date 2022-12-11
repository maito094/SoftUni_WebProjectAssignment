using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using AutomationShopHub.Extensions;
using AutomationShopHub.Models.Product;
using AutomationShopHub.Models.ProductTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize(Roles = "Agent")]
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
         if ((await agentService.ExistById(userId)) == false)
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
            model.Brands = await productService.AllBrands();
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


      // Add Robot 
      [HttpGet]
      [Route("Agent/Product/Add/Robot/{id}")]
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
      [Route("Agent/Product/Add/Robot/{id}")]
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
            ModelState.AddModelError(nameof(modelForm.CommunicationProtocolId), "Protocol type does not exist!");
         }



         if (!ModelState.IsValid)
         {
            modelForm.RobotTypes = await productService.AllRobotTypes();
            modelForm.IndustrialProtocols = await productService.AllProtocolTypes();
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

         return RedirectToAction($"Details", new { area = "", guidId = model.ProductId, id = robotId });
      }


      // Add PLC
      [HttpGet]
      [Route("Agent/Product/Add/PLC/{id}")]
      public async Task<IActionResult> AddPLC(Guid id)
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

         var model = new PLCFormModel()
         {
            IndustrialProtocols = await productService.AllProtocolTypes()
         };

         return View(model);

      }
      [HttpPost]
      [Route("Agent/Product/Add/PLC/{id}")]
      public async Task<IActionResult> AddPLC(PLCFormModel modelForm, Guid id)
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

         if ((await productService.ProtocolExists(modelForm.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.CommunicationProtocolId), "Protocol type does not exist!");
         }



         if (!ModelState.IsValid)
         {
            modelForm.IndustrialProtocols = await productService.AllProtocolTypes();
            return View(modelForm);
         }

         if (productModel.SalesAgentId != salesAgentModel.SalesAgentId)
         {
            return BadRequest();
         }

         var model = new PLCModel()
         {
            ProductId = productModel.Id,
            Product = productModel,
            CommunicationProtocolId = modelForm.CommunicationProtocolId,
            Protocol = await productService.GetProtocolType(modelForm.CommunicationProtocolId),
            ModelReference = modelForm.ModelReference,
            Description = modelForm.Description,
            MaxInputsOutputs = modelForm.MaxInputsOutputs,
            ScanTime = modelForm.ScanTime,
            Price = modelForm.Price,
            GuaranteePeriod = modelForm.GuaranteePeriod,
            DatasheetUrl = modelForm.DatasheetUrl,
            ImageUrl = modelForm.ImageUrl,
         };

         int plcId = await productService.CreatePLC(model);

         return RedirectToAction($"Details", new { area = "", guidId = model.ProductId, id = plcId });
      }


      // Add VisionSystem
      [HttpGet]
      [Route("Agent/Product/Add/VisionSystem/{id}")]
      public async Task<IActionResult> AddVisionSystem(Guid id)
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

         var model = new VisionSystemFormModel()
         {
            IndustrialProtocols = await productService.AllProtocolTypes()
         };

         return View(model);

      }
      [HttpPost]
      [Route("Agent/Product/Add/VisionSystem/{id}")]
      public async Task<IActionResult> AddVisionSystem(VisionSystemFormModel modelForm, Guid id)
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

         if ((await productService.ProtocolExists(modelForm.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.CommunicationProtocolId), "Protocol type does not exist!");
         }



         if (!ModelState.IsValid)
         {
            modelForm.IndustrialProtocols = await productService.AllProtocolTypes();
            return View(modelForm);
         }

         if (productModel.SalesAgentId != salesAgentModel.SalesAgentId)
         {
            return BadRequest();
         }

         var model = new VisionSystemModel()
         {
            ProductId = productModel.Id,
            Product = productModel,
            CommunicationProtocolId = modelForm.CommunicationProtocolId,
            Protocol = await productService.GetProtocolType(modelForm.CommunicationProtocolId),
            ModelReference = modelForm.ModelReference,
            Description = modelForm.Description,
            hasBuiltInController = modelForm.hasBuiltInController,
            hasBuiltInLens = modelForm.hasBuiltInLens,
            hasBuiltInLight = modelForm.hasBuiltInLight,
            Price = modelForm.Price,
            GuaranteePeriod = modelForm.GuaranteePeriod,
            DatasheetUrl = modelForm.DatasheetUrl,
            ImageUrl = modelForm.ImageUrl,
         };

         int visionSystemId = await productService.CreateVisionSystem(model);

         return RedirectToAction($"Details", new { area = "", guidId = model.ProductId, id = visionSystemId });
      }


      // Add Sensor
      [HttpGet]
      [Route("Agent/Product/Add/Sensor/{id}")]
      public async Task<IActionResult> AddSensor(Guid id)
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

         var model = new SensorFormModel()
         {
            IndustrialProtocols = await productService.AllProtocolTypes(),
            SensorTypes = await productService.AllSensorTypes()
         };

         return View(model);

      }
      [HttpPost]
      [Route("Agent/Product/Add/Sensor/{id}")]
      public async Task<IActionResult> AddSensor(SensorFormModel modelForm, Guid id)
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


         if ((await productService.SensorTypeExists(modelForm.SensorTypeId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.SensorTypeId), "Sensor type does not exist!");
         }
         if ((await productService.ProtocolExists(modelForm.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError(nameof(modelForm.CommunicationProtocolId), "Protocol type does not exist!");
         }



         if (!ModelState.IsValid)
         {
            modelForm.SensorTypes = await productService.AllSensorTypes();
            modelForm.IndustrialProtocols = await productService.AllProtocolTypes();
            return View(modelForm);
         }

         if (productModel.SalesAgentId != salesAgentModel.SalesAgentId)
         {
            return BadRequest();
         }

         var model = new SensorModel()
         {
            ProductId = productModel.Id,
            Product = productModel,
            SensorTypeId = modelForm.SensorTypeId,
            Type = await productService.GetSensorType(modelForm.SensorTypeId),
            CommunicationProtocolId = modelForm.CommunicationProtocolId,
            Protocol = await productService.GetProtocolType(modelForm.CommunicationProtocolId),
            ModelReference = modelForm.ModelReference,
            Description = modelForm.Description,
            isDiscreteType = modelForm.isDiscreteType,
            isRangeAdjustable = modelForm.isRangeAdjustable,
            Price = modelForm.Price,
            GuaranteePeriod = modelForm.GuaranteePeriod,
            DatasheetUrl = modelForm.DatasheetUrl,
            ImageUrl = modelForm.ImageUrl,
         };

         int sensorId = await productService.CreateSensor(model);

         return RedirectToAction($"Details", new { area = "", guidId = model.ProductId, id = sensorId });
      }




      [HttpGet]
      [Route("Agent/Product/Edit/{id}")]
      public async Task<IActionResult> Edit(Guid id)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());

         if ((await productService.ProductExists(id)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Product is Not Found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }
         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("Index", "Home", new { area = "" });

         }

         var product = await productService.GetProductByIdAsync(id);

         var productFormModel = new ProductFormModel()
         {
            Id = product.Id,
            Name = product.Name,
            BrandId = product.BrandId,
            Brands = await productService.AllBrands(),
            CategoryId = product.CategoryId,
            Categories = await productService.AllCategories(),
            Description = product.Description,
         };

         return View(productFormModel);
      }

      [HttpPost]
      [Route("Agent/Product/Edit/{id}")]
      public async Task<IActionResult> Edit(Guid id, ProductFormModel model)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());

         if ((await productService.ProductExists(id)) == false)
         {
            ModelState.AddModelError(nameof(model.Id), "Product does not exist!");
         }
         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("All", "Product", new { area = "" });

         }
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
            model.Brands = await productService.AllBrands();

            return View(model);

         }


         await productService.Edit(id, model.Name, model.Description, model.BrandId, model.CategoryId, DateTime.Now);

         var category = await productService.GetCategory(model.CategoryId);

         return RedirectToAction($"Edit{category.Name}", "Product", new { area = "Agent", id = id });

      }

      // Edit Robot
      [HttpGet]
      [Route("Agent/Product/Edit/Robot/{id}")]
      public async Task<IActionResult> EditRobot(Guid id)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());
         var robot = await productService.GetRobotByProductId(id);

         if (robot == null)
         {
            TempData[MessageConstant.ErrorMessage] = "Product Type is Not Found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("Index", "Home", new { area = "" });

         }


         var robotFormModel = new RobotFormModel()
         {

            productId = id,
            ModelReference = robot.ModelReference,
            CommunicationProtocolId = robot.CommunicationProtocolId,
            IndustrialProtocols = await productService.AllProtocolTypes(),
            RobotTypeId = robot.RobotTypeId,
            RobotTypes = await productService.AllRobotTypes(),
            DatasheetUrl = robot.DatasheetUrl,
            ImageUrl = robot.ImageUrl,
            GuaranteePeriod = robot.GuaranteePeriod,
            NumberOfAxis = robot.NumberOfAxis,
            Payload = robot.Payload,
            Reach = robot.Reach,
            Speed = robot.Speed,
            Price = robot.Price,
            Description = robot.Description,
         };

         return View(robotFormModel);
      }

      [HttpPost]
      [Route("Agent/Product/Edit/Robot/{id}")]
      public async Task<IActionResult> EditRobot(Guid id, RobotFormModel model)
      {
         var robot = await productService.GetRobotByProductId(id);
         if (robot == null)
         {
            ModelState.AddModelError("", "Product Type does not exist!");
         }
         if ((await productService.RobotTypeExists(model.RobotTypeId)) == false)
         {
            ModelState.AddModelError("", "Robot Type does not exist!");
         }
         if ((await productService.ProtocolExists(model.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError("", "Protocol Type does not exist!");
         }

         if (!ModelState.IsValid)
         {
            model.IndustrialProtocols = await productService.AllProtocolTypes();
            model.RobotTypes = await productService.AllRobotTypes();
            return View(model);
         }
         await productService.EditRobot(
            robot.Id,
            model.Description,
            model.CommunicationProtocolId,
            model.RobotTypeId,
            model.ModelReference,
            model.GuaranteePeriod,
            model.Reach,
            model.Speed,
            model.Payload,
            model.NumberOfAxis,
            model.DatasheetUrl,
            model.ImageUrl,
            model.Price);

         return RedirectToAction("Details", "Product", new { area = "", guidId = id });

      }


      // Edit PLC
      [HttpGet]
      [Route("Agent/Product/Edit/PLC/{id}")]
      public async Task<IActionResult> EditPLC(Guid id)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());
         var plc = await productService.GetPLCByProductId(id);

         if (plc == null)
         {
            TempData[MessageConstant.ErrorMessage] = "Product Type is Not Found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("Index", "Home", new { area = "" });

         }


         var plcFormModel = new PLCFormModel()
         {

            productId = id,
            ModelReference = plc.ModelReference,
            CommunicationProtocolId = plc.CommunicationProtocolId,
            IndustrialProtocols = await productService.AllProtocolTypes(),
            DatasheetUrl = plc.DatasheetUrl,
            ImageUrl = plc.ImageUrl,
            GuaranteePeriod = plc.GuaranteePeriod,
            MaxInputsOutputs = plc.MaxInputsOutputs,
            ScanTime = plc.ScanTime,
            Price = plc.Price,
            Description = plc.Description,
         };

         return View(plcFormModel);
      }
      [HttpPost]
      [Route("Agent/Product/Edit/PLC/{id}")]
      public async Task<IActionResult> EditPLC(Guid id, PLCFormModel model)
      {
         var plc = await productService.GetPLCByProductId(id);

         if (plc == null)
         {
            ModelState.AddModelError("", "Product Type does not exist!");
         }
         if ((await productService.ProtocolExists(model.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError("", "Protocol Type does not exist!");
         }
         if (!ModelState.IsValid)
         {
            model.IndustrialProtocols = await productService.AllProtocolTypes();
            return View(model);
         }
         await productService.EditPLC(
            plc.Id,
            model.Description,
            model.CommunicationProtocolId,
            model.ModelReference,
            model.GuaranteePeriod,
            model.MaxInputsOutputs,
            model.ScanTime,
            model.DatasheetUrl,
            model.ImageUrl,
            model.Price);

         return RedirectToAction("Details", "Product", new { area = "", guidId = id });

      }


      // Edit Sensor
      [HttpGet]
      [Route("Agent/Product/Edit/Sensor/{id}")]
      public async Task<IActionResult> EditSensor(Guid id)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());
         var sensor = await productService.GetSensorByProductId(id);

         if (sensor == null)
         {
            TempData[MessageConstant.ErrorMessage] = "Product Type is Not Found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("Index", "Home", new { area = "" });

         }


         var sensorFormModel = new SensorFormModel()
         {

            productId = id,
            ModelReference = sensor.ModelReference,
            CommunicationProtocolId = sensor.CommunicationProtocolId,
            IndustrialProtocols = await productService.AllProtocolTypes(),
            SensorTypeId = sensor.SensorTypeId,
            SensorTypes = await productService.AllSensorTypes(),
            DatasheetUrl = sensor.DatasheetUrl,
            ImageUrl = sensor.ImageUrl,
            GuaranteePeriod = sensor.GuaranteePeriod,
            isDiscreteType = sensor.isDiscreteType,
            isRangeAdjustable = sensor.isRangeAdjustable,
            Price = sensor.Price,
            Description = sensor.Description,
         };

         return View(sensorFormModel);
      }
      [HttpPost]
      [Route("Agent/Product/Edit/Sensor/{id}")]
      public async Task<IActionResult> EditSensor(Guid id, SensorFormModel model)
      {
         var sensor = await productService.GetSensorByProductId(id);

         if (sensor == null)
         {
            ModelState.AddModelError("", "Product Type does not exist!");
         }
         if ((await productService.SensorTypeExists(model.SensorTypeId)) == false)
         {
            ModelState.AddModelError("", "Sensor Type does not exist!");
         }
         if ((await productService.ProtocolExists(model.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError("", "Protocol Type does not exist!");
         }
         if (!ModelState.IsValid)
         {
            model.IndustrialProtocols = await productService.AllProtocolTypes();
            model.SensorTypes = await productService.AllSensorTypes();
            return View(model);
         }
         await productService.EditSensor(
            sensor.Id,
            model.Description,
            model.CommunicationProtocolId,
            model.SensorTypeId,
            model.ModelReference,
            model.GuaranteePeriod,
            model.isDiscreteType,
            model.isRangeAdjustable,
            model.DatasheetUrl,
            model.ImageUrl,
            model.Price);

         return RedirectToAction("Details", "Product", new { area = "", guidId = id });

      }


      // Edit Vision System
      [HttpGet]
      [Route("Agent/Product/Edit/VisionSystem/{id}")]
      public async Task<IActionResult> EditVisionSystem(Guid id)
      {
         var agent = await agentService.GetAgentByUserId(User.Id());
         var visionSystem = await productService.GetVisionSystemByProductId(id);

         if (visionSystem == null)
         {
            TempData[MessageConstant.ErrorMessage] = "Product Type is Not Found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         if ((await productService.HasAgentWithId(id, agent.SalesAgentId)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Unauthorized access!";
            return RedirectToAction("Index", "Home", new { area = "" });

         }


         var visionSystemFormModel = new VisionSystemFormModel()
         {

            productId = id,
            ModelReference = visionSystem.ModelReference,
            CommunicationProtocolId = visionSystem.CommunicationProtocolId,
            IndustrialProtocols = await productService.AllProtocolTypes(),
            DatasheetUrl = visionSystem.DatasheetUrl,
            ImageUrl = visionSystem.ImageUrl,
            GuaranteePeriod = visionSystem.GuaranteePeriod,
            hasBuiltInController = visionSystem.hasBuiltInController,
            hasBuiltInLens = visionSystem.hasBuiltInLens,
            hasBuiltInLight = visionSystem.hasBuiltInLight,
            Price = visionSystem.Price,
            Description = visionSystem.Description,
         };

         return View(visionSystemFormModel);
      }
      [HttpPost]
      [Route("Agent/Product/Edit/VisionSystem/{id}")]
      public async Task<IActionResult> EditVisionSystem(Guid id, VisionSystemFormModel model)
      {
         var visionSystem = await productService.GetVisionSystemByProductId(id);
         if (visionSystem == null)
         {
            ModelState.AddModelError("", "Product Type does not exist!");
         }
         if ((await productService.ProtocolExists(model.CommunicationProtocolId)) == false)
         {
            ModelState.AddModelError("", "Protocol Type does not exist!");
         }
         if (!ModelState.IsValid)
         {
            model.IndustrialProtocols = await productService.AllProtocolTypes();
            return View(model);
         }
         await productService.EditVisionSystem(
            visionSystem.Id,
            model.Description,
            model.CommunicationProtocolId,
            model.ModelReference,
            model.GuaranteePeriod,
            model.hasBuiltInController,
            model.hasBuiltInLight,
            model.hasBuiltInLens,
            model.DatasheetUrl,
            model.ImageUrl,
            model.Price);

         return RedirectToAction("Details", "Product", new { area = "", guidId = id });

      }


      [Route("Agent/Product/Delete/{id}")]
      public async Task<IActionResult> Delete(Guid id)
      {
         await productService.Delete(id);
         return RedirectToAction("All", "Product", new { area = "" });

      }



   }
}
