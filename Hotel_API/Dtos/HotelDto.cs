using Hotel_API.Models;

namespace Hotel_API.Dtos
{
    public class HotelDto
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public List<List<string>> Services { get; set; }
        public string Description { get; set; }

        public string HomeImage { get; set; }
        public List<string> OtherImages { get; set; }
        public double Price { get; set; }

        public IEnumerable<RoomDto> Rooms { get; set; }
    }
}
