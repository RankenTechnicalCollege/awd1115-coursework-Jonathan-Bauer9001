using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HOT3.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalBrands : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductBrand", "ProductColor", "ProductImageUrl", "ProductName", "ProductPrice", "ProductStock" },
                values: new object[,]
                {
                    { 6, "Ultra Pro", "Black", "UP-EG-JetBlack.jpg", "Eclipse Gloss", 9.99m, 50 },
                    { 7, "Ultra Pro", "Sky Blue", "UP-EG-SkyBlue.jpg", "Eclipse Gloss", 9.99m, 50 },
                    { 8, "Ultra Pro", "Apple Red", "UP-EM-AppleRed.jpg", "Eclipse Matte", 9.99m, 50 },
                    { 9, "Ultra Pro", "Forest Green", "UP-EM-ForestGreen.jpg", "Eclipse Matte", 9.99m, 50 },
                    { 10, "Ultimate Guard", "Orange", "UG-MC-Orange.jpg", "Matte Cortex", 9.99m, 50 },
                    { 11, "Ultimate Guard", "Purple", "UG-MC-Purple.jpg", "Matte Cortex", 9.99m, 50 },
                    { 12, "Ultimate Guard", "Petrol", "UG-MC-Petrol.jpg", "Matte Cortex", 9.99m, 50 },
                    { 13, "Ultimate Guard", "Pink", "UG-MC-Pink.jpg", "Matte Cortex", 9.99m, 50 },
                    { 14, "Ultimate Guard", "Yellow", "UG-MC-Yellow.jpg", "Matte Cortex", 9.99m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

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
        }
    }
}
