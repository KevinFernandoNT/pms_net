// File: Models/LoginRequest.cs
using System.ComponentModel.DataAnnotations;

namespace PMS_NET1.Models.Auth

{
    #pragma warning disable CS8618

    public class LoginRequestDto
    {
        [Required(ErrorMessage = "Email is required.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
    #pragma warning restore CS8618

}
