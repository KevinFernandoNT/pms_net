using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using PMS_NET1.Models.User;

namespace PMS_NET1.Controllers
{
    [Route("user")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // In-memory user store for example purposes
        private static List<User> Users = new List<User>
        {
            new User {
                Id = 1,
                Username = "John Doe",
                Email = "john.doe@example.com",
                Password = "StrongPassword123",
                ConfirmPassword = "StrongPassword123",
                Role = "Admin",
                Organization = 1
            },
            new User
            {
                Id = 2,
                Username = "Jane Smith",
                Email = "jane.smith@example.com",
                Password = "AnotherStrongPassword456",
                ConfirmPassword = "AnotherStrongPassword456",
                Role = "User",
                Organization = 1
            }
        };

        // GET /users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return Users;
        }

        // GET /users/{id}
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST /users
        [HttpPost]
        public ActionResult<User> CreateUser(User newUser)
        {
            newUser.Id =  Users.Count + 1; // Simple ID generation
            Users.Add(newUser);
            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
        }

        // PUT /users/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            user.Username = updatedUser.Username;
            user.Email = updatedUser.Email;
            return NoContent();
        }

        // DELETE /users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            Users.Remove(user);
            return NoContent();
        }
    }

}
