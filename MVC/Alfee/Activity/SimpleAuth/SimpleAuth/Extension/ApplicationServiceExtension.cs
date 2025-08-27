using Microsoft.EntityFrameworkCore;
using SimpleAuth.Helpers;
using SimpleAuth.Models;

namespace SimpleAuth.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
