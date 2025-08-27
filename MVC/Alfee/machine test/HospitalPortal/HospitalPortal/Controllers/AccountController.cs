using HospitalPortal.Dtos;
using HospitalPortal.Enum;
using HospitalPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HospitalPortal.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserDto userDto)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(userDto);
                return RedirectToAction("Login");
            }
            return View(userDto);
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _userService.GetByEmail(email);
            if (user != null && user.Password == password) // simple check
            {
                // Store user in session
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserRole", user.Role.ToString());

                switch (user.Role)
                {
                    case  UserRole.Admin: return
                            RedirectToAction("Add", "Doctor");

                    case UserRole.Patient:
                        return
                            RedirectToAction("Book", "Appointment");
                }

                return RedirectToAction("Login", "Account");
            }
            ViewBag.Error = "Invalid login!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
