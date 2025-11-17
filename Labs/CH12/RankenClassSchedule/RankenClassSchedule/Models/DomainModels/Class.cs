using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace RankenClassSchedule.Models.DomainModels
{
    public class Class
    {
        public int ClassId { get; set; } // Primary Key

        [StringLength(200, ErrorMessage = "Title may not exceed 200 characters.")]
        [Required(ErrorMessage = "Title is required.")]

        public string Title { get; set; } = string.Empty;

        [Range(100, 500, ErrorMessage = "Class numbner must be between 100 and 500.")]
        [Required(ErrorMessage = "Class number is required.")]
        public int? Number { get; set; }

        [Display(Name = "Time")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter numbers only fort class time.")]
        [StringLength(4, ErrorMessage = "Class time must be 4 characters long.")]
        [Required(ErrorMessage = "Class time is required. (in military time format)")]
        public string MilitaryTime { get; set; } = string.Empty;

        public int TeacherId { get; set; } // Foreign Key   
        [ValidateNever]
        public Teacher Teacher { get; set; } // Navigation Property
        
        public int DayId { get; set; } // Foreign Key
        [ValidateNever]
        public Day Day { get; set; } // Navigation Property
    }
}
