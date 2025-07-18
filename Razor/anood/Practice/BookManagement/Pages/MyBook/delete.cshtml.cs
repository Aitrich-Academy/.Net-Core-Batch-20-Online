using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Model;

namespace BookManagement.Pages.MyBook
{
    public class deleteModel : PageModel
    {
        private readonly BookContext _context;

        public deleteModel(BookContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book  mybook { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mybook = await _context.books.FirstOrDefaultAsync(s => s.BookId == id);
            if (mybook == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            mybook = await _context.books.FirstOrDefaultAsync(s => s.BookId == id);

            if (mybook == null)
            {
                return NotFound();
            }

            _context.books.Remove(mybook);
            await _context.SaveChangesAsync();

            return RedirectToPage("index");
        }
    }
}
