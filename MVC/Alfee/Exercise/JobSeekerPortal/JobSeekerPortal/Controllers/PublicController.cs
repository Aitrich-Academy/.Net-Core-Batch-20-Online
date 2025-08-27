using JobSeekerPortal.Dtos;
using JobSeekerPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerPortal.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _publicService;

        public PublicController(IPublicService publicService)
        {
            _publicService = publicService;
        }

        // GET: /Public/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Public/Register
        [HttpPost]
        public async Task<IActionResult> Register(UserDto userDto, string password)
        {
            if (!ModelState.IsValid)
                return View(userDto);

            var result = await _publicService.RegisterAsync(userDto, password);

            if (result == null)
            {
                ModelState.AddModelError("", "Email already exists.");
                return View(userDto);
            }

            return RedirectToAction("Login");
        }

        // GET: /Public/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Public/Login
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await _publicService.LoginAsync(email, password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }

            // For simplicity, storing UserId in session
            HttpContext.Session.SetInt32("UserId", user.Id);

            return RedirectToAction("Profile", "JobSeeker");
        }
    }
}
