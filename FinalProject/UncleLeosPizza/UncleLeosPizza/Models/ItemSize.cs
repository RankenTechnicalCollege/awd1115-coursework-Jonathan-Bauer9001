namespace UncleLeosPizza.Models
{
    public class ItemSize
    {
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
        public int SizeId { get; set; }
        public Size Size { get; set; } = null!;
        public decimal Price { get; set; } = 0.0m;
    }
}
