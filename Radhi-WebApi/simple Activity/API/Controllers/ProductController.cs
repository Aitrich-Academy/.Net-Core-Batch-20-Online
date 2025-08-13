using BOOKAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BOOKAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly BookDbContext _bookDbContext;

         public ProductController(BookDbContext bookDbContext)
        {
            _bookDbContext = bookDbContext;
        }
        [HttpGet]

        public async Task<IActionResult> Getallproduct()
        {
            var product = await _bookDbContext.Products.ToListAsync();
            return Ok(product);


        }

        [HttpPost]

        public ActionResult<Product> postbook(Product product)
        {
            _bookDbContext.Products.Add(product);
            _bookDbContext.SaveChanges();
            return Ok(product);
        }
        [HttpGet("{id}")]

        public ActionResult<Product> GetByid(int id)
        {
            var product = _bookDbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound($"product Id{id}not found  ");

            }
            else
            {
                return Ok(product);
            }

        }
        [HttpPut("{id}")]

        public ActionResult puBook(int id,Product product) 
        {

            if (id != product.Id)
            {
                return BadRequest();
            }
            _bookDbContext.Products.Update(product);
            _bookDbContext.SaveChanges();
            return Ok();
                


        }

        [HttpDelete("{id}")]

        public ActionResult deletebook(int id)
        {
            var product = _bookDbContext.Products.Find(id);
            if (product == null)
            {
                return NotFound($"product Id{id}not found  ");
            }

            _bookDbContext.Products.Remove(product);
               _bookDbContext.SaveChanges();
                 return Ok(product);


        }

    }
}
