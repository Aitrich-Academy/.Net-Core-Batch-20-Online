using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleAuthentication.Models;

namespace SimpleAuthentication.Pages.MyUser
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }

            // Store user in session
            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("/MyUser/Welcome");
        }
    }
}
