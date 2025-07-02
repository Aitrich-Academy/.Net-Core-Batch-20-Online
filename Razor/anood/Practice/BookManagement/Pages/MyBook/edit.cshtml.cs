using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookManagement.Model;

namespace BookManagement.Pages.MyBook
{
    public class editModel : PageModel
    {
        private readonly BookContext _context;
        public editModel(BookContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public Book mybook { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mybook = await _context.books.FirstOrDefaultAsync(s => s.BookId == id);
            if (mybook == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(mybook).State = EntityState.Modified;

            var existingStudent = _context.books.FirstOrDefault(Book => Book.BookId == mybook.BookId);
            if (existingStudent == null)
                return NotFound();



            existingStudent.BookName = mybook.BookName ;
            existingStudent.Author = mybook.Author ;
            existingStudent.Category  = mybook.Category ;
            existingStudent.prize  = mybook.prize ;


            _context.SaveChanges();

            return RedirectToPage("/Mybook/index");
        }
    }
}
    



