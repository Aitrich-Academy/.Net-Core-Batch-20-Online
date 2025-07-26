using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Model;

namespace LibrarySystem.Pages.Library
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book mybook { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mybook = await _context.Books.FirstOrDefaultAsync(s => s.Id == id);
            if (mybook == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            mybook = await _context.Books.FirstOrDefaultAsync(s => s.Id == id);

            if (mybook == null)
            {
                return NotFound();
            }

            _context.Books.Remove(mybook);
            await _context.SaveChangesAsync();

            return RedirectToPage("index");
        }
    }
}

