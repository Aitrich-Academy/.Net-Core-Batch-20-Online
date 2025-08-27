using JobPortalSystem.Helpers;
using JobPortalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalSystem.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobAppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
