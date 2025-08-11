using Microsoft.EntityFrameworkCore;
using System;
using workshopmvc.Models;
using Microsoft.Identity.Client;
using workshopmvc.Helper;
using AutoMapper;

using Microsoft.Extensions.DependencyInjection;
using workshopmvc.Interface;
using workshopmvc.Repository;
using workshopmvc.Services;

namespace workshopmvc.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
        {
           
            services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IpublicService, PublicService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IJobRepository, JobRepository>();



            services.AddAutoMapper(cfg => {
                cfg.AddProfile<Automapperprofile>();
            });

            return services;
        }
    }
}
