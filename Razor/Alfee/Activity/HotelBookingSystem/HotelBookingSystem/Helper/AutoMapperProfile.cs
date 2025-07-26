using AutoMapper;
using HotelBookingSystem.Dto;
using HotelBookingSystem.Model;

namespace HotelBookingSystem.Helper
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Room, RoomDto>().ReverseMap();
            CreateMap<Booking, BookingDto>().ReverseMap();
        }
    }
}
