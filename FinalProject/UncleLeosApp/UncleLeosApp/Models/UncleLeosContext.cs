using Microsoft.EntityFrameworkCore;
namespace UncleLeosApp.Models
{
    public class UncleLeosContext : DbContext
    {
        public UncleLeosContext(DbContextOptions<UncleLeosContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
               new Category { CategoryId = 1, CategoryName = "Pizza" },
               new Category { CategoryId = 2, CategoryName = "Salad" },
               new Category { CategoryId = 3, CategoryName = "Appetizer" },
               new Category { CategoryId = 4, CategoryName = "Dessert" },
               new Category { CategoryId = 5, CategoryName = "Beverage" },
               new Category { CategoryId = 6, CategoryName = "Merchandise" },
               new Category { CategoryId = 7, CategoryName = "Sandwich" },
               new Category { CategoryId = 8, CategoryName = "Pasta" }
               );

            modelBuilder.Entity<Product>().HasData(
                   new Product { ProductId = 1, ProductName = "Uncle Leo's Deluxe", ProductDescription = "Homemade Red Sauce Base w/ Sausage, Pepperoni, Onion, Fresh Mushrooms, Black Olives, Green Pepper, topped with Provel Cheese", CategoryId = 1, ProductPrice = 19.99m, ProductImage = "Uncle-Leos-deluxe-pizza.png" },
                   new Product { ProductId = 2, ProductName = "Meat Trio", ProductDescription = "Homemade Red Sauce Base Topped w/ Italian Sausage, Pepperoni, Crispy Bacon, and Provel Cheese", CategoryId = 1, ProductPrice = 18.99m, ProductImage = "Meat-trio.jpg" },
                   new Product { ProductId = 3, ProductName = "Joey's Fave", ProductDescription = "Homemade Red Sauce Base Topped w/ Beef, Onion, Tomato, Jalapenos Peppers, and Provel Cheese", CategoryId = 1, ProductPrice = 18.99m, ProductImage = "Joeys-Fav.jpeg" },
                   new Product { ProductId = 4, ProductName = "Chicken D'Light", ProductDescription = "Homemade White Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Fresh Mushrooms, Crispy Bacon, Baby Spinach, and Provel Cheese", CategoryId = 1, ProductPrice = 20.99m, ProductImage = "Chicken-Delight.jpg" },
                   new Product { ProductId = 5, ProductName = "Sausage Special", ProductDescription = "Homemade White Sauce Base Topped w/ Italian Sausage, Yellow Onion, Crispy Bacon, Baby Spinach, and Provel Cheese", CategoryId = 1, ProductPrice = 19.99m, ProductImage = "Sausage-special.jpg" },
                   new Product { ProductId = 6, ProductName = "Fungo Chicken", ProductDescription = "FUNGO SAUCE! Special Made Buffalo Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Crispy Bacon, and Provel Cheese", CategoryId = 1, ProductPrice = 19.99m, ProductImage = "Fungo-Chicken.png" },
                   new Product { ProductId = 7, ProductName = "Mariann's Margherita", ProductDescription = "Olive Oil Base Topped w/ Tomatoes, Basil, Garlic, and Mozzerella Cheese", CategoryId = 1, ProductPrice = 16.99m, ProductImage = "Margherita.jpg" },
                   new Product { ProductId = 8, ProductName = "Veggie D'Light", ProductDescription = "Homemade Red Sauce Base Topped w/ Green Pepper, Yellow Onion, Black Olives, Fresh Mushrooms, and Provel Cheese", CategoryId = 1, ProductPrice = 16.99m, ProductImage = "Veggie-Pizza.png" },
                   new Product { ProductId = 9, ProductName = "7\" Italian Sub", ProductDescription = "7\" Sandwich w/ Garlic Butter on the Top Bun, Your Choice of Cheese, Ham, Salami, Pepperoni, Lettuce, Tomato, and Vinaigrette. Served Cold or Hot. Served w/ Side of Choice.", CategoryId = 7, ProductPrice = 9.99m, ProductImage = "Italian-Sub.jpg" },
                   new Product { ProductId = 10, ProductName = "7\" Meatball Sub", ProductDescription = "7\" Sandwich w/ Garlic Butter on the Top Bun, Your Choice of Cheese, and Three(3) Saucy Meatballs. Served w/ Side of Choice.", CategoryId = 7, ProductPrice = 10.99m, ProductImage = "Meatball-Sub.jpg" },
                   new Product { ProductId = 11, ProductName = "Pasta Con Broccoli", ProductDescription= "Penne Pasta w/ Homemade White Sauce and Broccoli", CategoryId = 8, ProductPrice = 11.99m, ProductImage = "Con-Bro.jpg" },
                   new Product { ProductId = 12, ProductName = "Pasta Carbonara", ProductDescription = "Penne Pasta w/ Homemade White Sauce, Fresh Mushrooms, and Crispy Bacon", CategoryId = 8, ProductPrice = 12.99m, ProductImage = "Carbonara.jpg" },
                   new Product { ProductId = 13, ProductName = "House Salad", ProductDescription = "Iceburg & Romaine Mix w/ Provel, Cherry Tomatoes, Croutons, and Spinkled on Parmesan", CategoryId =2 , ProductPrice = 7.99m, ProductImage = "House-salad.jpg" },
                   new Product { ProductId = 14, ProductName = "Deluxe Chef Salad", ProductDescription = "Iceburg & Romaine Mix w/ Ham, Salami, Provel, Cherry Tomatoes, Croutons, and spinkled on Parmesan", CategoryId = 2, ProductPrice = 10.99m, ProductImage = "Chef-Salad.jpg" },
                   new Product { ProductId = 15, ProductName = "Spinocci", ProductDescription = "Seven(7) Wonton Wrappers Filled w/ Spinache Artichoke Dip. Served w/ Pepper Jelly. Call for orders of 50 or 100.", CategoryId = 3, ProductPrice = 10.99m, ProductImage = "Spinocci.jpg" },
                   new Product { ProductId = 16, ProductName = "Failoni Wings", ProductDescription = "Nine(9) Wings Deep Fried 'til Crispy and Tossed In Our Special Buffalo Sauce...FUNGO SAUCE! Wings are not breaded. Call for orders of 50 or 100 wings.", CategoryId = 3, ProductPrice = 13.99m, ProductImage = "Wings.jpg" },
                   new Product { ProductId = 17, ProductName = "Toasted Ravioli", ProductDescription = "10 Breaded Ravioli Deep Fried until Crispy and Golden! Served with Our Homemade Meat Sauce. Call for orders of 50 or 100.", CategoryId = 3, ProductPrice = 8.99m, ProductImage = "T-Rav.jpg" },
                   new Product { ProductId = 18, ProductName = "Can Pepsi", ProductDescription = "The familiar, crisp taste of a classic Pepsi, served chilled in a can.", CategoryId = 5, ProductPrice = 2m, ProductImage = "Pepsi-Can.jpg" },
                   new Product { ProductId = 19, ProductName = "Apple Fritter", ProductDescription = "Our Homemade Crust Folded and Filled w/ Apple Filling then Fried until Golden and Sprinkled in Cinnamon Sugar. Served with Icing.", CategoryId = 4, ProductPrice = 7.99m, ProductImage = "Apple-Fritter.jpg" },
                   new Product { ProductId = 20, ProductName = "Can Diet Pepsi", ProductDescription = "The same light, crisp, and refreshing taste of Pepsi, with zero sugar and zero calories.", CategoryId = 5, ProductPrice = 0.00m, ProductImage = "diet-pepsi-can" }




               );
        }

    }
}
