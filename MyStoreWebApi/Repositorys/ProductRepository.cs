using Microsoft.EntityFrameworkCore;
using MyStoreWebApi.Data;
using MyStoreWebApi.Interfaces;
using MyStoreWebApi.Models;

namespace MyStoreWebApi.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task DeleteProduct(int id)
        {
            var product = await _context.products.FindAsync(id);
            if (product != null)
                _context.products.Remove(product);
            _context.SaveChanges();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.products
            .Include(p => p.Category)
            .Include(p => p.Sizes)
            .Include(p => p.Images)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IList<Product>> GetProducts()
        {
            return await _context.products.ToListAsync();

        }
        public async Task SaveProduct(Product product)
        {
            _context.products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProduct(int id, Product product)
        {

            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


    }
}
