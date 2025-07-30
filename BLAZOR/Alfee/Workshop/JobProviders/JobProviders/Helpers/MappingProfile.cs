using AutoMapper;
using JobProviders.Dto;
using JobProviders.Model;

namespace JobProviders.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<JobProvider, JobProviderDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
