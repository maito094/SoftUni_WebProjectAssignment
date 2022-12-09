using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Services;
using AutomationShopHub.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
   public static class AutomationShopHubServiceCollectionExtension
   {
      public static IServiceCollection AddApplicationServices(this IServiceCollection services)
      {
         services.AddScoped<IRepository, Repository>();
         services.AddScoped<IProductService,ProductService>();
         services.AddScoped<IAgentService,AgentService>();
         services.AddScoped<IClientService,ClientService>();
         return services;
      }
   }
}
