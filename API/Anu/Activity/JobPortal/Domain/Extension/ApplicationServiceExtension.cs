using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Domain.Dto;
using Domain.Interface;
using Domain.Repository;
using Domain.Service;
using AutoMapper;
using Domain.Helper;


namespace Domain.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService
        (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("MyConnetion")));

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper(typeof(AutoMapperProfile));


            return services;
        }
    }
}
