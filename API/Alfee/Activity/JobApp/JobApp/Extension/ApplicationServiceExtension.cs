using JobApp.Helper;
using JobApp.Interface;
using JobApp.Model;
using JobApp.Repository;
using JobApp.Service;
using Microsoft.EntityFrameworkCore;

namespace JobApp.Extension
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
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
