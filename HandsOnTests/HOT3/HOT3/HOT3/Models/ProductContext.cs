using Microsoft.EntityFrameworkCore;
namespace HOT3.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<Purchase> Purchases { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductBrand = "Dragon Shield",
                    ProductName = "Matte Dual Sleeves",
                    ProductPrice = 14.99m,
                    ProductStock = 32,
                    ProductColor = "Gooseberry",
                    ProductImageUrl = "DS-DM-Gooseberry.jpg"
                },
                new Product
                {
                    ProductId = 2,
                    ProductBrand = "Dragon Shield",
                    ProductName = "Matte Dual Sleeves",
                    ProductPrice = 14.99m,
                    ProductStock = 48,
                    ProductColor = "Blossom",
                    ProductImageUrl = "DS-DM-Blossom.jpg"
                },
                new Product
                {
                    ProductId = 3,
                    ProductBrand = "Dragon Shield",
                    ProductName = "Matte Dual Sleeves",
                    ProductPrice = 16.99m,
                    ProductStock = 25,
                    ProductColor = "Pomegranate & Gold",
                    ProductImageUrl = "DS-DM-PomegranateGold.jpg"
                },
                new Product
                {
                    ProductId = 4,
                    ProductBrand = "Dragon Shield",
                    ProductName = "Matte Dual Sleeves",
                    ProductPrice = 16.99m,
                    ProductStock = 40,
                    ProductColor = "Cobalt & Silver",
                    ProductImageUrl = "DS-DM-CobaltSilver.jpg"
                },
                new Product
                {
                    ProductId = 5,
                    ProductBrand = "Dragon Shield",
                    ProductName = "Matte Dual Sleeves",
                    ProductPrice = 7.99m,
                    ProductStock = 20,
                    ProductColor = "Clear",
                    ProductImageUrl = "DS-PF-Clear.jpg"
                },
                new Product
                {
                    ProductId = 6,
                    ProductBrand = "Ultra Pro",
                    ProductName = "Eclipse Gloss",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Black",
                    ProductImageUrl = "UP-EG-JetBlack.jpg"
                },
                new Product
                {
                    ProductId = 7,
                    ProductBrand = "Ultra Pro",
                    ProductName = "Eclipse Gloss",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Sky Blue",
                    ProductImageUrl = "UP-EG-SkyBlue.jpg"
                },
                new Product
                {
                    ProductId = 8,
                    ProductBrand = "Ultra Pro",
                    ProductName = "Eclipse Matte",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Apple Red",
                    ProductImageUrl = "UP-EM-AppleRed.jpg"
                },
                new Product
                {
                    ProductId = 9,
                    ProductBrand = "Ultra Pro",
                    ProductName = "Eclipse Matte",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Forest Green",
                    ProductImageUrl = "UP-EM-ForestGreen.jpg"
                },
                new Product
                {
                    ProductId = 10,
                    ProductBrand = "Ultimate Guard",
                    ProductName = "Matte Cortex",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Orange",
                    ProductImageUrl = "UG-MC-Orange.jpg"
                },
                new Product
                {
                    ProductId = 11,
                    ProductBrand = "Ultimate Guard",
                    ProductName = "Matte Cortex",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Purple",
                    ProductImageUrl = "UG-MC-Purple.jpg"
                },
                new Product
                {
                    ProductId = 12,
                    ProductBrand = "Ultimate Guard",
                    ProductName = "Matte Cortex",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Petrol",
                    ProductImageUrl = "UG-MC-Petrol.jpg"
                },
                new Product
                {
                    ProductId = 13,
                    ProductBrand = "Ultimate Guard",
                    ProductName = "Matte Cortex",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Pink",
                    ProductImageUrl = "UG-MC-Pink.jpg"
                },
                new Product
                {
                    ProductId = 14,
                    ProductBrand = "Ultimate Guard",
                    ProductName = "Matte Cortex",
                    ProductPrice = 9.99m,
                    ProductStock = 50,
                    ProductColor = "Yellow",
                    ProductImageUrl = "UG-MC-Yellow.jpg"
                }
                );
        }
    }
}
