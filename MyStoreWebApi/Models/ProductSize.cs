using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class ProductSize
    {
        [Key]
        public int Id { get; set; }
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public int Stock { get; set; } // Stock per size
        public int ProductId { get; set; }

        public Product? Product { get; set; }
    }
}
