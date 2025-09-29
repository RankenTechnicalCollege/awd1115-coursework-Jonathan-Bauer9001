namespace UncleLeosPizza.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public string OrderId { get; set; } = string.Empty;
        public Order Order { get; set; } = null!;
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        public int Quantity { get; set; } = 0;
        public decimal UnitPrice { get; set; } = 0.0m;
    }
}
