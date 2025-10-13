using System.ComponentModel.DataAnnotations;

namespace HOT3.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Brand is required")]
        public string? ProductBrand { get; set; } = string.Empty;
        [Required(ErrorMessage = "Product Name is required")]
        public string? ProductName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Product Price is required")]
        public decimal? ProductPrice { get; set; } = 0.0m;
        [Required(ErrorMessage = "Product Stock is required")]
        public int? ProductStock { get; set; } = 0;
        [Required(ErrorMessage = "Product Color is required")]
        public string? ProductColor { get; set; } = string.Empty;
        public string? ProductImageUrl { get; set; } = string.Empty;
        public string Slug => $"{ProductBrand}-{ProductName}-{ProductColor}".ToLower().Replace(" ", "-");
    }
}
