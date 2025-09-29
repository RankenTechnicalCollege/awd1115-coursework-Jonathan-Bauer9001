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
            modelBuilder.Entity<Category>().HasData(
                    new Category {CategoryId = "Pizza", Name = "Pizza"},
                    new Category {CategoryId = "Salad", Name = "Salad"},
                    new Category {CategoryId = "Appetizer", Name = "Appetizer" },
                    new Category {CategoryId = "Dessert", Name = "Dessert" },
                    new Category {CategoryId = "Beverage", Name = "Beverage" },
                    new Category {CategoryId = "Merchandise", Name = "Merchandise" }
                    );
            modelBuilder.Entity<Item>().HasData(
                    new Item {ItemId = "1", Name = "Cheese Pizza", Description = "Classic cheese pizza with tomato sauce and mozzarella cheese", CategoryId = "Pizza"},
                    new Item {ItemId = "2", Name = "Pepperoni Pizza", Description = "Pepperoni pizza with tomato sauce and mozzarella cheese", CategoryId = "Pizza"},
                    new Item {ItemId = "3", Name = "Veggie Pizza", Description = "Vegetarian pizza with tomato sauce, mozzarella cheese, bell peppers, onions, and mushrooms", CategoryId = "Pizza"},
                    new Item {ItemId = "4", Name = "Caesar Salad", Description = "Crisp romaine lettuce, croutons, and Caesar dressing", CategoryId = "Salad"},
                    new Item {ItemId = "5", Name = "Greek Salad", Description = "Mixed greens, feta cheese, olives, cucumbers, and tomatoes with Greek dressing", CategoryId = "Salad" },
                    new Item {ItemId = "6", Name = "Chicken Wings", Description = "Spicy buffalo wings served with blue cheese dressing", CategoryId = "Appetizer" }
                );
            modelBuilder.Entity<Size>().HasData(
                    new Size {SizeId = "Small", Name = "Small"},
                    new Size {SizeId = "Medium", Name = "Medium"},
                    new Size {SizeId = "Large", Name = "Large" }
                );
        }
    }
}
