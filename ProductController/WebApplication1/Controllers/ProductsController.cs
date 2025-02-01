using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<string> Products = new List<string> { "Laptop", "Phone", "Tablet" };

        // GET: api/products
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= Products.Count)
                return NotFound("Product not found.");
            return Ok(Products[id]);
        }

        // POST: api/products
        [HttpPost]
        public IActionResult Post([FromBody] string product)
        {
            Products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = Products.Count - 1 }, product);
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string updatedProduct)
        {
            if (id < 0 || id >= Products.Count)
                return NotFound("Product not found.");
            Products[id] = updatedProduct;
            return NoContent();
        }

        // DELETE: api/products/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= Products.Count)
                return NotFound("Product not found.");
            Products.RemoveAt(id);
            return NoContent();
        }
    }
}
