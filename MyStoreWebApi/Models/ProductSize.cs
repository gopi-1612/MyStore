using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class ProductSize
    {
        [Key]
        public int Id { get; set; }
        public string Size { get; set; } = ""; // S, M, L, XL
        public int Quantity { get; set; } // Stock per size
        public int ProductId { get; set; }
    }
}
