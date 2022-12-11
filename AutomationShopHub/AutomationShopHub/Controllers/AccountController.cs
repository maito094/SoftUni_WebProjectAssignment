using AutomationShopHub.Core.Constants;
using AutomationShopHub.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Controllers
{
   public class AccountController : Controller
   {
      private readonly UserManager<IdentityUser> userManager;
      private readonly SignInManager<IdentityUser> signInManager;
      public AccountController(
           SignInManager<IdentityUser> _signInManager
         , UserManager<IdentityUser> _userManager)
      {
         signInManager = _signInManager;
         userManager = _userManager;
      }


      [Authorize]
      [HttpGet]
      [Route("Account/Index")]
      public async Task<IActionResult> Index()
      {


         var user = await userManager.GetUserAsync(User);
         if (user == null)
         {
            TempData[MessageConstant.ErrorMessage] = $"Unable to load user with ID '{userManager.GetUserId(User)}'.";
            return RedirectToAction("Index", "Home", new { area = "" });
         }

         var userName = await userManager.GetUserNameAsync(user);

         var userModel = new IndexModel();

         userModel.Username = userName;

         return View(userModel);
      }

      [Authorize]
      [HttpPost]
      [Route("Account/Index")]

      public async Task<IActionResult> Index(IndexModel model)
      {
         var user = await userManager.GetUserAsync(User);
         if (user == null)
         {
            TempData[MessageConstant.ErrorMessage] = $"Unable to load user with ID '{userManager.GetUserId(User)}'.";
            return RedirectToAction("Index", "Home", new { area = "" });
         }

         if (!ModelState.IsValid)
         {
            TempData[MessageConstant.ErrorMessage] = "Invalid User properties!";

            var userName = await userManager.GetUserNameAsync(user);

            return View(model);
         }

         var result = await userManager.SetUserNameAsync(user, model.Username);

         await signInManager.RefreshSignInAsync(user);

         if (result.Succeeded)
         {
            TempData[MessageConstant.SuccessMessage] = "Your Username has been updated";

         }
         else
         {
            TempData[MessageConstant.ErrorMessage] = "The Username was not able to be updated!";

         }
         return RedirectToAction("Index", "Home", new { area = "" });

      }

      public async Task<IActionResult> Logout()
      {
         await signInManager.SignOutAsync();
         HttpContext.Session.SetString("orderId", "");
         HttpContext.Session.Clear();

         return RedirectToAction("Index", "Home");
      }


      [HttpGet]
      [AllowAnonymous]
      public IActionResult Register()
      {
         if (User?.Identity?.IsAuthenticated ?? false)
         {
            return RedirectToAction("All", "Product", new { area = "" });
         }

         var model = new RegisterViewModel();

         return View(model);
      }

      [HttpPost]
      [AllowAnonymous]
      public async Task<IActionResult> Register(RegisterViewModel model)
      {
         if (!ModelState.IsValid)
         {
            return View(model);
         }

         var user = new IdentityUser()
         {
            Email = model.Email,
            UserName = model.UserName
         };

         var result = await userManager.CreateAsync(user, model.Password);

         if (result.Succeeded)
         {
            return RedirectToAction("Login", "Account", new { area = "" });
         }

         foreach (var item in result.Errors)
         {
            ModelState.AddModelError("", item.Description);
         }

         return View(model);
      }


      [HttpGet]
      [AllowAnonymous]
      public IActionResult Login()
      {
         if (User?.Identity?.IsAuthenticated ?? false)
         {
            return RedirectToAction("All", "Product", new { area = "" });
         }

         var model = new LoginViewModel();

         return View(model);
      }

      [HttpPost]
      [AllowAnonymous]
      public async Task<IActionResult> Login(LoginViewModel model)
      {
         if (!ModelState.IsValid)
         {
            return View(model);
         }

         var user = await userManager.FindByNameAsync(model.UserName);

         if (user != null)
         {
            var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
               return RedirectToAction("All", "Product", new { area = "" });
            }
         }

         ModelState.AddModelError("", "Invalid login");

         return View(model);
      }
   }
}
