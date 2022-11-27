using AutomationShopHub.Core.Models;

namespace AutomationShopHub.Core.Contracts
{
   public interface IAgentService
   {
      Task<bool> ExistById(string userId);
      Task<bool> UserWithPhoneExists(string phoneNumber);
      Task<bool> UserWithEmailExists(string email);
      Task<bool> UserHasActiveOrders(string userId);

      Task Create(string userId, string phoneNumber);
      Task<SalesAgentModel> GetAgentByUserId(string userId);
   }
}
