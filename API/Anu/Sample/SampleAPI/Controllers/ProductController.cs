using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Migrations;
using SampleAPI.Models;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpGet]
        public ActionResult GetProduct()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {

                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public ActionResult EditProduct(int id, Product updateproduct)
        {
            if (id != updateproduct.Id)
            {
                return BadRequest();
            }
            _context.Products.Update(updateproduct);
            _context.SaveChanges();
            return Ok();
        }

        //[HttpPut("{id}")]
        //public ActionResult EditProduct(int id, Product updateproduct)
        //{
        //    if (id != updateproduct.Id)
        //    {
        //        return BadRequest();
        //    }
        //    var product = _context.Products.Find(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    product .Name= updateproduct.Name;
        //    product.Price = updateproduct.Price;
        //    _context.SaveChanges();
        //    return Ok();
        //}


        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product =_context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }

    }
}
