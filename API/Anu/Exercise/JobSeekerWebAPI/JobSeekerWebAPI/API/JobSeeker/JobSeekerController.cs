using AutoMapper;

using Domain.Service.JobSeeker.Interface;
using Domain.Service.JobSeeker.DTO;
using HireMeNow_API_Admin.Controllers;
using Domain.Service.User.DTO;

using Microsoft.AspNetCore.Mvc;
using JobSeekerWebAPI.API.JobSeeker.RequestObject;
 using Domain.Models;
 
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Runtime.ConstrainedExecution;
using Microsoft.AspNetCore.Mvc;
using JobSeekerWebAPI.API.JobSeeker.RequestObject;

namespace JobSeekerWebAPI.API.JobSeeker
{
   
    [ApiController]
    public class JobSeekerController : BaseApiController<JobSeekerController>
    {

        private readonly IJobseekerService _jobseekerService;
        private readonly IMapper _mapper;
       

        public JobSeekerController(IMapper mapper, IJobseekerService jobseekerService)
        { 
            _mapper = mapper;
            _jobseekerService = jobseekerService;
        }


        [HttpGet]
        [Route("ViewProfile/{id}")]
        public async Task<IActionResult> ViewProfile(Guid id)
        {
            var seeker = await _jobseekerService.ViewSeekerByIdAsync (id);
            if (seeker == null) return NotFound();
            return Ok(seeker);
        }

        [HttpPut]
        [Route("UpdateSeeker/{id}")]
        public async Task<IActionResult> UpdateSeeker(Guid id, SeekerUpdateRequest seeker)
        {

            var seekerdto = _mapper.Map<SeekerDto>(seeker);

            if (id != seekerdto.Id) return NotFound();
            var updateseeker = await _jobseekerService .UpdateSeekerAsync (seekerdto);
            return Ok(updateseeker);
        }

        [HttpGet("ViewappliedJobs/{userId}")]
        public async Task<IActionResult> GetAppliedJobsByUser(Guid userId)
        {
            var appliedJobs = await _jobseekerService.GetAppliedJobsByUserAsync(userId);

            if (appliedJobs == null || !appliedJobs.Any())
                return NotFound("No applied jobs found for this user.");

            return Ok(appliedJobs);
        }


    }
}
