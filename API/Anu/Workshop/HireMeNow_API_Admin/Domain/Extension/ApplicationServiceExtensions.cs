using Domain;

using Microsoft.EntityFrameworkCore;
using Domain.Service;

using Domain.Service.Authuser.Interfaces;
using Domain.Service.Authuser;

using Domain.Models;

using Domain.Service.Job.Interfaces;
using Domain.Service.Job;

using Domain.Service.Login.Interfaces;
using Domain.Service.Login;

using Domain.Service.Admin.Interfaces;
using Domain.Service.Admin;


using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;



namespace Domain.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();

            services.AddScoped<IAuthuserRepository, AuthuserRepository>();
            services.AddScoped<IAuthuserService, AuthuserService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdminRepository, AdminRepository>();

            return services;
        }
    }
}
