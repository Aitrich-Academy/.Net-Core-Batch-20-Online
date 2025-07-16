using JobPortal.Dto;
using JobPortal.Model;
using AutoMapper;
using Hangfire.MemoryStorage.Dto;
 
  
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Jobs, JobsDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Applied, AppliedDto>().ReverseMap();
    }
}
