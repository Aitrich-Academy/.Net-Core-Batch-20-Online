using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.User.DTO;
using Domain.Service.JobSeeker.Interface;
 
using Microsoft.AspNetCore.Http.HttpResults;
using Domain.Service.JobSeeker.DTO;
using Domain.Service.Job.DTO;


namespace Domain.Service.JobSeeker
{
    public  class JobSeekerService :IJobseekerService 
    {
        IJobSeekerRepository  _seekerRepository;
        IMapper _mapper;

        public JobSeekerService(IJobSeekerRepository seekerRepository, IMapper mapper)


        {
             _seekerRepository = seekerRepository;
            _mapper = mapper;
        }

        public async Task<RegisterUserDto> ViewSeekerByIdAsync(Guid id)
        {
            var viewseeker = await _seekerRepository.ViewSeekerByIdAsync(id);
            return _mapper.Map<RegisterUserDto>(viewseeker);
        }

        public async Task<SeekerDto> UpdateSeekerAsync(SeekerDto Jseekerdto)
        {
            var updateseeker = _mapper.Map<RegisterUser>(Jseekerdto);
            updateseeker = await _seekerRepository.UpdateSeekerAsync (updateseeker);

            return _mapper.Map<SeekerDto>(updateseeker);
        }

        public async Task<List<ViewappliedDto>> GetAppliedJobsByUserAsync(Guid userId)
        {
            return await _seekerRepository.GetAppliedJobsByUserAsync(userId);
        }
    }
}
