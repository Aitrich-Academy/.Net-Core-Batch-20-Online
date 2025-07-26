using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class AddBookModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public AddBookModel(LibraryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            _context.Books.Add(Book);
            _context.SaveChanges();

            return RedirectToPage("Index", new { role = "admin" });
        }
    }
}
