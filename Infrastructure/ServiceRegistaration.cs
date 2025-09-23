using Business.Service.Admin;
using Business.Service.Agency;
using DataAccess;
using DataAccess.Repository.Admin;
using DataAccess.Repository.Agency;
using DataAccess.Repository.Auth;
using Domain.Repository;
using Domain.Repository.Agency;
using Domain.Repository.Auth;
using Domain.Service;
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
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, IAuthService>();
            return services;
        }
    }
}
