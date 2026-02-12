using MyStoreWebApi.Models;

namespace MyStoreWebApi.Interfaces
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task SaveProduct(Product product);
        Task UpdateProduct(int id, Product product);
        Task DeleteProduct(int id);
    }
}
