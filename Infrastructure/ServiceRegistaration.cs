using Business.Service.Agency;
using DataAccess;
using DataAccess.Repository.Agency;
using Domain.Repository.Agency;
using Domain.Service.Agency;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceRegistaration
    {
        public static IServiceCollection RegisterServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterDataAccessServices(configuration);
            services.AddApplicationServices();

            services.AddScoped<IAgencyService, AgencyService>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();


            return services;
        }
    }
}
