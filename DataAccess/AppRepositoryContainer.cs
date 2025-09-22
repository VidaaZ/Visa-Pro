using DataAccess.Repository.Agency;
using Domain.Repository.Agency;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class AppRepositoryContainer
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAgencyRepository, AgencyRepository>();
        }
    }
}
