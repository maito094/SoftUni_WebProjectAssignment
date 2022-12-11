using AutomationShopHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Contracts
{
    public interface IClientService
    {
      Task<bool> ExistById(string userId);
      Task<bool> UserWithPhoneExists(string phoneNumber);
      Task<bool> UserWithEmailExists(string email);
      Task<bool> UserHasActiveOrders(string userId);

      Task Create(string userId, string phoneNumber, string deliveryAddress, string imageUrl);

      /// <summary>
      /// Gets the SalesAgentId by given userId from Identity User 
      /// </summary>
      /// <param name="userId"></param>
      /// <returns>SalesAgentModel if found, otherwise empty model</returns>
      Task<ClientModel> GetClientByUserId(string userId);

   }
}
