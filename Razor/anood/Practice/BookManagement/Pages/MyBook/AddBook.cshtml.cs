using BookManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookManagement.Pages.MyBook
{
    public class AddBookModel : PageModel
    {

        private readonly BookContext _context;

        public AddBookModel(BookContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public Book books { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)

                return Page();
            _context.books.Add(books);
            _context.SaveChanges();

            return RedirectToPage("/MyBook/index");
        }
    }
}
