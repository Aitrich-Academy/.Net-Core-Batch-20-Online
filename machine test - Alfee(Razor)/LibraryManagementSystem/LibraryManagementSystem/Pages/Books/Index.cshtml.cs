using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public IndexModel(LibraryDbContext context)
        {
            _context = context;
        }

        public List<Book> Books { get; set; } = new();

        public void OnGet()
        {
            Books = _context.Books.ToList();
        }
    }
}
