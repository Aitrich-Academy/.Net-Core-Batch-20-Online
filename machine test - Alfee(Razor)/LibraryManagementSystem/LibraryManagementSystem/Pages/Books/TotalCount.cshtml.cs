using LibraryManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Pages.Books
{
    public class TotalCountModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public TotalCountModel(LibraryDbContext context)
        {
            _context = context;
        }

        public int TotalBooks { get; set; }

        public void OnGet()
        {
            TotalBooks = _context.Books.Count();
        }
    }
}
