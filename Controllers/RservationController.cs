// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Reservation;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
  [HttpGet("{arrivalDate?}/{departureDate?}")]
public ActionResult<string> GetReservations(DateTime? arrivalDate = null, DateTime? departureDate = null)
{
    return Content("Get available reservations");
}

        [HttpGet("{id}")]
        public ActionResult<string> GetReservation(int id)
        {
           return Content("returns reservation information according to a given id");
        }

        [HttpPost("create")]
        public ActionResult<string> AddNewReservation([FromBody] Reservation payload)
        {
        return Content("create new reservation");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateReservation(int id, [FromBody] Reservation payload)
        {
            return Content("Update reservation information");
        }

        [HttpDelete("{id}")]
        public ActionResult<string> CancelReservation(int id)
        {
          return Content("Cancel out a reservation");
        }
    }
}
