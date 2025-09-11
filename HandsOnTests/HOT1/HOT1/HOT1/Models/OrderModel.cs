using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace HOT1.Models
{
    public class OrderModel
    {
        [Required(ErrorMessage = "Must Enter Quantity")]
        [Range(1,double.MaxValue, ErrorMessage ="Quantity must be a positive number")]
        public int Quantity { get; set; }
        public string? DiscountCode { get; set; }
        public string? Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }

        public void OrderForm()
        {
            SubTotal = (decimal)(Quantity * 15);

            if(DiscountCode == null)
            {
                Discount = "";
            }
            else
            {
                if (DiscountCode == "6175")
                {
                    SubTotal = SubTotal - (SubTotal * .3m);
                    Discount = "30% Discount Applied";
                }
                else if (DiscountCode == "1390")
                {
                    SubTotal = SubTotal - (SubTotal * .2m);
                    Discount = "20% Discount Applied";
                }
                else if (DiscountCode == "BB88")
                {
                    SubTotal = SubTotal - (SubTotal * .1m);
                    Discount = "10% Discount Applied";
                }
                else
                {
                    SubTotal = SubTotal;
                    Discount = "Invalid Discount Code";
                }
            }
  
            Tax = SubTotal * .08m;
            Total = SubTotal + Tax;
        }

        public override string ToString()
        {
            return $"{Quantity} T-Shirts @{(SubTotal / Quantity).ToString("C")} each\n" +
                   $"---------------------------------\n\n" +
                   $"Subtotal:{SubTotal.ToString("C")}\n" +
                   $"Tax:{Tax.ToString("C")}\n" +
                   $"Total:{Total.ToString("C")}\n" +
                   $"".ToString();
        }
    }
}

