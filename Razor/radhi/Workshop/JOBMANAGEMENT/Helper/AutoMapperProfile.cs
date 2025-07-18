using AutoMapper;
using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Models;

namespace JOBMANAGEMENT.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
