namespace HOT3.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Product? Product { get; set; }   
        public int Quantity { get; set; } = 0;
        }
}
