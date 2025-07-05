using Microsoft.EntityFrameworkCore;
using UserManagement.Helper;
using UserManagement.Interface;
using UserManagement.Models;
using UserManagement.Repository;
using UserManagement.Service;

namespace UserManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Register Repositories via Interfaces
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IAppliedRepository, AppliedJobRepository>();

            // Register Services via Interfaces
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IAppliedService, AppliedJobService>();

            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}


