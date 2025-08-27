using HospitalPortal.Helper;
using HospitalPortal.Interfaces;
using HospitalPortal.Models;
using HospitalPortal.Repository;
using HospitalPortal.Service;
using Microsoft.EntityFrameworkCore;

namespace HospitalPortal.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorService, DoctorService>();

            services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            services.AddScoped<IAppointmentService, AppointmentService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;

        }
    }
}