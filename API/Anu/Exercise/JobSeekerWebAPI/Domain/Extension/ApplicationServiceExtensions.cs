using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Domain.Service.User.Interface;
using Domain.Service.User;
using Microsoft.EntityFrameworkCore.Internal;
using Domain.Service;
using Domain.Service.Login.Interfaces;
using Domain.Service.Login;
using Domain.Service.JobSeeker.Interface;
using Domain.Service.JobSeeker;
using Domain.Service.Job.Interface;
using Domain.Service.Job;



namespace Domain.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IRegisterUserRepository , RegisterUserRepository>();
            services.AddScoped<IRegisterUserService , RegisterUserService>();

            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();


            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
            services.AddScoped<IJobseekerService , JobSeekerService>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();


            return services;
        }
    }
}
