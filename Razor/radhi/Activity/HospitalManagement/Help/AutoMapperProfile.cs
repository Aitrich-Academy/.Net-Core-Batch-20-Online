using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Models;

namespace HospitalManagement.Help
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Doctor, DoctorDto>().ReverseMap();
        }
    }
}
