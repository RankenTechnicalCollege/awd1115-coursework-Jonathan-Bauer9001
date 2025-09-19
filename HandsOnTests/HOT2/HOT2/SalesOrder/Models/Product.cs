using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product Short Description is required")]
        public string ProductDescShort { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product Long Description is required")]
        public string ProductDescLong { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product Image URL is required")]
        public string ProductImage { get; set; } = string.Empty;

        [Range(1, 100000, ErrorMessage = "Product Price must be between 1 and 100,000")]
        public decimal ProductPrice { get; set; }

        [Range(1, 10000, ErrorMessage = "Product Quantity must be between 1 and 1,000")]
        public int ProductQty { get; set; }
        [ValidateNever]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; } = null!;
        public string Slug => ProductName?.ToLower().Replace(' ', '-');
    }
}
