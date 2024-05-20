using Microsoft.AspNetCore.Mvc;
using PMS_NET1.Models.Auth;

namespace PMS_NET1.Controllers
{
[Route("auth")]
[ApiController]
public class AuthController : ControllerBase
{
    // POST /api/auth/login
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        // Implement authentication logic here
        // Example: Validate username and password, generate token
        // Return token or error message
        return Ok(new { token = "eyJhbGciOiJIUzI1NiJ9.eyJSb2xlIjoiQWRtaW4iLCJJc3N1ZXIiOiJJc3N1ZXIiLCJVc2VybmFtZSI6IkphdmFJblVzZSIsImV4cCI6MTcxNjIxODQ4OCwiaWF0IjoxNzE2MjE4NDg4fQ.vOcIlWRS79vN4q-HC18lcfKzsd3BkUE0hGCHZuETr9Q" });
    }

    // POST /api/auth/register
    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequest request)
    {
        // Implement registration logic here
        // Example: Create new user in database
        // Return success message or error message
        return Ok(new { message = "User registered successfully" });
    }

    // POST /api/auth/logout
    [HttpPost("logout")]
    public IActionResult Logout()
    {
        // Implement logout logic here
        // Example: Invalidate token, clear session
        // Return success message
        return Ok(new { message = "Logout successful" });
    }
}


}
