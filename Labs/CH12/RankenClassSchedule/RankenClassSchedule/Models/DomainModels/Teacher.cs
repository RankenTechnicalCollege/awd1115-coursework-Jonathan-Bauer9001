using System.ComponentModel.DataAnnotations;

namespace RankenClassSchedule.Models.DomainModels
{
    public class Teacher
    {
        public Teacher() => Classes = new HashSet<Class>(); // Constructor initiaalized collection
        public int TeacherId { get; set; } // Primary Key

        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "First Name cannot be longer than 100 characters.")]
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "Last Name cannot be longer than 100 characters.")]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; } = string.Empty;

        //read-only display property for full name
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Class> Classes { get; set; } // navigation property

    }
}
