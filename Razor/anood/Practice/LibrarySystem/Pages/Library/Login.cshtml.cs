using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibrarySystem.Model;
using Microsoft.AspNetCore.Http;

namespace LibrarySystem.Pages.Library
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
         public string role { get; set; }

        public IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }

            var role = user.Role;
            var userId = user.Id;
            // Store user in session

            HttpContext.Session.SetString("User", Username);
            HttpContext.Session.SetString("Role", role);
            HttpContext.Session.SetInt32("UserId", userId);
            if (role == "Admin")
            { 
                return RedirectToPage("/Library/index");
            }
            else if (role == "User")
            {
                return RedirectToPage("/Library/View");
            }

            ModelState.AddModelError("", "User role not recognized");
            return Page();

        }
    }
}
