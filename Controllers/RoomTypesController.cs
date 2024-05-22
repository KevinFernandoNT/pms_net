// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.RoomType;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("roomTypes")]
    [ApiController]
    public class RoomTypesController : ControllerBase
    {
    [HttpGet]
    public ActionResult<string> GetRoomTypes()
{
   return Content("Get room types");
}
        [HttpGet("{id}")]
        public ActionResult<string> GetRoomType(int id)
        {
           return Content("returns room type information");
        }

        [HttpPost("create")]
        public ActionResult<string> CreateRoomType([FromBody] RoomType payload)
        {
        return Content("create new room type");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateRoomType(int id, [FromBody] RoomType payload)
        {
            return Content("Update room type information");
        }

        // DELETE: bookings/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteRoomype(int id)
        {
          return Content("Remove room type from system");
        }
    }
}
