using Libraries.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libraries.Pages.Books
{
    public class viewModel : PageModel
    {
        private readonly BookContext _Context;
        public viewModel(BookContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            Book = _Context.Book.FirstOrDefault(Book => Book.Id == id);
            if (Book == null)
                return NotFound();
            return Page();
        }
    }
}
