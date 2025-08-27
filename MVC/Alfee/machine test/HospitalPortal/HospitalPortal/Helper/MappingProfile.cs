using AutoMapper;
using HospitalPortal.Dtos;
using HospitalPortal.Models;

namespace HospitalPortal.Helper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // User <-> UserDto
            CreateMap<User, UserDto>().ReverseMap();

            // Doctor <-> DoctorDto
            CreateMap<Doctor, DoctorDto>().ReverseMap();

            // Appointment <-> AppointmentDto
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
        }
    }
}
