using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string Size { get; set; } = "";
        public int Quantity { get; set; }
    }
}
