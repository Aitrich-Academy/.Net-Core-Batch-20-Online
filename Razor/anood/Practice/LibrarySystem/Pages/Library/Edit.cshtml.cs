using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Model;

namespace LibrarySystem.Pages.Library
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public Book mybook { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            mybook = await _context.Books.FirstOrDefaultAsync(s => s.Id == id);
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

            var existingStudent = _context.Books.FirstOrDefault(Book => Book.Id == mybook.Id);
            if (existingStudent == null)
                return NotFound();



            existingStudent.Title = mybook.Title;
            existingStudent.Author = mybook.Author;
            existingStudent.Quantity = mybook.Quantity;
            

            _context.SaveChanges();

            return RedirectToPage("/Library/index");
        }
    }
}

