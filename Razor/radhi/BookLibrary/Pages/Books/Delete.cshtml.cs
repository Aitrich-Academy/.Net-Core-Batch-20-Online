using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly BookDbContext _context;
        public DeleteModel(BookDbContext context)
        {
            _context = context;
        }
        [BindProperty]

        public Book book { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            book = await _context.books.FirstOrDefaultAsync(m => m.id == id);

            if (book == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            book = await _context.books.FindAsync(id);

            if (book != null)
            {
                _context.books.Remove(book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }







    }
}
