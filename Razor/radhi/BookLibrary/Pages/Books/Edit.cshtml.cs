using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace BookLibrary.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly BookDbContext _Context;

        public EditModel(BookDbContext context)
        {
            _Context = context;
        }
        [BindProperty]

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _Context.books.FindAsync(id);
            if (Book == null)
            {
                return NotFound();
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _Context.Attach(Book).State = EntityState.Modified;

            try
            {
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_Context.books.Any(e => e.id == Book.id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }

    




        
    }
}
