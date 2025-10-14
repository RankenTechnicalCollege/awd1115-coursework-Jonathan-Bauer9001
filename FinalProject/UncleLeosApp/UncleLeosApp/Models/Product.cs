using System.ComponentModel.DataAnnotations;

namespace UncleLeosApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Product Description is required")]
        public string? ProductDescription { get; set; }
        [Required(ErrorMessage = "Product Price is required")]
        public decimal? ProductPrice { get; set; }
        [Required(ErrorMessage = "Product Image is required")]
        public string? ProductImage { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string Slug => ProductName?.ToLower().Replace(' ', '-');
    }
}
