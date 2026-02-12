using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = ""; // Shirts, Jeans, Dresses
        public string Description { get; set; } = "";
        public ICollection<Product>? Products { get; set; }
    }
}
