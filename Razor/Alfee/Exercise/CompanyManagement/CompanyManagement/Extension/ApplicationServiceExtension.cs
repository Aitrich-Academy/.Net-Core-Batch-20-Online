using CompanyManagement.Helper;
using CompanyManagement.Interface;
using CompanyManagement.Model;
using CompanyManagement.Repository;
using CompanyManagement.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyManagement.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
           options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICompanyMemberRepository, CompanyMemberRepository>();
            services.AddScoped<ICompanyMemberService, CompanyMemberService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
