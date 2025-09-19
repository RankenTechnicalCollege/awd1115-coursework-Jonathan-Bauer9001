using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Project4dash1.Models
{
    public class Contact
    {
        public int ContactId { get; set; } //primary key

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Phone is required")]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category")]
        public int CategoriesId { get; set; } // Foreign key property

        [ValidateNever]
        public Categories Categories { get; set; } = null!; // Navigation property
        public string Slug => FirstName?.ToLower() + "-" + LastName?.ToLower();

        public DateTime DateAdded { get; set; } = new DateTime();

    }
}
