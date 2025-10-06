using Domain.Service.Interviews.Dto;
using Domain.Service.Interviews.Interface;
using System.Security.Claims;
using JobProviderApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobProviderApi.API.Interview 
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InterviewController : BaseApiController<InterviewController>
    {
        private readonly IInterviewService _service;

        public InterviewController(IInterviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetInterviews()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var interviews = await _service.GetInterviewsAsync(userId);
            return Ok(interviews);
        }

        [HttpPost]
        public async Task<IActionResult> ScheduleInterview(InterviewDto dto)
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            dto.JobProviderId = userId;

            var result = await _service.ScheduleInterviewAsync(dto);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInterview(Guid id, InterviewDto dto)
        {
            dto.Id = id;
            var result = await _service.UpdateInterviewAsync(dto);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInterview(Guid id)
        {
            var deleted = await _service.DeleteInterviewAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}

