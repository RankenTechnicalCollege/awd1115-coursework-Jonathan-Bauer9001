using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UncleLeosApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Pizza" },
                    { 2, "Salad" },
                    { 3, "Appetizer" },
                    { 4, "Dessert" },
                    { 5, "Beverage" },
                    { 6, "Merchandise" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 1, "Homemade Red Sauce Base w/ Sausage, Pepperoni, Onion, Fresh Mushrooms, Black Olives, Green Pepper, topped with Provel Cheese", "Uncle-Leos-deluxe-pizza.png", "Uncle Leo's Deluxe", 19.99m },
                    { 2, 1, "Homemade Red Sauce Base Topped w/ Italian Sausage, Pepperoni, Crispy Bacon, and Provel Cheese", "Meat-trio.jpg", "Meat Trio", 18.99m },
                    { 3, 1, "Homemade Red Sauce Base Topped w/ Beef, Onion, Tomato, Jalapenos Peppers, and Provel Cheese", "Joeys-Fav.jpeg", "Joey's Fave", 18.99m },
                    { 4, 1, "Homemade White Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Fresh Mushrooms, Crispy Bacon, Baby Spinach, and Provel Cheese", "Chicken-Delight.jpg", "Chicken D'Light", 20.99m },
                    { 5, 1, "Homemade White Sauce Base Topped w/ Italian Sausage, Yellow Onion, Crispy Bacon, Baby Spinach, and Provel Cheese", "Sausage-special.jpg", "Sausage Special", 19.99m },
                    { 6, 1, "FUNGO SAUCE! Special Made Buffalo Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Crispy Bacon, and Provel Cheese", "Fungo-Chicken.png", "Fungo Chicken", 19.99m },
                    { 7, 1, "Olive Oil Base Topped w/ Tomatoes, Basil, Garlic, and Mozzerella Cheese", "Margherita.jpg", "Mariann's Margherita", 16.99m },
                    { 8, 1, "Homemade Red Sauce Base Topped w/ Green Pepper, Yellow Onion, Black Olives, Fresh Mushrooms, and Provel Cheese", "Veggie-Pizza.png", "Veggie D'Light", 16.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
