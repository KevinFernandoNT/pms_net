// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Room;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("bookings")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private static List<Room> Rooms = new List<Room>
        {
            new Room { Id = 1, Name = "Conference Room", Capacity = 10, IsAvailable = true },
            new Room { Id = 2, Name = "Meeting Room", Capacity = 5, IsAvailable = false }
        };

        // GET: bookings
        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetRooms()
        {
            return Ok(Rooms);
        }

        // GET: bookings/{id}
        [HttpGet("{id}")]
        public ActionResult<Room> GetRoom(int id)
        {
            var room = Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return Ok(room);
        }

        // POST: bookings
        [HttpPost]
        public ActionResult<Room> CreateRoom([FromBody] Room room)
        {
            room.Id = Rooms.Count > 0 ? Rooms.Max(r => r.Id) + 1 : 1;
            Rooms.Add(room);
            return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
        }

        // PUT: bookings/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateRoom(int id, [FromBody] Room updatedRoom)
        {
            var room = Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            room.Name = updatedRoom.Name;
            room.Capacity = updatedRoom.Capacity;
            room.IsAvailable = updatedRoom.IsAvailable;

            return NoContent();
        }

        // DELETE: bookings/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteRoom(int id)
        {
            var room = Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            Rooms.Remove(room);
            return NoContent();
        }
    }
}
