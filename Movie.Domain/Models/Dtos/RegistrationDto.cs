using System.ComponentModel.DataAnnotations;

namespace Movie.Domain.Models.Dtos
{
    public class RegistrationDto : LoginDto
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
