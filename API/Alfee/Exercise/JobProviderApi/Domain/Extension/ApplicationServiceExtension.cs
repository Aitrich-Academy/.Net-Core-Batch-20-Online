using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Service.JobProviders.Interface;
using Domain.Service.JobProviders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Domain.Service.Applicants.Interface;
using Domain.Service.Applicants;
using Domain.Service.Interviews.Interface;
using Domain.Service.Interviews;
using Domain.Service.Profile.Interface;
using Domain.Service.Profile;

namespace Domain.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IProfileService, ProfileService>();

            services.AddScoped<IInterviewRepository, InterviewRepository>();
            services.AddScoped<IInterviewService, InterviewService>();

            services.AddScoped<IApplicantRepository, ApplicantRepository>();
            services.AddScoped<IApplicantService, ApplicantService>();

            return services;
        }
    }
}
