using Domain.Models;
using Domain.Service.Admin;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Authuser;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HireMeNowDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            //services.AddScoped<IAdminServices, AdminService>();
            //services.AddScoped<IAdminRepository, AdminRepository>();
            //services.AddScoped<ILoginRequestService, LoginRequestService>(); // ✅ Register service
            //services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            //services.AddScoped<IAuthUserRepository, AuthUserRepository>();

            return services;
        }
    }
}
