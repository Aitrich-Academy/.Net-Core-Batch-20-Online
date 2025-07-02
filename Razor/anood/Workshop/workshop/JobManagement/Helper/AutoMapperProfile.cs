using JobManagement.Dto;
using JobManagement.Model;
using AutoMapper;

namespace JobManagement.Helper
{
    public class AutoMapperProfile : Profile 
    {
        public AutoMapperProfile()
        {
            CreateMap<Jobs, JobDto>().ReverseMap();
        }
    }
}
