using Microsoft.EntityFrameworkCore;
using SimpleAuthMVC.Models;
using SimpleAuthMVC.Helper;
using SimpleAuthMVC.Interface;
using SimpleAuthMVC.Repository;
using SimpleAuthMVC.Service;

namespace SimpleAuthMVC.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
           
            services.AddAutoMapper(typeof(MappingProfile));
          
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}
