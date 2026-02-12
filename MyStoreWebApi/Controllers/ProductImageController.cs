using Microsoft.AspNetCore.Mvc;
using MyStoreWebApi.Data;

namespace MyStoreWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductImageController : Controller
    {

        private readonly IWebHostEnvironment _env;
        private readonly AppDbContext _context;

        //    public ProductImageController(IWebHostEnvironment env, AppDbContext context)
        //    {
        //        _env = env;
        //        _context = context;
        //    }

        //    [HttpPost("upload")]
        //    public async Task<IActionResult> UploadImage(
        //        [FromForm] IFormFile image,
        //        [FromForm] ProductImageUploadDto dto)
        //    {
        //        if (image == null || image.Length == 0)
        //            return BadRequest("Image is required");

        //        var allowedTypes = new[] { "image/jpeg", "image/png", "image/webp" };
        //        if (!allowedTypes.Contains(image.ContentType))
        //            return BadRequest("Invalid image format");

        //        var folderPath = Path.Combine(
        //            _env.WebRootPath,
        //            "product-images",
        //            DateTime.Now.Year.ToString(),
        //            DateTime.Now.Month.ToString()
        //        );

        //        if (!Directory.Exists(folderPath))
        //            Directory.CreateDirectory(folderPath);

        //        var fileName = $"product_{dto.ProductId}_{Guid.NewGuid()}{Path.GetExtension(image.FileName)}";
        //        var filePath = Path.Combine(folderPath, fileName);

        //        using var stream = new FileStream(filePath, FileMode.Create);
        //        await image.CopyToAsync(stream);

        //        var imageUrl = $"/product-images/{DateTime.Now.Year}/{DateTime.Now.Month}/{fileName}";

        //        var productImage = new ProductImage
        //        {
        //            ProductId = dto.ProductId,
        //            ImageUrl = imageUrl,
        //            IsPrimary = dto.IsPrimary
        //        };

        //        _context.productsImage.Add(productImage);
        //        await _context.SaveChangesAsync();

        //        return Ok(productImage);
        //    }
    }
}
