namespace HOT3.Models
{
    public class ShoppingCartViewModel
    {
        public List<ShoppingCartItem> CartItems { get; set; } = new List<ShoppingCartItem>();
        public decimal? TotalPrice { get; set; } = 0.0m;
        public int? TotalQuantity { get; set; } = 0;
    }
}
