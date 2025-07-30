using TaskManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using TaskManagementApp.Services;
using TaskManagementApp.Repositories;

namespace TaskManagementApp.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                Options => Options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped <TaskService> ();
            services.AddScoped<TaskRepository>();

            return services;
        }
    }
}
