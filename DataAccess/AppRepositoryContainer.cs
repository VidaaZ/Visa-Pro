using DataAccess.Repository.Admin;
using DataAccess.Repository.Agency;
using Domain.Repository;
using Domain.Repository.Agency;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class AppRepositoryContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAgencyRepository, AgencyRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
        }
    }
}
