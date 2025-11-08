using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Player name is required.")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Jersey number is required.")]
        [Range(1, 99, ErrorMessage = "Jersey number must be between 1 and 99.")]
        public int JerseyNumber { get; set; }

        [Required(ErrorMessage = "Position is required.")]
        [StringLength(30)]
        public string Position { get; set; }

        [Required(ErrorMessage = "Date of birth is required.")]
        [DataType(DataType.Date)]
        [MinimumAge(18, ErrorMessage = "Player must be at least 18 years old.")]
        public DateTime DateOfBirth { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Salary must be non-negative.")]
        public decimal Salary { get; set; }
    }

    // Custom validation attribute (server-side)
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minAge;

        public MinimumAgeAttribute(int minAge)
        {
            _minAge = minAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult(ErrorMessage ?? $"Minimum age is {_minAge}.");

            if (value is DateTime dob)
            {
                var today = DateTime.Today;
                int age = today.Year - dob.Year;
                if (dob > today.AddYears(-age)) age--;

                return (age >= _minAge)
                    ? ValidationResult.Success
                    : new ValidationResult(ErrorMessage ?? $"Minimum age is {_minAge}.");
            }

            return new ValidationResult("Invalid date");
        }
    }
}
