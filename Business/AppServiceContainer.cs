using Business.Service.Admin;
using Business.Service.Agency;
using Domain.Service;
using Domain.Service.Agency;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
  public static class AppServiceContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<IAdminService, AdminService>();
        }
    }
}
