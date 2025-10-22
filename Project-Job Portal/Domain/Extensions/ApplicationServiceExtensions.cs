using Domain.Models;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HireMeNowDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IJobSeekerProfileRepository, JobSeekerRepository>();
            services.AddScoped<IJobSeekerProfileService, JobSeekerService>();

            return services;
        }
    }
}
