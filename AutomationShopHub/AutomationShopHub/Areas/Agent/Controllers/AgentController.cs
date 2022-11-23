
using AutomationShopHub.Core.Constants;
using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize]
   [Area("Agent")]
   public class AgentController : Controller
   {
      private readonly IAgentService agentService;
      private readonly UserManager<IdentityUser> userManager;
      private readonly SignInManager<IdentityUser> signInManager;
      public AgentController(IAgentService _agentService,
                  UserManager<IdentityUser> _userManager,
                  SignInManager<IdentityUser> _signInManager)
      {
         agentService = _agentService;
         userManager = _userManager;
         signInManager = _signInManager;
      }

      [HttpGet]
      public async Task<IActionResult> Become()
      {

         if (await agentService.ExistById(User.Id()))
         {
            TempData[MessageConstant.ErrorMessage] = "You are already a Sales agent!";
            return RedirectToAction("Index", "Home");
         }

         var model = new BecomeSalesAgentModel();
        
         return View(model);
      }

      [HttpPost]
      public async Task<IActionResult> Become(BecomeSalesAgentModel model)
      {
         var userId = User.Id();
         var userEmail = User.Email();

         if (!ModelState.IsValid)
         {
            return View();
         }

         if (await agentService.ExistById(userId))
         {
            TempData[MessageConstant.ErrorMessage] = "You are already a Sales agent!";
            return RedirectToAction("Index", "Home");
         }
         if (await agentService.UserWithPhoneExists(model.TelephoneNumber))
         {
            TempData[MessageConstant.ErrorMessage] = "Phone is already used, not correct or invalid!";
            return RedirectToAction("Index", "Home");
         }
         if (await agentService.UserWithEmailExists(userEmail))
         {
            TempData[MessageConstant.ErrorMessage] = "Email is already used, not correct or invalid!";
            return RedirectToAction("Index", "Home");
         }

         

         await agentService.Create(userId, model.TelephoneNumber, model.ImageProfileUrl);

         var user = await userManager.FindByIdAsync(userId);


         await userManager.AddToRoleAsync(user, "Agent");
         await signInManager.SignOutAsync();

         return RedirectToAction("Login", "Account");
      }
   }
}
