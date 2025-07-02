using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleAuthentication.Model;
using Microsoft.AspNetCore.Http;
using System.Linq;
using SimpleAuthentication.Model;

namespace SimpleAuthentication.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public LoginModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ModelState.AddModelError("", "Username and Password are required.");
                return Page();
            }

            var user = _Context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password.");
                return Page();
            }

            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("/Index"); // Redirect to home/dashboard
        }
    }
}