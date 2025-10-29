using Domain.Models;
using Domain.Service.Admin;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Authuser;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;

using Domain.Service;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.Profile;
using Domain.Service.Profile.Interface;
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

            // Register repositories and services
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAdminServices, AdminService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();


            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
            services.AddScoped<IJobSeekerService, JobSeekerService>();
            services.AddScoped<IJobSeekerProfileRepository, ProfileRepository>();
            services.AddScoped<IJobSeekerProfileService, ProfileService>();

            return services;
        }
    }
}
