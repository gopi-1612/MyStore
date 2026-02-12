using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyStoreWebApi.Data;
using MyStoreWebApi.Models;

namespace MyStoreWebApi.Controllers
{
    [ApiController]
    [Route("")]
    public class ProductSizeSizeController : ControllerBase
    {

        private readonly AppDbContext _context;
        public ProductSizeSizeController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductSize>>> GetProductSizeSize()
        {
            return await _context.productsSize
                .Include(p => p.Id)
                .Include(p => p.Size)
                .Include(p => p.Quantity)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSize>> GetProductSize(int id)
        {
            var productSize = await _context.productsSize
                .Include(p => p.Id)
                .Include(p => p.Size)
                .Include(p => p.Quantity)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (productSize == null) return NotFound();
            return productSize;
        }

        [HttpPost]
        public async Task<ActionResult<ProductSize>> CreateProductSize(ProductSize productSize)
        {
            _context.productsSize.Add(productSize);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProductSize), new { id = productSize.Id }, productSize);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductSize(int id, ProductSize productSize)
        {
            if (id != productSize.Id) return BadRequest();
            _context.Entry(productSize).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSize(int id)
        {
            var productSize = await _context.productsSize.FindAsync(id);
            if (productSize == null) return NotFound();
            _context.productsSize.Remove(productSize);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
