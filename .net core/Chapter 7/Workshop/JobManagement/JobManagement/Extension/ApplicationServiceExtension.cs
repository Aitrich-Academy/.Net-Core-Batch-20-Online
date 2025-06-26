using JobManagement.Helper;
using JobManagement.Model;
using JobManagement.Repository;
using JobManagement.Service;
using Microsoft.EntityFrameworkCore;

namespace JobManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services
            services.AddScoped<JobService>();
            services.AddScoped<JobRepository>();
            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
