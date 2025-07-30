using JobProviders.Helpers;
using JobProviders.Interface;
using JobProviders.Model;
using JobProviders.Repository;
using JobProviders.Service;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace JobProviders.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobProviderDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(MappingProfile));
            

            return services;
        }
    }
}
