using AutoMapper;

using Domain.Service.User.Interface;

using Domain.Service.Job.Interface;
using Domain.Service.Login.Interfaces;

using HireMeNow_API_Admin.Controllers;
 

using Microsoft.AspNetCore.Mvc;
using JobSeekerWebAPI.API.User.RequestObject;
using Domain.Service.User.DTO;
using JobSeekerWebAPI.API.User.RequestObject;
using Domain.Models;
using Domain.Service.Job;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Runtime.ConstrainedExecution;
using Domain.Service.Job.Interface;
using Domain.Service.Job.DTO;
using JobSeekerWebAPI.API.Job.RequestObject;
using Domain.Service.Job.DTO;
using Azure.Core;

namespace JobSeekerWebAPI.API.Job
{
    
    [ApiController]
    public class JobController : BaseApiController<JobController>
    {
        private readonly IJobService  _jobService;
        private readonly IMapper _mapper;
        

        public JobController(IMapper mapper, IJobService jobService)
        {
            _mapper = mapper;
             _jobService = jobService;
        }

        [HttpGet]
        [Route("alljobs")]
        public async Task<IActionResult> alljobs()
        {

            try
            {
                var jobs = await _jobService.GetJobs();
                return Ok(_mapper.Map<List<Joblist>>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("ViewJobsById/{id}")]
        public async Task<IActionResult> GetJobById(Guid id)
        {

            try
            {
                var jobs = await _jobService.GetJobByIdAsync(id);
                if (jobs == null)
                    return NotFound();
                return Ok(_mapper.Map<Joblist>(jobs));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost("Jobapplication")]
        public async Task<IActionResult> AppliedJob(AppliedJobRequest applyJobReq)
        {

            var applyjobdto = _mapper.Map<AppliedJobDto>(applyJobReq);

            var alreadyApplied = await _jobService.ExistsAsync(applyjobdto.Job, applyjobdto.SavedBy);
            if (alreadyApplied == true)
            {
               return Ok("You have already applied for this job.");
            }



            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _jobService.ApplyJobAsync(applyjobdto);

            return Ok("Job applied successfully");
        }


    }
    
}
