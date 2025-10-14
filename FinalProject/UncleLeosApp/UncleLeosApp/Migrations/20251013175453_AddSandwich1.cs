using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UncleLeosApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSandwich1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Sandwich" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);
        }
    }
}
