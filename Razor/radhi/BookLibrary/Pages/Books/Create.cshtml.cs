using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookDbContext _context;
        public CreateModel(BookDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)

                return Page();
            _context.books.Add(Book);
            _context.SaveChanges();
            return RedirectToPage("/Index");

        }
    }
       
}
