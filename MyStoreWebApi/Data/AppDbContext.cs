using Microsoft.EntityFrameworkCore;
using MyStoreWebApi.Models;

namespace MyStoreWebApi.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> products { get; set; }
        public DbSet<ProductSize> productsSize { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<ProductImage> productsImage { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Payment> payment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<ProductSize>();

        }
    }
}
