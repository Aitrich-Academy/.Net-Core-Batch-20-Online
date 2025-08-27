using JobSeekerPortal.Helper;
using JobSeekerPortal.Interfaces;
using JobSeekerPortal.Models;
using JobSeekerPortal.Repository;
using JobSeekerPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace JobSeekerPortal.Extension
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
