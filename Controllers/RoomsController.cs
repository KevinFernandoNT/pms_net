// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Room;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("rooms")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
[HttpGet("status")]
public ActionResult<string> GetRooms([FromQuery] string? status = null)
{
    if (string.IsNullOrEmpty(status))
    {
        return Content("Get all rooms");
    }

    return Content($"Get rooms with status: {status}");
}

        [HttpGet("{id}")]
        public ActionResult<string> GetRoom(int roomNumber)
        {
           return Content("returns room information according to a given id");
        }

        [HttpPost("create")]
        public ActionResult<string> CreateNewRoom([FromBody] Room payload)
        {
        return Content("create new reservation");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateRoomDetails(int id, [FromBody] Room payload)
        {
            return Content("Update room information");
        }

        // DELETE: bookings/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> RemoveRoom(int id)
        {
          return Content("Remove a room");
        }
    }
}
