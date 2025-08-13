using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static List<string> books = new List<string>
        {
            "The Great Gatsby",
            "1984",
            "To Kill a Mockingbird"
        };

        // GET api/books
        [HttpGet]
        public IActionResult getAllbooks()
        {
            return Ok(books);
        }
    }
}
