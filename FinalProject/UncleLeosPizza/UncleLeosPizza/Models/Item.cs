using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace UncleLeosPizza.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        [Required(ErrorMessage = "Must Enter Name")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Must Enter Description")]
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Must Select a Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; } = null!;
        public ICollection<ItemSize> ItemSizes { get; set; } = new List<ItemSize>();
        public string Slug => Name.ToLower().Replace(' ', '-');
    }
}
