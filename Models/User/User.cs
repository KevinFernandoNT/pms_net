// File: Models/LoginRequest.cs
using System.ComponentModel.DataAnnotations;

namespace PMS_NET1.Models.User
{
#pragma warning disable CS8618

      public class User
    {

    public int Id { get; set; }
        // Personal Information
    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string Username { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 6)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [StringLength(500)]
    public string Role { get; set; }

    [Required]
    public int Organization { get; set; }
}

}
