namespace UncleLeosPizza.Models
{
    public class Size
    {
        public int SizeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<ItemSize> ItemSizes { get; set; } = new List<ItemSize>();
    }
}
