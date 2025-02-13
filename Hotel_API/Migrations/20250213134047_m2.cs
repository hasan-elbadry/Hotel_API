using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_API.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avalibality",
                table: "Rooms");

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Price", "RoomNumber", "Type", "UserId" },
                values: new object[,]
                {
                    { 3, 200.0, "103", "Suite", null },
                    { 5, 120.0, "105", "Single", null }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone", "SpokenLanguage" },
                values: new object[,]
                {
                    { 1, "123 Street, NY", "john@example.com", "John Doe", "hashedpassword1", "1234567890", "English" },
                    { 2, "456 Street, LA", "jane@example.com", "Jane Smith", "hashedpassword2", "0987654321", "French" },
                    { 3, "789 Street, TX", "alice@example.com", "Alice Brown", "hashedpassword3", "1112223333", "Spanish" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Price", "RoomNumber", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, 100.0, "101", "Single", 1 },
                    { 2, 150.0, "102", "Double", 2 },
                    { 4, 250.0, "104", "Deluxe", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<bool>(
                name: "Avalibality",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
