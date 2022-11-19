using AutomationShopHub.Areas.Agent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize]
   public class AgentController : Controller
   {
      [HttpGet]
      public IActionResult Become()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> Become(BecomeAgentModel model)
      {
         return RedirectToAction("All", "Product");
      }
   }
}
