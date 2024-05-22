using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("rates")]
[ApiController]
public class RatesController : ControllerBase
{

    // GET: api/rates/1/2024-03-15
    [HttpGet("{roomId}/{date}")]
    public ActionResult<string> GetRatesForDate(int roomId, DateTime date)
    {
       return Content("Get room rates");
    }

    // POST: api/rates
    [HttpPost]
    public ActionResult<string> CreateRate([FromBody] Rates rate)
    {
    return Content("creates a ratings record for a room");
    }

    // PUT: api/rates/1
    [HttpPut("{id}")]
    public IActionResult UpdateRate(int id, [FromBody] Rates updatedRate)
    {
        return NoContent();
    }

    // DELETE: api/rates/1
    [HttpDelete("{id}")]
    public IActionResult DeleteRate(int id)
    {
        return Content("Remove Ratings");
    }
}
