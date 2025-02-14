namespace Hotel_API.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string Location { get; set; }
        public string Services { get; set; }
        public string Description { get; set; }

        public string HomeImage { get; set; }
        public string OtherImages { get; set; }
        public double Price { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}
