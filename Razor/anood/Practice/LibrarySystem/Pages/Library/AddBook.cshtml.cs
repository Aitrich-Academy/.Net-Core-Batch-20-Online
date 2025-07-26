using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library
{
    public class AddBookModel : PageModel
    {
        private readonly ApplicationDbContext  _context;

       // [BindProperty]
       // public string SelectedRole { get; set; } = "Admin";

        public AddBookModel(ApplicationDbContext context)
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
            _context.Books.Add(books);
            _context.SaveChanges();

            return RedirectToPage("/Library/index");
        }
    }
}

