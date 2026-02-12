using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; } = "";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
