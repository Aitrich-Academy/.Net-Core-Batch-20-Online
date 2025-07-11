using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Model;

namespace BookManagement.Pages.MyBook
{
    public class viewModel : PageModel
    {
        private readonly BookContext _context;

        public viewModel (BookContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Book mybook { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mybook = await _context.books.FirstOrDefaultAsync(s => s.BookId == id);
            if (mybook == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
