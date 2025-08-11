using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleMVC.Models;

namespace SampleMVC.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _context;
        
        public StudentController (AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index"); 
            }
            return View(student);
        }

        //public IActionResult Index()
        //{
        //    var students = _context.Students.OrderBy(s => s.Id).ToList();
        //    return View(students);
        //}


        public async Task<IActionResult> Index(string? searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            IQueryable<Student> students = _context.Students;

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                // Case-insensitive on SQL Server—maps to LIKE '%searchString%' automatically
                students = students.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper()));
            }

            return View(await students.ToListAsync());
        }

        [HttpGet]
        public IActionResult ViewStudent(int? id)
        {
            if (id == null)
                return NotFound();

            var student = _context.Students.Find(id.Value);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var s = _context.Students.Find(id);
            if (s == null) return NotFound();
            return View(s);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id) return BadRequest();
            if (!ModelState.IsValid) return View(student);
            _context.Update(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var std = _context.Students.Find(id.Value);
            if (std == null)
                return NotFound();

            return View(std);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var std = _context.Students.Find(id);
            if (std != null)
            {
                _context.Students.Remove(std);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        

    }
}
