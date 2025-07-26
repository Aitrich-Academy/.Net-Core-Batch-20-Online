

    using WorkshopJobProviderApp.helper;
using WorkshopJobProviderApp.Interface;
using WorkshopJobProviderApp.Model;
using WorkshopJobProviderApp.Repository;
using WorkshopJobProviderApp.Service;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;


namespace WorkshopJobProviderApp.Extension

{
    public static  class  ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDistributedMemoryCache(); // Required for session
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddScoped<ProtectedSessionStorage>();

            services.AddDbContext<JobproviderAppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMapperFile));
            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobservice, JobService>();

            services.AddScoped<IAuthservice, AuthService>();
            return services;
        }
    }
}
