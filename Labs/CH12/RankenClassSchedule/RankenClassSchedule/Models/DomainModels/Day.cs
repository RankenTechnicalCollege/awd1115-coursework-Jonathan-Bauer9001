using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace RankenClassSchedule.Models.DomainModels
{
    public class Day
    {
        public Day() => Classes = new HashSet<Class>(); // Initialize navigation property
        public int DayId { get; set; } // Primary Key

        //no error messages included bc users won't be entering days
        // EF will generate a non-null nvarchar with length shorter than max
        [StringLength(10)]
        [Required()]
        public string Name { get; set; } = string.Empty;

        public ICollection<Class> Classes { get; set; } // navigation property
    }
}
