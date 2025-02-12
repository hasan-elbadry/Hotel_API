using Hotel_API.Dtos;
using Hotel_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult BookRoom([FromBody] BookRoomDto book)
        {
            var room = _context.Rooms.FirstOrDefault(x => x.Id == book.roomId);

            if (room == null)
                return NotFound(new { message = "Room not found" });

            if (room.UserId != null) // Corrected check
                return BadRequest(new { message = "Sorry, the room is already booked" });

            room.UserId = book.UserId;
            _context.SaveChanges();

            return Ok(new { message = "Room booked successfully" });
        }

    }
}
