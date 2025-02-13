using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Hotel_API;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var rooms = _context.Rooms.ToList();
        return View(rooms);
    }

    [HttpPost]
    public JsonResult ToggleStatus(int id)
    {
        var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
        if (room == null)
            return Json(new { success = false, message = "Room not found" });

        room.UserId = room.UserId == null ? 1 : null;
        _context.SaveChanges();

        return Json(new { success = true });
    }
}
