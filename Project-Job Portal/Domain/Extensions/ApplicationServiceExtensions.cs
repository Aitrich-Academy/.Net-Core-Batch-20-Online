using Domain.Models;
//<<<<<<< HEAD
using Domain.Service;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;
//=======
//using Domain.Service.JobSeeker;
//using Domain.Service.JobSeeker.Interfaces;
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
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

//<<<<<<< HEAD
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
            services.AddScoped<IJobSeekerService, JobSeekerService>();
//=======
            //services.AddScoped<IJobSeekerProfileRepository, JobSeekerRepository>();
            //services.AddScoped<IJobSeekerProfileService, JobSeekerService>();
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4

            return services;
        }
    }
}
