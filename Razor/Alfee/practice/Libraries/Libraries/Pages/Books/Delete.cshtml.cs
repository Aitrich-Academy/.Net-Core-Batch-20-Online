using Libraries.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libraries.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly BookContext _Context;
        public DeleteModel(BookContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _Context.Book.FindAsync(id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var student = await _Context.Book.FindAsync(Book.Id);

            if (student != null)
            {
                _Context.Book.Remove(student);
                await _Context.SaveChangesAsync();
            }

            return RedirectToPage("index"); // or your main list page
        }
    }
}
