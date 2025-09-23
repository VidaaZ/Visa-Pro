using DataAccess.Repository.Admin;
using DataAccess.Repository.Agency;
using DataAccess.Repository.Auth;
using Domain.Repository;
using Domain.Repository.Agency;
using Domain.Repository.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class AppRepositoryContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
        }
    }
}
