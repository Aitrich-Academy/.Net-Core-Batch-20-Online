using Domain.Models;
using Domain.Service.Authuser.Interface;
using Domain.Service.Authuser;
using Domain.Service.Login.Interface;
using Domain.Service.Login;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Service.Admin.Interface;
using Domain.Service.Admin;

namespace Domain.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();

            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();

           
            return services;
        }
    }
}
