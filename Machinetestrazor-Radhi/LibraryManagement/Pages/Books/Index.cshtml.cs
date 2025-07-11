using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Pages.Books
{
    public class IndexModel : PageModel
    {
       
            private readonly ApplicationDbContext _context;

            public List<Book> Books { get; set; }
            public string Role { get; set; }

            public IndexModel(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<IActionResult> OnGetAsync()
            {
                
                if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                    return RedirectToPage("/Login");

                Role = HttpContext.Session.GetString("Role"); //fetch from session
                Books = await _context.Books.ToListAsync();
                return Page();
            }
        }

    }

