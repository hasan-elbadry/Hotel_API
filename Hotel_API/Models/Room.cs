using System.ComponentModel.DataAnnotations;

namespace Hotel_API.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string RoomNumber { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; }

        public string Type { get; set; }

        public int? UserId { get; set; } 
        public User? User { get; set; }
    }
}
