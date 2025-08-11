using AutoMapper;
using workshopmvc.Dto;
using workshopmvc.Models;

namespace workshopmvc.Helper
{
    public class Automapperprofile:Profile
    {

        public Automapperprofile()
        {
            CreateMap<JobDto, Job>().ReverseMap();

            CreateMap<UserDto, User>().ReverseMap();
        }

       
    }
}
