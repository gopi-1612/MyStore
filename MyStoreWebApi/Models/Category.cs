using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyStoreWebApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = ""; // Shirts, Jeans, Dresses
        public string Description { get; set; } = "";
        [JsonIgnore]
        public ICollection<Product>? Products { get; set; }
    }
}
