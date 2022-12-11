using System.Security.Claims;

namespace AutomationShopHub.Extensions
{
   public static class ClaimsPrincipalExtenstion
   {
      public static string Id(this ClaimsPrincipal user)
      {
         return user.FindFirstValue(ClaimTypes.NameIdentifier);
      }
      public static string Email(this ClaimsPrincipal user)
      {
         return user.FindFirstValue(ClaimTypes.Email);
      }
      public static string Name(this ClaimsPrincipal user)
      {
         return user.FindFirstValue(ClaimTypes.Name);
      }     

   }
}
