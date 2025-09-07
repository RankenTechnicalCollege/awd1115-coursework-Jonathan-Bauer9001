
using System.ComponentModel.DataAnnotations;

namespace Project3dash1.Models
{
    public class PriceQuote
    {
        [Required(ErrorMessage = "Sales Price Required")]
        [Range(0, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal? SubTotal { get; set; }

        [Required(ErrorMessage = "Discount Percent Required")]
        [Range(0, 100, ErrorMessage = "Discount must be 0 to 100")]
        public decimal? DiscountPercent { get; set; }
        public decimal? Total { get; set; }
        public decimal? DiscountAmount { get; set; }
        public void CalculateQuote()
        {
            decimal? subTotal = SubTotal;
            decimal? discountPercent = DiscountPercent;
            decimal? discountAmount = subTotal * (discountPercent / 100);
            decimal? total = subTotal - discountAmount;
            DiscountAmount = discountAmount;
            Total = total;
        }
    }
}
