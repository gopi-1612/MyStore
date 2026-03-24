using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyStoreWebApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public string Brand { get; set; } = "";
        public string Gender { get; set; } = ""; // Men, Women, Unisex
        [JsonIgnore]
        public ICollection<ProductSize>? Sizes { get; set; }
        [JsonIgnore]
        public ICollection<ProductImage>? Images { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }


    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public string Brand { get; set; } = "";
        public string Gender { get; set; } = ""; // Men, Women, Unisex
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = "";
    }
}
