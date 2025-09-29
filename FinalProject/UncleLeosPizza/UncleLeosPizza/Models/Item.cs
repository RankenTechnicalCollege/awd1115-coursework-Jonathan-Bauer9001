namespace UncleLeosPizza.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public int CategoryId { get; set; } 
        public Category Category { get; set; } = null!;
        public ICollection<ItemSize> ItemSizes { get; set; } = new List<ItemSize>();
    }
}
