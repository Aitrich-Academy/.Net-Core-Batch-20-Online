using HospitalManagement.Model;
using Microsoft.EntityFrameworkCore;
using HospitalManagement.Helper;
using AutoMapper;
using HospitalManagement.Repository;
using HospitalManagement.Service;
using Microsoft.Extensions.DependencyInjection;

namespace HospitalManagement.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<DoctorService>();
            services.AddScoped<DoctorRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}

