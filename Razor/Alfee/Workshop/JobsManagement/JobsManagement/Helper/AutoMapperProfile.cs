using AutoMapper;
using JobsManagement.Dto;
using JobsManagement.Model;

namespace JobsManagement.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Jobs, JobDto>().ReverseMap();
        }

    }
}
