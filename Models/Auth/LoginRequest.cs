// File: Models/LoginRequest.cs
using System.ComponentModel.DataAnnotations;

namespace PMS_NET1.Models.Auth
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Email is required.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
