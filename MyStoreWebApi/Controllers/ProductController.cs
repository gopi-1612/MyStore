using Microsoft.AspNetCore.Mvc;
using MyStoreWebApi.Interfaces;
using MyStoreWebApi.Models;

namespace MyStoreWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductRepository _product;
        public ProductController(IProductRepository product)
        {
            _product = product;
        }


        [HttpGet]
        public async Task<ActionResult<IList<Product>>> GetProducts()
        {
            var product = await _product.GetProducts();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {

            var product = await _product.GetProductById(id);
            if (product == null) return NotFound();
            return product;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(Product product)
        {
            await _product.SaveProduct(product);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            await _product.UpdateProduct(id, product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _product.DeleteProduct(id);
            return NoContent();
        }
    }
}
