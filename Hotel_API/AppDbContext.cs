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

            modelBuilder.Entity<Room>().HasData(
                new Room { Id = 1, RoomNumber = "101", Price = 100.0, Type = "Single",  UserId = 1 },
                new Room { Id = 2, RoomNumber = "102", Price = 150.0, Type = "Double", UserId = 2 },
                new Room { Id = 3, RoomNumber = "103", Price = 200.0, Type = "Suite",UserId = null },
                new Room { Id = 4, RoomNumber = "104", Price = 250.0, Type = "Deluxe", UserId = 3 },
                new Room { Id = 5, RoomNumber = "105", Price = 120.0, Type = "Single", UserId = null }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> users { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
