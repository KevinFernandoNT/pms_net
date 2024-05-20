using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PMS_NET1.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost("SayHello/{name}")]
        public IActionResult SayHello(string name)
        {

            string greeting =  $"Hello, {name}!";
            return Ok(greeting); // Return an HTTP 200 OK response with the content
        }

        [HttpGet("Error")]
        public IActionResult Error()
        {
            // Simulate an error response for demonstration
            return StatusCode(500, new { Message = "Internal Server Error" });
        }
    }
}
