using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutomationShopHub.Core.Services
{
   public class AgentService : IAgentService
   {
      private readonly IRepository repo;

      public AgentService(IRepository _repo)
      {
         repo = _repo;
      }

      public async Task Create(string userId, string phoneNumber)//, string? imageProfileUrl
      {
         var agent = new SalesAgent()
         {
            UserId = userId,
            TelephoneNumber = phoneNumber
         };

         //if (imageProfileUrl is not null)
         //{
         //   agent.ImageProfileUrl = imageProfileUrl;
         //}

         await repo.AddAsync(agent);
         await repo.SaveChangesAsync();

      }

      public async Task<bool> ExistById(string userId)
      {
         return await repo.All<SalesAgent>()
            .AnyAsync(a => a.UserId == userId);
      }

      /// <summary>
      /// Gets the SalesAgentId by given userId from Identity User 
      /// </summary>
      /// <param name="userId"></param>
      /// <returns>SalesAgentModel if found, otherwise empty model</returns>
      public async Task<SalesAgentModel> GetAgentByUserId(string userId)
      {
         var agent = await repo.AllReadonly<SalesAgent>()
            .Include(a => a.User)
            .FirstOrDefaultAsync(s => s.UserId == userId);

         if (agent is null)
         {
            return new SalesAgentModel();
         }

         return new SalesAgentModel()
         {
            SalesAgentId = agent.Id,
            ImageProfileUrl = agent.ImageProfileUrl,
            TelephoneNumber = agent.TelephoneNumber,
            AgentName = agent.User.UserName,
            AgentUserId = agent.UserId
         };
      }

      public async Task<bool> UserHasActiveOrders(string userId)
      {
         return await repo.All<Order>()
         .AnyAsync(o => !o.isConfirmed && o.SalesAgent.UserId == userId);
      }

      public async Task<bool> UserWithEmailExists(string email)
      {
         return await repo.All<SalesAgent>()
            .AnyAsync(a => a.User.Email == email);
      }

      public async Task<bool> UserWithPhoneExists(string phoneNumber)
      {
         return await repo.All<SalesAgent>()
            .AnyAsync(a => a.TelephoneNumber == phoneNumber);
      }
   }
}
