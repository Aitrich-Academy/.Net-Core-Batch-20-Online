using Domain.Models;
<<<<<<< HEAD
using Domain.Service.JobProvider.Interfaces;
using Domain.Service.JobProvider;
=======
using Domain.Service;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;
using Domain.Service.Profile;
using Domain.Service.Profile.Interface;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
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

<<<<<<< HEAD
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
=======
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IJobSeekerRepository, JobSeekerRepository>();
            services.AddScoped<IJobSeekerService, JobSeekerService>();
            services.AddScoped<IJobSeekerProfileRepository, ProfileRepository>();
            services.AddScoped<IJobSeekerProfileService, ProfileService>();
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341

            return services;
        }
    }
}
