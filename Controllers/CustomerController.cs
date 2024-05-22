// Controllers/RoomsController.cs
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS_NET1.Controllers
{
    [Route("customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
  [HttpGet()]
public ActionResult<string> GetCustomers()
{
    return Content("Get all customers");
}

        [HttpGet("{id}")]
        public ActionResult<string> GetCustomer(int id)
        {
           return Content("returns customer information according to a given id");
        }

        [HttpPost("create")]
        public ActionResult<string> CreateNewCustomer([FromBody] Customer payload)
        {
        return Content("create new customer");
        }

        [HttpPut("{id}")]
        public ActionResult<string> UpdateCustomer(int id, [FromBody] Customer payload)
        {
            return Content("Update customer information");
        }

        [HttpDelete("{id}")]
        public ActionResult<string> RemoveCustomer(int id)
        {
          return Content("Delete customer information");
        }
    }
}
