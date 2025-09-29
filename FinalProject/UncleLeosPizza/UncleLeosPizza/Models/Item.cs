namespace UncleLeosPizza.Models
{
    public class Item
    {
        public string ItemId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CategoryId { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;
    }
}
