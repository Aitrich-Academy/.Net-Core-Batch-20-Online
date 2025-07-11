using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
           
            if (HttpContext.Session.GetString("Role") != "Admin")
                return RedirectToPage("/Login");

            var book = _context.Books.Find(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }

            return RedirectToPage("Index");
        }
    }
}
