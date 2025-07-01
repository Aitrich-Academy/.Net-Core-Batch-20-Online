using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Pages.Books
{
    public class ViewModel : PageModel
    {
        private readonly BookDbContext _context;
        public ViewModel(BookDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }
        public async Task OnGetAsync(int id)
        {
            Book = await _context.books.FindAsync(id);
        }

       
    }
}
