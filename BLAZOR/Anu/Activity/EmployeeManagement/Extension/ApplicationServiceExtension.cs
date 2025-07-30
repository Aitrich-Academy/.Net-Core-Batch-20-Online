using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Repository;
using EmployeeManagement.Service;

namespace EmployeeManagement.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(
                Options =>Options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<EmployeeRepository>();
            services.AddScoped<EmployeeService>();

            return services;
        }
    }
}



 
 
