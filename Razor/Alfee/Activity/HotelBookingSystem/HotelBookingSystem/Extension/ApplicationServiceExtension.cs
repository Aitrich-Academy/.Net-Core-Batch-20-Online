using HotelBookingSystem.Helper;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using HotelBookingSystem.Repository;
using HotelBookingSystem.Service;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Extension
{
    public  static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<HotelDbContext>(options =>
           options.UseSqlServer(config.GetConnectionString("DefaultConnection")));


            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
