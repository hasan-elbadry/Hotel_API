using Hotel_API.Dtos;
using Hotel_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
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
            var room = _context.Rooms.FirstOrDefault(x => x.Id == book.roomId);

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
        public IActionResult GetRooms()
        {
            var rooms = _context.Rooms.ToList();
            return Ok(rooms);
        }
    }
}
