using System.ComponentModel.DataAnnotations;

namespace PMS_NET1.Models.Auth {

#pragma warning disable CS8618
public class RegisterRequestDto
{
    // Personal Information
    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string LastName { get; set; }

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

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    // Address Information
    [Required]
    [StringLength(100, MinimumLength = 1)]
    public string StreetAddress { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string City { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string StateOrProvince { get; set; }

    [Required]
    [StringLength(20, MinimumLength = 1)]
    public string PostalCode { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 1)]
    public string Country { get; set; }

    // Additional Information
    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    [StringLength(10)]
    public string Gender { get; set; }

    [StringLength(50)]
    public string PreferredLanguage { get; set; }

    [StringLength(500)]
    public string SpecialRequests { get; set; }
}

#pragma warning restore CS8618

}

