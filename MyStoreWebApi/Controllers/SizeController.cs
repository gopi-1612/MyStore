using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyStoreWebApi.Data;
using MyStoreWebApi.Models;

namespace MyStoreWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SizeController : Controller
    {
        private readonly AppDbContext _context;
        public SizeController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IList<Size>> GetSizes()
        {
            return await _context.sizes.ToListAsync();

        }


        [HttpPost]
        public async Task<ActionResult<Size>> CreateSize(Size size)
        {

            _context.sizes.Add(size);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSizes), new { id = size.Id }, size);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSize(int id)
        {
            var size = await _context.sizes.FindAsync(id);
            if (size == null) return NotFound();
            _context.sizes.Remove(size);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
