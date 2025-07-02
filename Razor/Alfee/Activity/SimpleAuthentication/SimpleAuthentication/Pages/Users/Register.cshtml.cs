using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleAuthentication.Model;
using SimpleAuthentication.Model;
using System.Linq;

namespace SimpleAuthentication.Pages.Users
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _Context;

        public RegisterModel(ApplicationDbContext context)
        {
            _Context = context;
        }

        [BindProperty]
        public User NewUser { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || string.IsNullOrWhiteSpace(NewUser.Username) || string.IsNullOrWhiteSpace(NewUser.Password))
            {
                ModelState.AddModelError("", "Username and Password are required.");
                return Page();
            }

            if (_Context.Users.Any(u => u.Username == NewUser.Username))
            {
                ModelState.AddModelError("", "Username already taken.");
                return Page();
            }

            _Context.Users.Add(NewUser);
            _Context.SaveChanges();

            return RedirectToPage("/Users/Login");
        }
    }
}