using JobApi.Help;
using JobApi.Interface;
using JobApi.Models;
using JobApi.Repository;
using JobApi.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace JobApi.Extension
{
    public static class ApplicationServiceExtension
    {
     
             public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

          
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserServicecs, UserService>();
            services.AddDataProtection(); // Required for session encryption
            services.AddDistributedMemoryCache(); // In-memory cache for session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddAutoMapper(cfg => {
                cfg.AddProfile<AutoMapperProfile>();
            });

            return services;
        }
    }
}
