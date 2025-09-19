using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SalesOrder.Models
{
    public class SalesOrderContext : DbContext
    {
        public SalesOrderContext(DbContextOptions<SalesOrderContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName = "Accessories" },
                new Category() { CategoryId = 2, CategoryName = "Bikes" },
                new Category() { CategoryId = 3, CategoryName = "Clothing" },
                new Category() { CategoryId = 4, CategoryName = "Components" },
                new Category() { CategoryId = 5, CategoryName = "Car racks" },
                new Category() { CategoryId = 6, CategoryName = "Wheels" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "AeroFlo ATB Wheels", ProductDescShort = "", ProductDescLong = "", ProductImage = "", ProductPrice = 189, ProductQty = 40, CategoryId = 4 },
                new Product() { ProductId = 2, ProductName = "Clear Shade 85-T Glasses", ProductDescShort = "", ProductDescLong = "", ProductImage = "", ProductPrice = 45, ProductQty = 14, CategoryId = 1 },
                new Product() { ProductId = 3, ProductName = "Cosmic Elite Road Warrior Wheels", ProductDescShort = "", ProductDescLong = "", ProductImage = "", ProductPrice = 165, ProductQty = 22, CategoryId = 4 },
                new Product() { ProductId = 4, ProductName = "Cycle-Doc Pro Repair Stand", ProductDescShort = "", ProductDescLong = "", ProductImage = "", ProductPrice = 166, ProductQty = 12, CategoryId = 1 },
                new Product() { ProductId = 5, ProductName = "Dog Ear Aero-Flow Floor Pump", ProductDescShort = "", ProductDescLong = "", ProductImage = "", ProductPrice = 5, ProductQty = 25, CategoryId = 1 }
                );
        }
    }
}
