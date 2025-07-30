using BlazorApp3.Model;
using BlazorApp3.Repository;
using BlazorApp3.Service;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(
               options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<EmployeeRepository>();
            services.AddScoped<EmployeeService>();

            return services;
        }
    }
}
