using AdminPortal.Data;
using AdminPortal.Interface;
using AdminPortal.Models;
using AdminPortal.Repository;
using AdminPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace AdminPortal.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IEmployeeRepository, EmpRepository>();
            services.AddScoped<IEmployeeService, EmpService>();
           

            return services;
        }
    }

}

