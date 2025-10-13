using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HOT3.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductStock = table.Column<int>(type: "int", nullable: false),
                    ProductColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductBrand", "ProductColor", "ProductImageUrl", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[,]
                {
                    { 1, "Dragon Shield", "Gooseberry", "DS-DM-Gooseberry.jpg", "Matte Dual Sleeves", 14.99m, 32 },
                    { 2, "Dragon Shield", "Blossom", "DS-DM-Blossom.jpg", "Matte Dual Sleeves", 14.99m, 48 },
                    { 3, "Dragon Shield", "Pomegranate & Gold", "DS-DM-PomegranateGold.jpg", "Matte Dual Sleeves", 16.99m, 25 },
                    { 4, "Dragon Shield", "Cobalt & Silver", "DS-DM-CobaltSilver.jpg", "Matte Dual Sleeves", 16.99m, 40 },
                    { 5, "Dragon Shield", "Clear", "DS-PF-Clear.jpg", "Matte Dual Sleeves", 7.99m, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
