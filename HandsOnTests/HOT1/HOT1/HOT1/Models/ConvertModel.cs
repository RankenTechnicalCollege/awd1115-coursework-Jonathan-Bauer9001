using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HOT1.Models
{
    public class ConvertModel
    {
        [Required(ErrorMessage = "Distance Required")]
        [Range(1,500, ErrorMessage = "Distance must be between 1 and 500")]
        public double Inches { get; set; }
        public double Centimeters { get; set; }

        public void ConvertToCm()
        {
            Centimeters = Inches * 2.54;
        }

        public override string ToString()
        {
            return $"{Inches} inches is {Centimeters} centimeters".ToString();
        }
    }
}
