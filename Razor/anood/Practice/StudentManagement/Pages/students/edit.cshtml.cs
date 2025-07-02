using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;

namespace StudentManagement.Pages.students
{
    public class editModel : PageModel
    {
        private readonly StudentContext _context;
        public editModel(StudentContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public student students { get; set; }




        //public IActionResult OnGet(int id)
        //    {
        //    students =  _context.students.FirstOrDefault(students => students.studentId == id);
        //    if (students == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}


        public async Task<IActionResult> OnGetAsync(int id)
        {
            students = await _context.students.FirstOrDefaultAsync(s => s.studentId == id);
            if (students == null)
            {
                return NotFound();
            }
            return Page();
        }



        //        public async Task<IActionResult> OnPostAsync()
        //        {
        //            if (!ModelState.IsValid)
        //                return Page();

        //            var existingStudent = await _context.students.FirstOrDefaultAsync(s => s.studentId == students.studentId);
        //            if (existingStudent == null)
        //                return NotFound();

        //            existingStudent.StudentName = students.StudentName;
        //            existingStudent.Batch = students.Batch;


        //            await _context.SaveChangesAsync();

        //            return RedirectToPage("/students/index");
        //        }

        //    }
        //}

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(students).State = EntityState.Modified;

            var existingStudent = _context.students.FirstOrDefault(student => student.studentId == students.studentId);
            if (existingStudent == null)
                return NotFound();



            existingStudent.StudentName = students.StudentName;
            existingStudent.Batch = students.Batch;


            _context.SaveChanges();

            return RedirectToPage("/students/index");
        }
    }
}

//< a asp - page - handler = "Details" asp - route - id = "@Model.students.studentId" > Details </ a >