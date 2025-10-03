using AutoMapper;

using Domain.Service.User.Interface;

 
using JobSeekerWebAPI.Controllers;
 

using Microsoft.AspNetCore.Mvc;
using JobSeekerWebAPI.API.User.RequestObject;
using Domain.Service.User.DTO;
 using Domain.Models;
 using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Runtime.ConstrainedExecution;
using HireMeNow_API_Admin.Controllers;
using System.Net;
using Domain.Service.Login.DTO;
using Domain.Service.Login.Interfaces;

namespace JobSeekerWebAPI.API.User
{
    
    [ApiController]
    public class UserController : BaseApiController<UserController>
    {

        private readonly IRegisterUserService _registerUserService;
        private readonly IMapper _mapper;
        private readonly ILoginRequestService _loginRequestService;



        public UserController(IMapper mapper, IRegisterUserService registerUserService, ILoginRequestService loginRequestService)
        {
            _mapper = mapper;
            _registerUserService = registerUserService;
            _loginRequestService = loginRequestService;
        }

        [HttpPost]
        [Route("User/RegisterUser")]
        public async Task<IActionResult> RegisterUser(RegisterRequest RegRequest)
        {
            var RegUserDto = _mapper.Map<RegisterUserDto>(RegRequest);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var registeruser = await _registerUserService.AddRegisterUserAsync (RegUserDto);
                return Ok("User Registered successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        [Route("User/login")]
        public async Task<ActionResult> Login(LoginRequest logdata)
        {
            var loginDto = _mapper.Map<UserLoginDto>(logdata);
            var user =  _loginRequestService.Adminlogin(loginDto.Email,loginDto.Password);

            if (user == null)
            {
                return BadRequest("Login Failed"); 
            }
            return Ok(user);
        }

    }
}
