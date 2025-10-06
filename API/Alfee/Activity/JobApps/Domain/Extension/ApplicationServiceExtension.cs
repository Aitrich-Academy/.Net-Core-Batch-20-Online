using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Helper;
using Domain.Interface;
using Domain.Model;
using Domain.Repository;
using Domain.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
