using Domain.Models;
using Domain.Service.JobProvider.Interfaces;
using Domain.Service.JobProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Service.Jobs;
using Domain.Service.Jobs.Interfaces;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.Email;
using Domain.Service.Email.Interface;
using Domain.Service.SignUp;
using Domain.Service.SignUp.Interface;
using Domain.Service.Login.Interfaces;
using Domain.Service.Login;

namespace Domain.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HireMeNowDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();

            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IJobProviderService, JobProviderService>();

            services.AddTransient<IEmailService, EmailService>();

            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();

            services.AddScoped<IInterviewRepository, InterviewRepository>();
            services.AddScoped<IInterviewService, InterviewService>();


            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobService, JobService>();

            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();

            services.AddHttpContextAccessor();

            return services;
        }
    }
}
