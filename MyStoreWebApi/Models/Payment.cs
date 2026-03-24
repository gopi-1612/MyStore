using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; } = ""; // Card, UPI, PayPal
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } = "Success"; // Success, Failed, Pending
    }
}
