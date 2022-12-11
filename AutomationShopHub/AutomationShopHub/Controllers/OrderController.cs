using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AutomationShopHub.Controllers
{
   [Authorize(Roles = "Client")]
   public class OrderController : Controller
   {
      private readonly string orderIdKey = "orderId";
      private readonly IClientService clientService;
      private readonly IOrderService orderService;
      private readonly IProductService productService;
      public OrderController(
                  IClientService _clientService,
                  IOrderService _orderService,
                  IProductService _productService)
      {
         clientService = _clientService;
         orderService = _orderService;
         productService = _productService;
      }
      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public async Task<IActionResult> MineOrder()
      {
         var client = await clientService.GetClientByUserId(User.Id());
         var orderIdSession = HttpContext.Session.GetString(orderIdKey);

         if (string.IsNullOrEmpty(orderIdSession))
         {
            TempData[MessageConstant.ErrorMessage] = "No Available Items to Confirm Purchase";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         var allProductOrderModel = await orderService.AllProductsByOrderByClientId(client.Id, orderIdSession);

         return View(allProductOrderModel);
      }

      public async Task<IActionResult> ConfirmOrder(decimal totalSum)
      {

         var orderIdSession = HttpContext.Session.GetString(orderIdKey);

         if (string.IsNullOrEmpty(orderIdSession))
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid Order Confirmation!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         await orderService.ConfirmOrder(orderIdSession,totalSum);


         HttpContext.Session.SetString(orderIdKey, "");

         return RedirectToAction("All", "Product", new { area = "" });

      }



      [Route("/Order/AddOrder/{id}")]
      public async Task<IActionResult> AddOrder(Guid id)
      {
         var client = await clientService.GetClientByUserId(User.Id());

         var productModel = await productService.GetProductByIdAsync(id);

         var orderIdSession = HttpContext.Session.GetString(orderIdKey);


         if (productModel == null)
         {
            TempData[MessageConstant.ErrorMessage] = "Product is not found!";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         if (string.IsNullOrEmpty(orderIdSession))
         {
            var orderId = await orderService.CreateOrder(new OrderModel()
            {
               ClientId = client.Id,
               Client = client,
               SalesAgentId = productModel.SalesAgentId,
               SalesAgent = productModel.SalesAgent,
               DeliveryAddress = client.DeliveryAddress,
               isConfirmed = false,
               isDeleted = false,
               TotalAmount = 0,
               OrderDateCreated = DateTime.Now,
               OrderProducts = productModel.OrderProducts,
            });

            HttpContext.Session.SetString(orderIdKey, orderId.ToString());

         }

         orderIdSession = HttpContext.Session.GetString(orderIdKey);
         var oderModel = await orderService.GetOrderById(orderIdSession);


         await orderService.OrderProduct(oderModel, productModel);


         return RedirectToAction("All", "Product", new { area = "" });
      }


      [Route("/Order/Remove/{id}")]
      public async Task<IActionResult> Remove(Guid id)
      {
         var orderIdSession = HttpContext.Session.GetString(orderIdKey);

         if (string.IsNullOrEmpty(orderIdSession))
         {
            TempData[MessageConstant.ErrorMessage] = "You are don't have an Order!";
            return RedirectToAction("All", "Product", new { area = "" });
         }
         if ((await productService.ProductExists(id)) == false)
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid Product";
            return RedirectToAction("All", "Product", new { area = "" });
         }

         await orderService.RemoveFromOrder(id, orderIdSession);

         return RedirectToAction("All", "Product", new { area = "" });

      }

   }
}
