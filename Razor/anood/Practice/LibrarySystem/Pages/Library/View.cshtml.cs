using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Model;
using System.Threading.Tasks;

namespace LibrarySystem.Pages.Library
{
    public class ViewModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Book> BookList { get; set; }
        public async Task OnGet()
        {
            BookList = await _context.Books.ToArrayAsync();
        }
    }
}
