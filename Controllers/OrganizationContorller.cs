// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("roomTypes")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
    [HttpGet]
    public ActionResult<string> GetOrganizations()
{
       return Content("Get organizations");
}
        [HttpGet("{id}")]
        public ActionResult<string> GetOrganization(int id)
        {
           return Content("returns an organization information");
        }

        [HttpPost("create")]
        public ActionResult<string> CreateNewOrganization([FromBody] Organization payload)
        {
        return Content("create new organization");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateOrganization(int id, [FromBody] Organization payload)
        {
            return Content("Update organization information");
        }

        // DELETE: bookings/{id}
        [HttpDelete("{id}")]
        public ActionResult<string> DeleteOrganization(int id)
        {
          return Content("Remove organization from system");
        }
    }
}
