using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.Books
{
    public class DeleteBookModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public DeleteBookModel(LibraryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book? Book { get; set; }

        public IActionResult OnGet(int id)
        {
            Book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (Book == null)
                return RedirectToPage("Index", new { role = "admin" });

            return Page();
        }

        public IActionResult OnPost()
        {
            if (Book != null)
            {
                var existing = _context.Books.Find(Book.Id);
                if (existing != null)
                {
                    _context.Books.Remove(existing);
                    _context.SaveChanges();
                }
            }

            return RedirectToPage("Index", new { role = "admin" });
        }
    }
}
