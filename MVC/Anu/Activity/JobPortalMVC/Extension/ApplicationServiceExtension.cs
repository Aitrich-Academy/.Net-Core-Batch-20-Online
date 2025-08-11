using JobPortalMVC.Helpers;
using JobPortalMVC.Interface;
using JobPortalMVC.Models;
using JobPortalMVC.Repository;
using JobPortalMVC.Service;
using Microsoft.EntityFrameworkCore;

namespace JobPortalMVC.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobAppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IJobRepository,JobRepository>();
            services.AddScoped<IJobService,JobService>();


            return services;
        }
    }
}
