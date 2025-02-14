using Hotel_API.Dtos;
using Hotel_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Hotel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HotelController(AppDbContext context)
        {
            _context = context;
        }

        // API to book a room
        [HttpPost("book")]
        public async Task<IActionResult> BookRoom([FromBody] BookRoomDto book)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.RoomNumber == book.roomNumber);

            if (room == null)
                return NotFound(new { message = "Room not found" });

            if (room.UserId != null)
                return BadRequest(new { message = "Sorry, the room is already booked" });

            var user = new User
            {
                Name = book.Name,
                Address = book.Address,
                Email = book.Email,
                Phone = book.Phone,
                Password = book.Password,
                SpokenLanguage = book.SpokenLanguage,
            };

            room.User = user;
            await _context.SaveChangesAsync();


            return Ok(new { message = "Room booked successfully" });
        }

        // API to get all rooms
        [HttpGet]
        public IActionResult GetHotelsWithRoom()
        {
            var hotels = _context.Hotels.Include(x=>x.Rooms).ToList().Select(x => new HotelDto
            {
                Name = x.Name,
                Description = x.Description,
                HomeImage = x.HomeImage,
                Location = x.Location,
                Price = x.Price,
                Rating = x.Rating,
                Services = (x.Services ?? "")
                    .Split(";")
                    .Select(s => s.Split(",").ToList())
                    .ToList(),
                OtherImages = (x.OtherImages ?? "").Split(",").ToList(),
                Rooms = x.Rooms.Select(x => new RoomDto
                {
                    BedType = x.BedType,
                    Days = x.Days,
                    OldPrice = x.OldPrice,
                    OfferPresentage = x.OfferPresentage,
                    Price = x.Price,
                    RoomDescription = x.RoomDescription,
                    RoomNumber = x.RoomNumber,
                    RoomSize = x.RoomSize,
                    RoomType = x.RoomType,
                    View = x.View,
                    Images = (x.Images ?? "").Split(",").ToList(),
                    Facilities = (x.Facilities ?? "").Split(";").ToList(),
                    Services = (x.Services ?? "")
                    .Split(";")
                    .Select(s => s.Split(",").ToList())
                    .ToList()
                }).ToList()
            });
            
            return Ok(hotels);
        }
    }
}
