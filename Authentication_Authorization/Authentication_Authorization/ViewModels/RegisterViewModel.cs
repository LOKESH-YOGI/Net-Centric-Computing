using System.ComponentModel.DataAnnotations;
namespace Authentication_Authorization.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public required string ConfirmPassword { get; set; }
    }
}