using Microsoft.EntityFrameworkCore;
using UncleLeosPizza.Models;
namespace UncleLeosPizza.Models
{
    public class UncleLeosContext : DbContext
    {
        public UncleLeosContext(DbContextOptions<UncleLeosContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Size> Sizes { get; set; } = null!;
        public DbSet<ItemSize> ItemSizes { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composite key for bridge table
            modelBuilder.Entity<ItemSize>()
                .HasKey(iz => new { iz.ItemId, iz.SizeId });

            modelBuilder.Entity<ItemSize>()
                .HasOne(iz => iz.Item)
                .WithMany(iz => iz.ItemSizes)
                .HasForeignKey(iz => iz.ItemId);

            modelBuilder.Entity<ItemSize>()
                .HasOne(iz => iz.Size)
                .WithMany(s => s.ItemSizes)
                .HasForeignKey(iz => iz.SizeId);

            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Pizza" },
                    new Category { CategoryId = 2, Name = "Salad" },
                    new Category { CategoryId = 3, Name = "Appetizer" },
                    new Category { CategoryId = 4, Name = "Dessert" },
                    new Category { CategoryId = 5, Name = "Beverage" },
                    new Category { CategoryId = 6, Name = "Merchandise" }
                    );
            modelBuilder.Entity<Item>().HasData(
                    new Item { ItemId = 1, Name = "Uncle Leo's Deluxe", Description = "Homemade Red Sauce Base w/ Sausage, Pepperoni, Onion, Fresh Mushrooms, Black Olives, Green Pepper, topped with Provel Cheese", CategoryId = 1, },
                    new Item { ItemId = 2, Name = "Meat Trio", Description = "Homemade Red Sauce Base Topped w/ Italian Sausage, Pepperoni, Crispy Bacon, and Provel Cheese", CategoryId = 1 },
                    new Item { ItemId = 3, Name = "Joey's Fave", Description = "Homemade Red Sauce Base Topped w/ Beef, Onion, Tomato, Jalapenos Peppers, and Provel Cheese", CategoryId = 1 },
                    new Item { ItemId = 4, Name = "Chicken D'Light", Description = "Homemade White Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Fresh Mushrooms, Crispy Bacon, Baby Spinach, and Provel Cheese", CategoryId = 1 },
                    new Item { ItemId = 5, Name = "Sausage Special", Description = "Homemade White Sauce Base Topped w/ Italian Sausage, Yellow Onion, Crispy Bacon, Baby Spinach, and Provel Cheese", CategoryId = 1 },
                    new Item { ItemId = 6, Name = "Fungo Chicken", Description = "FUNGO SAUCE! Special Made Buffalo Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Crispy Bacon, and Provel Cheese", CategoryId = 1 },
                    new Item { ItemId = 7, Name = "Mariann's Margherita", Description = "Olive Oil Base Topped w/ Tomatoes, Basil, Garlic, and Mozzerella Cheese", CategoryId = 1 },
                    new Item { ItemId = 8, Name = "Veggie D'Light", Description = "Homemade Red Sauce Base Topped w/ Green Pepper, Yellow Onion, Black Olives, Fresh Mushrooms, and Provel Cheese", CategoryId = 1 }


                );
            modelBuilder.Entity<ItemSize>().HasData(
                    new ItemSize { ItemId = 1, SizeId = 1, Price = 16.99m },
                    new ItemSize { ItemId = 1, SizeId = 2, Price = 20.99m },
                    new ItemSize { ItemId = 1, SizeId = 3, Price = 23.99m },
                    new ItemSize { ItemId = 2, SizeId = 1, Price = 14.99m },
                    new ItemSize { ItemId = 2, SizeId = 2, Price = 18.99m },
                    new ItemSize { ItemId = 2, SizeId = 3, Price = 21.99m },
                    new ItemSize { ItemId = 3, SizeId = 1, Price = 14.99m },
                    new ItemSize { ItemId = 3, SizeId = 2, Price = 18.99m },
                    new ItemSize { ItemId = 3, SizeId = 3, Price = 21.99m },
                    new ItemSize { ItemId = 4, SizeId = 1, Price = 16.99m },
                    new ItemSize { ItemId = 4, SizeId = 2, Price = 20.99m },
                    new ItemSize { ItemId = 4, SizeId = 3, Price = 23.99m },
                    new ItemSize { ItemId = 5, SizeId = 1, Price = 15.99m },
                    new ItemSize { ItemId = 5, SizeId = 2, Price = 19.99m },
                    new ItemSize { ItemId = 5, SizeId = 3, Price = 22.99m },
                    new ItemSize { ItemId = 6, SizeId = 1, Price = 15.99m },
                    new ItemSize { ItemId = 6, SizeId = 2, Price = 19.99m },
                    new ItemSize { ItemId = 6, SizeId = 3, Price = 22.99m },
                    new ItemSize { ItemId = 7, SizeId = 1, Price = 12.99m },
                    new ItemSize { ItemId = 7, SizeId = 2, Price = 16.99m },
                    new ItemSize { ItemId = 7, SizeId = 3, Price = 19.99m },
                    new ItemSize { ItemId = 8, SizeId = 1, Price = 12.99m },
                    new ItemSize { ItemId = 8, SizeId = 2, Price = 16.99m },
                    new ItemSize { ItemId = 8, SizeId = 3, Price = 19.99m }
                );
            modelBuilder.Entity<Size>().HasData(
                    new Size { SizeId = 1, Name = "12in."},
                    new Size { SizeId = 2, Name = "14in." },
                    new Size { SizeId = 3, Name = "16in." }
                );
        }
    }
}
