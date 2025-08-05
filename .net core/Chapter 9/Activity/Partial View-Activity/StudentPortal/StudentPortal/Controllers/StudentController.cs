using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext dbContext;
        public StudentController(StudentDbContext _dbContext) 
        { 
            dbContext = _dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Student");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var student=await dbContext.Students.ToListAsync();
            return View(student);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student=await dbContext.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student editStudent)
        {
            var student=await dbContext.Students.FindAsync(editStudent.Id);
            if (student != null) 
            { 
                student.Name = editStudent.Name;
                student.Email = editStudent.Email;
                student.Phone = editStudent.Phone;
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List","Student");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Student deleteStudent)
        {
           var student= await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(x => x.Id == deleteStudent.Id);
            if(student != null)
            {
                 dbContext.Students.Remove(deleteStudent);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List","Student");
        }
    }
}
