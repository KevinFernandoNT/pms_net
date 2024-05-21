// Controllers/NotificationsController.cs
using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Notification;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("notifications")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private static List<Notification> Notifications = new List<Notification>
        {
            new Notification { Id = 1, Title = "System Update", Message = "System update scheduled for tonight.", Date = DateTime.Now, IsRead = false },
            new Notification { Id = 2, Title = "Maintenance Alert", Message = "Scheduled maintenance tomorrow.", Date = DateTime.Now, IsRead = false }
        };

        // GET: notifications
        [HttpGet]
        public ActionResult<IEnumerable<Notification>> GetNotifications()
        {
            return Ok(Notifications);
        }

        // GET: notifications/{id}
        [HttpGet("{id}")]
        public ActionResult<Notification> GetNotification(int id)
        {
            var notification = Notifications.FirstOrDefault(n => n.Id == id);
            if (notification == null)
            {
                return NotFound();
            }
            return Ok(notification);
        }

        // POST: notifications
        [HttpPost]
        public ActionResult<Notification> CreateNotification([FromBody] Notification notification)
        {
            notification.Id = Notifications.Count > 0 ? Notifications.Max(n => n.Id) + 1 : 1;
            Notifications.Add(notification);
            return CreatedAtAction(nameof(GetNotification), new { id = notification.Id }, notification);
        }

        // PUT: notifications/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateNotification(int id, [FromBody] Notification updatedNotification)
        {
            var notification = Notifications.FirstOrDefault(n => n.Id == id);
            if (notification == null)
            {
                return NotFound();
            }

            notification.Title = updatedNotification.Title;
            notification.Message = updatedNotification.Message;
            notification.Date = updatedNotification.Date;
            notification.IsRead = updatedNotification.IsRead;

            return NoContent();
        }

        // DELETE: notifications/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteNotification(int id)
        {
            var notification = Notifications.FirstOrDefault(n => n.Id == id);
            if (notification == null)
            {
                return NotFound();
            }

            Notifications.Remove(notification);
            return NoContent();
        }
    }
}
