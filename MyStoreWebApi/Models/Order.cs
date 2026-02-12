using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "Pending"; // Pending, Shipped, Delivered, Cancelled
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> Items { get; set; }
    }
}
