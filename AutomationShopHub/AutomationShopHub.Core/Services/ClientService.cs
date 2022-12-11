using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.Design;
using System.Security.Claims;

namespace AutomationShopHub.Core.Services
{
   public class ClientService : IClientService
   {
      private readonly IRepository repo;

      public ClientService(IRepository _repo)
      {
         repo = _repo;
      }
      public async Task Create(string userId, string phoneNumber, string deliveryAddress, string imageUrl)
      {
         var client = new Client()
         {
            UserId = userId,
            TelephoneNumber = phoneNumber,
            DeliveryAddress = deliveryAddress,
            ImageProfileUrl = imageUrl
         };

         await repo.AddAsync(client);
         await repo.SaveChangesAsync();

      }

      public async Task<bool> ExistById(string userId)
      {
         return await repo.All<Client>()
         .AnyAsync(a => a.UserId == userId);
      }

      /// <summary>
      /// Gets the Client by given userId from Identity User 
      /// </summary>
      /// <param name="userId"></param>
      /// <returns>ClientModel if found, otherwise empty model</returns>
      public async Task<ClientModel> GetClientByUserId(string userId)
      {
         var client = await repo.AllReadonly<Client>()
            .Include(a => a.User)
            .FirstOrDefaultAsync(s => s.UserId == userId);

         if (client is null)
         {
            return new ClientModel();
         }

         return new ClientModel()
         {
            Id = client.Id,
            ImageProfileUrl = client.ImageProfileUrl,
            TelephoneNumber = client.TelephoneNumber,
            DeliveryAddress = client.DeliveryAddress,
            UserId = client.UserId,
            User = client.User
         };
      }

      public async Task<bool> UserHasActiveOrders(string userId)
      {
         return await repo.All<Order>()
        .AnyAsync(o => !o.isConfirmed && o.Client.UserId == userId);
      }

      public async Task<bool> UserWithEmailExists(string email)
      {
         return await repo.All<Client>()
            .AnyAsync(a => a.User.Email == email);
      }

      public async Task<bool> UserWithPhoneExists(string phoneNumber)
      {
         return await repo.All<Client>()
            .AnyAsync(a => a.TelephoneNumber == phoneNumber);
      }

   }
}
