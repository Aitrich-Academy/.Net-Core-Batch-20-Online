using AutoMapper;
using HospitalManagement.Dto;
using HospitalManagement.Model;

namespace HospitalManagement.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Doctors, DoctorDto>().ReverseMap();
        }
    }
}
