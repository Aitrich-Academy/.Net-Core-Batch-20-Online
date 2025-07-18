using JOBMANAGEMENT.Models;
using Microsoft.EntityFrameworkCore;
using JOBMANAGEMENT.Repository;
using AutoMapper;
using JOBMANAGEMENT.Interface;
using JOBMANAGEMENT.Helper;
using JOBMANAGEMENT.Service;

namespace JOBMANAGEMENT.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
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

