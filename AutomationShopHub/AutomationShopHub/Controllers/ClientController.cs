using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Controllers
{
   [Authorize]
   public class ClientController : Controller
   {
      private readonly IClientService clientService;

      private readonly UserManager<IdentityUser> userManager;
      private readonly SignInManager<IdentityUser> signInManager;

      public ClientController(IClientService _clientService,
                  UserManager<IdentityUser> _userManager,
                  SignInManager<IdentityUser> _signInManager)
      {
         clientService = _clientService;
         userManager = _userManager;
         signInManager = _signInManager;
      }

      [HttpGet]
      public async Task<IActionResult> Become()
      {
         if (await clientService.ExistById(User.Id()))
         {
            TempData[MessageConstant.ErrorMessage] = "You are already a Client!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }

         var model = new BecomeClientModel();

         return View(model);
      }

      [HttpPost]
      public async Task<IActionResult> Become(BecomeClientModel model)
      {
         var userId = User.Id();
         var userEmail = User.Email();

         if (!ModelState.IsValid)
         {
            return View(model);
         }

         if (await clientService.ExistById(userId))
         {
            TempData[MessageConstant.ErrorMessage] = "You are already a Client!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }
         if (await clientService.UserWithPhoneExists(model.TelephoneNumber))
         {
            TempData[MessageConstant.ErrorMessage] = "Phone is already used, not correct or invalid!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }
         if (await clientService.UserWithEmailExists(userEmail))
         {
            TempData[MessageConstant.ErrorMessage] = "Email is already used, not correct or invalid!";
            return RedirectToAction("Index", "Home", new { area = "" });
         }



         await clientService.Create(userId, model.TelephoneNumber,model.DeliveryAddress, model.ImageProfileUrl);

         var user = await userManager.FindByIdAsync(userId);


         var result = await userManager.AddToRoleAsync(user, "Client");
         if (result.Succeeded)
         {

            await signInManager.SignOutAsync();
            TempData[MessageConstant.SuccessMessage] = "You are now a Client! Login again to start ordering automation products!";
            // TODO When custom LoginPage is created use it's link
            return RedirectToAction("Login", "Account", new { area = "Identity" });
         }

         return View(model);

      }
   }
}
