namespace UncleLeosPizza.Models
{
    public class ItemSize
    {
        public string ItemSizeId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public Item Item { get; set; } = null!;
        public string SizeId { get; set; } = string.Empty;
        public Size Size { get; set; } = null!;
        public decimal Price { get; set; } = 0.0m;
    }
}
