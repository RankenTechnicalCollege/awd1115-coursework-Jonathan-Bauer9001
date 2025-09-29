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
                    new Item { ItemId = 1, Name = "Cheese Pizza", Description = "Classic cheese pizza with tomato sauce and mozzarella cheese", CategoryId = 1 },
                    new Item { ItemId = 2, Name = "Pepperoni Pizza", Description = "Pepperoni pizza with tomato sauce and mozzarella cheese", CategoryId = 1 },
                    new Item { ItemId = 3, Name = "Veggie Pizza", Description = "Vegetarian pizza with tomato sauce, mozzarella cheese, bell peppers, onions, and mushrooms", CategoryId = 1 },
                    new Item { ItemId = 4, Name = "Caesar Salad", Description = "Crisp romaine lettuce, croutons, and Caesar dressing", CategoryId = 2 },
                    new Item { ItemId = 5, Name = "Greek Salad", Description = "Mixed greens, feta cheese, olives, cucumbers, and tomatoes with Greek dressing", CategoryId = 2 },
                    new Item { ItemId = 6, Name = "Chicken Wings", Description = "Spicy buffalo wings served with blue cheese dressing", CategoryId = 3 }

                );
            modelBuilder.Entity<ItemSize>().HasData(
                    new ItemSize { ItemId = 5, SizeId = 1, Price = 6.99m },
                    new ItemSize { ItemId = 6, SizeId = 1, Price = 7.99m },
                    new ItemSize { ItemId = 6, SizeId = 2, Price = 12.99m }
                );
            modelBuilder.Entity<Size>().HasData(
                    new Size { SizeId = 1, Name = "Small" },
                    new Size { SizeId = 2, Name = "Medium" },
                    new Size { SizeId = 3, Name = "Large" }
                );
        }
    }
}
