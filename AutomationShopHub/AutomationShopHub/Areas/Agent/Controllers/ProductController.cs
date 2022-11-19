using AutomationShopHub.Areas.Agent.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AutomationShopHub.Areas.Agent.Controllers
{
   [Authorize(Roles ="Agent")]
   public class ProductController : Controller
   {
      [HttpGet]
      public IActionResult Add() => View(new ProductFormModel());
      

      [HttpPost]
      public async Task<IActionResult> Add(ProductFormModel formModel)
      {
         Guid id = new Guid(); //TODO Get actual created Models id


         return RedirectToAction("Details","Product", new
         {
            id = id
         });
      }

      [HttpGet]
      public async Task<IActionResult> Edit(string id) { 
        
         var model = new ProductFormModel();
       
         return  View(model); 
      }

      [HttpPost]
      public async Task<IActionResult> Edit(string id, ProductFormModel formModel) { 
        
         //TODO Make the Edit of model here! 

         return RedirectToAction("Details", "Product", new
         {
            id = id
         });

      }
      
      
  
      [HttpPost]
      public async Task<IActionResult> Delete(string id) { 
        
         //TODO On Details have a Delete button

         return RedirectToAction("All", "Product");

      }
   }
}
