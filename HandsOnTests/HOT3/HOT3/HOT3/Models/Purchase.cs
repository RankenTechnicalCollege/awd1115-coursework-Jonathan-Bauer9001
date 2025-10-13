namespace HOT3.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public int? Quantity { get; set; } 
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        
        public decimal? TotalPrice { get; set; }
    }
}
