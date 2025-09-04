using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AdminPortal.Service;
using AdminPortal.Dto;
using AdminPortal.Interface;
using AdminPortal.Models;

namespace AdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _empService;

        public EmployeeController(IEmployeeService empService)
        {
            _empService = empService;
        }


        [HttpPost]
        public async Task<IActionResult> AddEmp(EmployeeDto empdto)
        {
            try
            {
                return Ok(await _empService.AddempAsync(empdto));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<IActionResult> GetEmps()
        {
            return Ok(await _empService.GetempAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetEmpByIdAsync(Guid id)
        {
            var emp = await _empService.GetempByIdAsync(id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateEmp(Guid id, [FromBody] EmployeeDto empdto)
        {
            try
            {
                var updatedemp = await _empService.UpdateempAsync(id, empdto);
                if (updatedemp == null)
                    return NotFound(new { message = "Employee not found" });

                return Ok(updatedemp);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public async Task<IActionResult> DeleteEmp(Guid id)
        {
            var isDeleted = await _empService.DeleteempAsync(id);
            if (!isDeleted)
                return NotFound(new { message = "Job not found" });

            return NoContent();
        }

    }
}
