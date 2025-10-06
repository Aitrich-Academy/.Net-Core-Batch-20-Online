using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dto;
using Domain.Model;

namespace Domain.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
