using HospitalManagement.Helper;
using HospitalManagement.Model;
using HospitalManagement.Repository;
using HospitalManagement.Services;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<DoctorServices>();
            services.AddScoped<DoctorRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
