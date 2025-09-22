using Business.Service.Agency;
using Domain.Service.Agency;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
  public static class AppServiceContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAgencyService, AgencyService>();
        }
    }
}
