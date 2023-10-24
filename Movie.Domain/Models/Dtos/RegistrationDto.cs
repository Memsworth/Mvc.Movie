namespace Movie.Domain.Models.Dtos
{
    public class RegistrationDto : LoginDto
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
