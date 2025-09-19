using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project4dash1.Migrations
{
    /// <inheritdoc />
    public partial class dateAdded02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2025, 9, 19, 1, 46, 38, 327, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2025, 9, 19, 1, 46, 38, 327, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2025, 9, 19, 1, 46, 38, 327, DateTimeKind.Local).AddTicks(1309));
        }
    }
}
