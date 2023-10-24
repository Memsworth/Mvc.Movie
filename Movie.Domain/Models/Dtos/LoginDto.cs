namespace Movie.Domain.Models.Dtos
{
    public class LoginDto
    {
        public string Email { get; set; }
        public byte[] Password { get; set; }
    }
}
