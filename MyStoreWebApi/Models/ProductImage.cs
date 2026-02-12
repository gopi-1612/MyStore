using System.ComponentModel.DataAnnotations;

namespace MyStoreWebApi.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        public string ImageUrl { get; set; } = "";
        public bool IsPrimary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

    public class ProductImageUploadDto
    {
        public int ProductId { get; set; }
        public bool IsPrimary { get; set; }
    }
}
