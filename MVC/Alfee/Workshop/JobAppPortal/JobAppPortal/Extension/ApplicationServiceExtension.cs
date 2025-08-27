using JobAppPortal.Helper;
using JobAppPortal.Interface;
using JobAppPortal.Models;
using JobAppPortal.Repository;
using JobAppPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace JobAppPortal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(config.GetConnectionString("DefaultConnection")));


            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
