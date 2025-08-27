using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/course

        [HttpGet]
        public ActionResult GetCourses()
        {
            var courses = _context.Courses.ToList();
            return Ok(courses);
        }

        // GET: api/course/{id}

        [HttpGet("{id}")]
        public ActionResult GetCourseById(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null) return NotFound();
            return Ok(course);
        }

        // POST: api/course
        [HttpPost]
        public ActionResult<Course> CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return Ok(course);
        }

        // PUT: api/course/{id}

        [HttpPut("{id}")]
        public IActionResult EditCourse(int id, Course updatedCourse)
        {
            if (id != updatedCourse.Id) return BadRequest("Course ID not found");
            _context.Courses.Update(updatedCourse);
            _context.SaveChanges();
            return Ok(updatedCourse);
        }

        // DELETE: api/course/{id
        
        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null) return NotFound();
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return Ok();
        }
    }
}
