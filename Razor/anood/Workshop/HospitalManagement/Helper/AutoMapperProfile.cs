using HospitalManagement.Dto;
using HospitalManagement.Model;
using AutoMapper;

namespace HospitalManagement.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Doctors,DoctorDto>().ReverseMap();
        }
    }
}
