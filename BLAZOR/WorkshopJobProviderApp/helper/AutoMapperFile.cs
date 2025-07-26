using AutoMapper;
using WorkshopJobProviderApp.Model;
using WorkshopJobProviderApp.Dto;

namespace WorkshopJobProviderApp.helper
{
    public class AutoMapperFile:Profile
    {
        public AutoMapperFile()
        {
            CreateMap<JobProvider, JobProviderDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
