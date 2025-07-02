using JobsManagement.Helper;
using JobsManagement.Model;
using JobsManagement.Repository;
using JobsManagement.Services;
using Microsoft.EntityFrameworkCore;

namespace JobsManagement.Extention
{
    public  static class ApplictaionServiceExtension
    {
        public static  IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services
            services.AddScoped<JobService>();
            services.AddScoped<JobRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
