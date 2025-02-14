using Hotel_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasMany(x=>x.Rooms)
                .WithOne(x=>x.User)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "John Doe", Email = "john@example.com", Phone = "1234567890", Password = "hashedpassword1", Address = "123 Street, NY", SpokenLanguage = "English" },
               new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Phone = "0987654321", Password = "hashedpassword2", Address = "456 Street, LA", SpokenLanguage = "French" },
               new User { Id = 3, Name = "Alice Brown", Email = "alice@example.com", Phone = "1112223333", Password = "hashedpassword3", Address = "789 Street, TX", SpokenLanguage = "Spanish" }
           );


            modelBuilder.Entity<Hotel>().HasData(
          new Hotel
          {
              Id = 1,
              Name = "Luxury Paradise Resort",
              Rating = 5,
              Location = "Maldives",
              Services = "Spa,fas fa-spa;Pool,fas fa-swimming-pool;Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils",
              Description = "A luxurious resort located in the heart of the Maldives, offering breathtaking views and world-class amenities.",
              HomeImage = "https://images.unsplash.com/photo-1618773928121-c32242e63f39",
              OtherImages = "https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945,https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945",
              Price = 450.00,
          },
          new Hotel
          {
              Id = 2,
              Name = "Sunset Beach Hotel",
              Rating = 4,
              Location = "Bali, Indonesia",
              Services = "Beach Access,fas fa-umbrella-beach;Pool,fas fa-swimming-pool;Bar,fas fa-cocktail;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils",
              Description = "A serene beachfront hotel with stunning sunset views and a relaxing atmosphere.",
              HomeImage = "https://images.unsplash.com/photo-1549989476-69a92fa57c36",
              OtherImages = "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36",
              Price = 350.00
          },
          new Hotel
          {
              Id = 3,
              Name = "Mountain View Lodge",
              Rating = 4,
              Location = "Swiss Alps",
              Services = "Skiing,fas fa-skiing;Spa,fas fa-spa;Restaurant,fas fa-utensils;Free Wi-Fi,fas fa-wifi",
              Description = "A cozy lodge nestled in the Swiss Alps, perfect for winter sports and relaxation.",
              HomeImage = "https://images.unsplash.com/photo-1519681393784-d120267933ba",
              OtherImages = "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba",
              Price = 300.00
          },
          new Hotel
          {
              Id = 4,
              Name = "City Central Hotel",
              Rating = 3,
              Location = "New York, USA",
              Services = "Gym,fas fa-dumbbell;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Conference Rooms,fas fa-users",
              Description = "A modern hotel located in the heart of New York City, ideal for business and leisure travelers.",
              HomeImage = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a",
              OtherImages = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a",
              Price = 250.00
          },
          new Hotel
          {
              Id = 5,
              Name = "Desert Oasis Resort",
              Rating = 5,
              Location = "Dubai, UAE",
              Services = "Pool,fas fa-swimming-pool;Spa,fas fa-spa;Free Wi-Fi,fas fa-wifi;Restaurant,fas fa-utensils;Camel Riding,fas fa-horse",
              Description = "A luxurious resort in the middle of the desert, offering a unique blend of tradition and modernity.",
              HomeImage = "https://images.unsplash.com/photo-1518684079-3c830dcef090",
              OtherImages = "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090",
              Price = 500.00
          }
      );

            var rooms = new List<Room>
{
    new Room { Id = 1, RoomNumber = "Room 1", Images = "https://images.unsplash.com/photo-1618773928121-c32242e63f39,https://images.unsplash.com/photo-1564501049412-61c2a3083791,https://images.unsplash.com/photo-1566073771259-6a8506099945", OfferPresentage = 10, RoomType = "One Bedroom Apartment", BedType = "1 king bed", Days = 5, Price = 10000, OldPrice = 12000, Services = "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv", RoomSize = "50 m²", RoomDescription = "A spacious and comfortable room with modern amenities.", View = "Sea view", Facilities = "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi", HotelId = 1 },
    new Room { Id = 2, RoomNumber = "Room 2", Images = "https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36,https://images.unsplash.com/photo-1549989476-69a92fa57c36", OfferPresentage = 15, RoomType = "Two-Bedroom Apartment", BedType = "2 twin beds", Days = 7, Price = 15000, OldPrice = 18000, Services = "Free Wifi,fas fa-wifi;Kitchenette,fas fa-utensils;Jacuzzi,fas fa-hot-tub;Safe,fas fa-lock;Work desk,fas fa-laptop", RoomSize = "80 m²", RoomDescription = "A luxurious apartment with a stunning view and excellent facilities.", View = "Garden view", Facilities = "Walk-in closet;Tea/Coffee maker;Kitchenette;Soundproof;Dining area;Washing machine", HotelId = 2 },
    new Room { Id = 3, RoomNumber = "Room 3", Images = "https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba,https://images.unsplash.com/photo-1519681393784-d120267933ba", OfferPresentage = 20, RoomType = "Stand Alone Villa", BedType = "1 king bed", Days = 10, Price = 25000, OldPrice = 30000, Services = "Balcony,fas fa-umbrella-beach;Soundproof,fas fa-volume-mute;Fireplace,fas fa-fire;Ironing facilities,fas fa-iron;Sitting area,fas fa-couch", RoomSize = "120 m²", RoomDescription = "A spacious villa with private amenities and breathtaking views.", View = "Mountain view", Facilities = "Fireplace;Patio;Flat-screen TV;Safe;Dining area;Dryer", HotelId = 3 },
    new Room { Id = 4, RoomNumber = "Room 4", Images = "https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a,https://images.unsplash.com/photo-1499856871958-5b9627545d1a", OfferPresentage = 25, RoomType = "Deluxe Suite", BedType = "1 queen bed", Days = 8, Price = 20000, OldPrice = 25000, Services = "Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Safe,fas fa-lock;Jacuzzi,fas fa-hot-tub;Work desk,fas fa-laptop", RoomSize = "70 m²", RoomDescription = "A deluxe suite with all modern amenities for a comfortable stay.", View = "City view", Facilities = "Flat-screen TV;Tea/Coffee maker;Ironing facilities;Soundproof;Patio;Dryer", HotelId = 4 },
    new Room { Id = 5, RoomNumber = "Room 5", Images = "https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090,https://images.unsplash.com/photo-1518684079-3c830dcef090", OfferPresentage = 5, RoomType = "Executive Room", BedType = "2 queen beds", Days = 6, Price = 13000, OldPrice = 16000, Services = "Free Wifi,fas fa-wifi;Balcony,fas fa-umbrella-beach;Kitchenette,fas fa-utensils;Dining area,fas fa-utensils;Sitting area,fas fa-couch", RoomSize = "60 m²", RoomDescription = "An executive room perfect for business travelers and leisure.", View = "Pool view", Facilities = "Walk-in closet;Flat-screen TV;Safe;Fireplace;Air conditioning;Washing machine", HotelId = 5 }
};

            for (int i = 6; i <= 15; i++)
            {
                rooms.Add(new Room
                {
                    Id = i,
                    RoomNumber = $"Room {i}",
                    Images = "https://images.unsplash.com/photo-1578683010236-d716f9a3f461",
                    OfferPresentage = i * 2,
                    RoomType = "Standard Room",
                    BedType = "1 king bed",
                    Days = i + 3,
                    Price = 10000 + (i * 1000),
                    OldPrice = 12000 + (i * 1000),
                    Services = "Free Wifi,fas fa-wifi;Air Conditioning,fas fa-snowflake;Private Bathroom,fas fa-bath;Minibar,fas fa-wine-glass-alt;Flat-screen TV,fas fa-tv",
                    RoomSize = "50 m²",
                    RoomDescription = "A comfortable room with essential amenities.",
                    View = "City view",
                    Facilities = "Balcony;Air conditioning;Private bathroom;Flat-screen TV;Minibar;Free Wifi",
                    HotelId = (i % 5) + 1
                });
            }

            modelBuilder.Entity<Room>().HasData(rooms);



            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

    }
}
