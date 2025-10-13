using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UncleLeosPizza.Migrations
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemSizes",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSizes", x => new { x.ItemId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_ItemSizes_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemSizes_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId1 = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
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
                table: "Sizes",
                columns: new[] { "SizeId", "Name" },
                values: new object[,]
                {
                    { 1, "12in." },
                    { 2, "14in." },
                    { 3, "16in." }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Homemade Red Sauce Base w/ Sausage, Pepperoni, Onion, Fresh Mushrooms, Black Olives, Green Pepper, topped with Provel Cheese", "Uncle Leo's Deluxe" },
                    { 2, 1, "Homemade Red Sauce Base Topped w/ Italian Sausage, Pepperoni, Crispy Bacon, and Provel Cheese", "Meat Trio" },
                    { 3, 1, "Homemade Red Sauce Base Topped w/ Beef, Onion, Tomato, Jalapenos Peppers, and Provel Cheese", "Joey's Fave" },
                    { 4, 1, "Homemade White Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Fresh Mushrooms, Crispy Bacon, Baby Spinach, and Provel Cheese", "Chicken D'Light" },
                    { 5, 1, "Homemade White Sauce Base Topped w/ Italian Sausage, Yellow Onion, Crispy Bacon, Baby Spinach, and Provel Cheese", "Sausage Special" },
                    { 6, 1, "FUNGO SAUCE! Special Made Buffalo Sauce Base Topped w/ Grilled Chicken, Yellow Onion, Crispy Bacon, and Provel Cheese", "Fungo Chicken" },
                    { 7, 1, "Olive Oil Base Topped w/ Tomatoes, Basil, Garlic, and Mozzerella Cheese", "Mariann's Margherita" },
                    { 8, 1, "Homemade Red Sauce Base Topped w/ Green Pepper, Yellow Onion, Black Olives, Fresh Mushrooms, and Provel Cheese", "Veggie D'Light" }
                });

            migrationBuilder.InsertData(
                table: "ItemSizes",
                columns: new[] { "ItemId", "SizeId", "Price" },
                values: new object[,]
                {
                    { 1, 1, 16.99m },
                    { 1, 2, 20.99m },
                    { 1, 3, 23.99m },
                    { 2, 1, 14.99m },
                    { 2, 2, 18.99m },
                    { 2, 3, 21.99m },
                    { 3, 1, 14.99m },
                    { 3, 2, 18.99m },
                    { 3, 3, 21.99m },
                    { 4, 1, 16.99m },
                    { 4, 2, 20.99m },
                    { 4, 3, 23.99m },
                    { 5, 1, 15.99m },
                    { 5, 2, 19.99m },
                    { 5, 3, 22.99m },
                    { 6, 1, 15.99m },
                    { 6, 2, 19.99m },
                    { 6, 3, 22.99m },
                    { 7, 1, 12.99m },
                    { 7, 2, 16.99m },
                    { 7, 3, 19.99m },
                    { 8, 1, 12.99m },
                    { 8, 2, 16.99m },
                    { 8, 3, 19.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSizes_SizeId",
                table: "ItemSizes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId1",
                table: "OrderItems",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemSizes");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
