using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentController (AppDbContext context)
        {
            _context = context;
        }

        // GET: api/student

        [HttpGet]

        public ActionResult GetStudents()
        {
            var students = _context.Students.ToList();
            return Ok(students);
        }

        // GET: api/student/{id}

        [HttpGet("{id}")]
        public ActionResult GetStudentById(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();
            return Ok(student);
        }

        // POST: api/student

        [HttpPost]
        public ActionResult<Student> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok(student);
        }

        // PUT: api/student/{id}

        [HttpPut("{id}")]
        public IActionResult EditStudent(int id, Student updatedStudent)
        {
            if (id != updatedStudent.Id) return BadRequest("Student ID not found");
            _context.Students.Update(updatedStudent);
            _context.SaveChanges();
            return Ok(updatedStudent);
        }

        // DELETE: api/student/{id}

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();
            _context.Students.Remove(student);
            _context.SaveChanges();
            return Ok();
        }
    }
}
