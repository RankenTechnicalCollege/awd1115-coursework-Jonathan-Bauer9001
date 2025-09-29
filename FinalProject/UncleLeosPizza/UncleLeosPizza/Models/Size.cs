namespace UncleLeosPizza.Models
{
    public class Size
    {
        public string SizeId { get; set; } = string.Empty;
        public string ItemId { get; set; } = string.Empty;
        public Item Item { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.0m;
    }
}
