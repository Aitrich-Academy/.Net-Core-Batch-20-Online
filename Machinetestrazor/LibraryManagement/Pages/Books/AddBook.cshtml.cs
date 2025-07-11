using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Books
{
    public class AddBookModel : PageModel
    {
        private readonly ApplicationDbContext _context;

      

        public AddBookModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty] public Book NewBook { get; set; }

        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
                return RedirectToPage("/Login");
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Books.Add(NewBook);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
