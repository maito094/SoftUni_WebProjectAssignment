using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Controllers
{
   public class AccountController : Controller
   {
      private readonly SignInManager<IdentityUser> signInManager;
      public AccountController(SignInManager<IdentityUser> _signInManager)
      {
         signInManager = _signInManager;
      }

      public async Task<IActionResult> Logout()
      {
         await signInManager.SignOutAsync();
         HttpContext.Session.SetString("orderId", "");
         HttpContext.Session.Clear();

         return RedirectToAction("Index", "Home");
      }
   }
}
