using System.ComponentModel.DataAnnotations;
namespace TipCalculatorApp.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Enter Valid Meal Amount")]
        [Range(0, double.MaxValue, ErrorMessage = "Enter an Amount Greater Than 0")]
        public decimal? MealCost { get; set; }
        public decimal? Tip15P { get; set; }
        public decimal? Tip20P { get; set; }
        public decimal? Tip25P { get; set; }
        public void CalculateTip()
        {
            Tip15P = MealCost * .15m;
            Tip20P = MealCost * .20m;
            Tip25P = MealCost * .25m;
        }

    }
}
