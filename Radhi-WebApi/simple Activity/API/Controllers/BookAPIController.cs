using BOOKAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BOOKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAPIController : ControllerBase
    {
        private readonly BookDbContext _dbContext;

        public BookAPIController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]

        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _dbContext.Books.ToListAsync();
            return Ok(books);
        }

     

       


    }
}
