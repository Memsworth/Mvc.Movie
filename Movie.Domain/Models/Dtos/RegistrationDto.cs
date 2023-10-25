using System.ComponentModel.DataAnnotations;

namespace Movie.Domain.Models.Dtos
{
    public class RegistrationDto
    {
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Name should only contain letters and spaces")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}



