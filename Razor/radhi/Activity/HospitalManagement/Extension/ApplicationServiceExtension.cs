using HospitalManagement.Help;
using HospitalManagement.Models;
using HospitalManagement.Repository;
using HospitalManagement.Service;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Extension
{
   
        public static class ApplicationServiceExtension
        {
            public static IServiceCollection AddApplicationServices
               (this IServiceCollection services, IConfiguration config)
            {
                services.AddDbContext<HospitalDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

                // Add Services
                services.AddScoped<DoctorService>();
                services.AddScoped<DoctorRepository>();
                //// Add AutoMapper
                services.AddAutoMapper(typeof(AutoMapperProfile));

                return services;
            }
        }
    }

