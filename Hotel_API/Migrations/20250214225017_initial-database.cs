using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel_API.Migrations
{
    /// <inheritdoc />
    public partial class initialdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpokenLanguage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfferPresentage = table.Column<int>(type: "int", nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    OldPrice = table.Column<double>(type: "float", nullable: false),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomSize = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    View = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facilities = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Description", "HomeImage", "Location", "Name", "OtherImages", "Price", "Rating", "Services" },
                values: new object[,]
                {
                    { 1, "A luxurious resort located in the heart of the Maldives, offering breathtaking views and world-class amenities.", "https://images.unsplash.com/photo-1618773928121-c32242e63f39", "Maldives", "Luxury Paradise Resort", "https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945,https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", 450.0, 5, "Spa,fas fa-spa;Pool,fas fa-swimming-pool;Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils" },
                    { 2, "A serene beachfront hotel with stunning sunset views and a relaxing atmosphere.", "https://images.unsplash.com/photo-1549989476-69a92fa57c36", "Bali, Indonesia", "Sunset Beach Hotel", "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", 350.0, 4, "Beach Access,fas fa-umbrella-beach;Pool,fas fa-swimming-pool;Bar,fas fa-cocktail;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils" },
                    { 3, "A cozy lodge nestled in the Swiss Alps, perfect for winter sports and relaxation.", "https://images.unsplash.com/photo-1519681393784-d120267933ba", "Swiss Alps", "Mountain View Lodge", "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", 300.0, 4, "Skiing,fas fa-skiing;Spa,fas fa-spa;Restaurant,fas fa-utensils;Free Wi-Fi,fas fa-wifi" },
                    { 4, "A modern hotel located in the heart of New York City, ideal for business and leisure travelers.", "https://images.unsplash.com/photo-1499856871958-5b9627545d1a", "New York, USA", "City Central Hotel", "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", 250.0, 3, "Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Conference Rooms,fas fa-users" },
                    { 5, "A luxurious resort in the middle of the desert, offering a unique blend of tradition and modernity.", "https://images.unsplash.com/photo-1518684079-3c830dcef090", "Dubai, UAE", "Desert Oasis Resort", "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", 500.0, 5, "Pool,fas fa-swimming-pool;Spa,fas fa-spa;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Camel Riding,fas fa-horse" }
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
                columns: new[] { "Id", "BedType", "Days", "Facilities", "HotelId", "Images", "OfferPresentage", "OldPrice", "Price", "RoomDescription", "RoomNumber", "RoomSize", "RoomType", "Services", "UserId", "View" },
                values: new object[,]
                {
                    { 1, "1 king bed", 5, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 1, "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", 10, 12000.0, 10000.0, "A spacious and comfortable room with modern amenities.", "Room 1", "50 m²", "One Bedroom Apartment", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "Sea view" },
                    { 2, "2 twin beds", 7, "Walk-in closet;Tea/Coffee maker;Kitchenette;Soundproof;Dining area;Washing machine", 2, "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", 15, 18000.0, 15000.0, "A luxurious apartment with a stunning view and excellent facilities.", "Room 2", "80 m²", "Two-Bedroom Apartment", "Free Wifi,fas fa-wifi;Kitchenette,fas fa-utensils;Jacuzzi,fas fa-hot-tub;Safe,fas fa-lock;Work desk,fas fa-laptop", null, "Garden view" },
                    { 3, "1 king bed", 10, "Fireplace;Patio;Flat-screen TV;Safe;Dining area;Dryer", 3, "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", 20, 30000.0, 25000.0, "A spacious villa with private amenities and breathtaking views.", "Room 3", "120 m²", "Stand Alone Villa", "Balcony,fas fa-umbrella-beach;Soundproof,fas fa-volume-mute;Fireplace,fas fa-fire;Ironing facilities,fas fa-iron;Sitting area,fas fa-couch", null, "Mountain view" },
                    { 4, "1 queen bed", 8, "Flat-screen TV;Tea/Coffee maker;Ironing facilities;Soundproof;Patio;Dryer", 4, "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", 25, 25000.0, 20000.0, "A deluxe suite with all modern amenities for a comfortable stay.", "Room 4", "70 m²", "Deluxe Suite", "Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Safe,fas fa-lock;Jacuzzi,fas fa-hot-tub;Work desk,fas fa-laptop", null, "City view" },
                    { 5, "2 queen beds", 6, "Walk-in closet;Flat-screen TV;Safe;Fireplace;Air conditioning;Washing machine", 5, "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", 5, 16000.0, 13000.0, "An executive room perfect for business travelers and leisure.", "Room 5", "60 m²", "Executive Room", "Free Wifi,fas fa-wifi;Balcony,fas fa-umbrella-beach;Kitchenette,fas fa-utensils;Dining area,fas fa-utensils;Sitting area,fas fa-couch", null, "Pool view" },
                    { 6, "1 king bed", 9, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 2, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 12, 18000.0, 16000.0, "A comfortable room with essential amenities.", "Room 6", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 7, "1 king bed", 10, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 3, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 14, 19000.0, 17000.0, "A comfortable room with essential amenities.", "Room 7", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 8, "1 king bed", 11, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 4, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 16, 20000.0, 18000.0, "A comfortable room with essential amenities.", "Room 8", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 9, "1 king bed", 12, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 5, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 18, 21000.0, 19000.0, "A comfortable room with essential amenities.", "Room 9", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 10, "1 king bed", 13, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 1, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 20, 22000.0, 20000.0, "A comfortable room with essential amenities.", "Room 10", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 11, "1 king bed", 14, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 2, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 22, 23000.0, 21000.0, "A comfortable room with essential amenities.", "Room 11", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 12, "1 king bed", 15, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 3, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 24, 24000.0, 22000.0, "A comfortable room with essential amenities.", "Room 12", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 13, "1 king bed", 16, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 4, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 26, 25000.0, 23000.0, "A comfortable room with essential amenities.", "Room 13", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 14, "1 king bed", 17, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 5, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 28, 26000.0, 24000.0, "A comfortable room with essential amenities.", "Room 14", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" },
                    { 15, "1 king bed", 18, "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", 1, "https://images.unsplash.com/photo-1578683010236-d716f9a3f461", 30, 27000.0, 25000.0, "A comfortable room with essential amenities.", "Room 15", "50 m²", "Standard Room", "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", null, "City view" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_UserId",
                table: "Rooms",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
