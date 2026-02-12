using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; } = "";
        public string Gender { get; set; } = ""; // Men, Women, Unisex
        public ICollection<ProductSize> Sizes { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
