using BookLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Pages.Books
{
    public class IndexModel : PageModel
    {
       private readonly BookDbContext _dbContext;
        public IndexModel(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Book> Books{ get; set; }
        public async Task OnGetAsync()
        {
            Books = await _dbContext.books.ToListAsync();

        }

    }
}
