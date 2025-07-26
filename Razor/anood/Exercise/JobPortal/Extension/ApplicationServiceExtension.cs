using JobPortal.Model;
using Microsoft.EntityFrameworkCore; 
using JobPortal.Service;
using JobPortal.Repository;
using Microsoft.AspNetCore.Identity;
 
namespace JobPortal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
         (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

           
            services.AddScoped<JobService>();
             services.AddScoped<JobRepository>();
            services.AddScoped<UserService>();
            services.AddScoped<UserRepository>();
            services.AddScoped<AppliedService>();
            services.AddScoped<AppliedRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
