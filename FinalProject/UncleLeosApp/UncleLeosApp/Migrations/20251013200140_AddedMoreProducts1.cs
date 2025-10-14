using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UncleLeosApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreProducts1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Pasta" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 9, 7, "7\" Sandwich w/ Garlic Butter on the Top Bun, Your Choice of Cheese, Ham, Salami, Pepperoni, Lettuce, Tomato, and Vinaigrette. Served Cold or Hot. Served w/ Side of Choice.", "Italian-Sub.jpg", "7\" Italian Sub", 9.99m },
                    { 10, 7, "7\" Sandwich w/ Garlic Butter on the Top Bun, Your Choice of Cheese, and Three(3) Saucy Meatballs. Served w/ Side of Choice.", "Meatball-Sub.jpg", "7\" Meatball Sub", 10.99m },
                    { 13, 2, "Iceburg & Romaine Mix w/ Provel, Cherry Tomatoes, Croutons, and Spinkled on Parmesan", "House-salad.jpg", "House Salad", 7.99m },
                    { 14, 2, "Iceburg & Romaine Mix w/ Ham, Salami, Provel, Cherry Tomatoes, Croutons, and spinkled on Parmesan", "Chef-Salad.jpg", "Deluxe Chef Salad", 10.99m },
                    { 15, 3, "Seven(7) Wonton Wrappers Filled w/ Spinache Artichoke Dip. Served w/ Pepper Jelly. Call for orders of 50 or 100.", "Spinocci.jpg", "Spinocci", 10.99m },
                    { 16, 3, "Nine(9) Wings Deep Fried 'til Crispy and Tossed In Our Special Buffalo Sauce...FUNGO SAUCE! Wings are not breaded. Call for orders of 50 or 100 wings.", "Wings.jpg", "Failoni Wings", 13.99m },
                    { 17, 3, "10 Breaded Ravioli Deep Fried until Crispy and Golden! Served with Our Homemade Meat Sauce. Call for orders of 50 or 100.", "T-Rav.jpg", "Toasted Ravioli", 8.99m },
                    { 18, 5, "The familiar, crisp taste of a classic Pepsi, served chilled in a can.", "Pepsi-Can.jpg", "Can Pepsi", 2m },
                    { 19, 4, "Our Homemade Crust Folded and Filled w/ Apple Filling then Fried until Golden and Sprinkled in Cinnamon Sugar. Served with Icing.", "Apple-Fritter.jpg", "Apple Fritter", 7.99m },
                    { 20, 5, "The same light, crisp, and refreshing taste of Pepsi, with zero sugar and zero calories.", "diet-pepsi-can", "Can Diet Pepsi", 0.00m },
                    { 11, 8, "Penne Pasta w/ Homemade White Sauce and Broccoli", "Con-Bro.jpg", "Pasta Con Broccoli", 11.99m },
                    { 12, 8, "Penne Pasta w/ Homemade White Sauce, Fresh Mushrooms, and Crispy Bacon", "Carbonara.jpg", "Pasta Carbonara", 12.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);
        }
    }
}
