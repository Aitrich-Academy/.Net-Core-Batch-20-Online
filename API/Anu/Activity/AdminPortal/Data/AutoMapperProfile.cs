using AutoMapper;
using AdminPortal.Models;
using AdminPortal.Dto;

namespace AdminPortal.Data
{
    public class AutoMapperProfile  : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
             
        }
    }
}
