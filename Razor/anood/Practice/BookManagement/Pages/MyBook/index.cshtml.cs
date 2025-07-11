using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Model;
using System.Threading.Tasks;

namespace BookManagement.Pages.MyBook
{
    public class indexModel : PageModel
    {
        private readonly BookContext _context;

        public indexModel (BookContext context)
        {
            _context = context;
        }
        public IList<Book> BookList { get; set; }
        public async Task OnGet()
        {
            BookList = await _context.books.ToArrayAsync();
        }
    }
}
