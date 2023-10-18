namespace Movie.Domain.Models
{
    internal class UserRegistration
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DateOfBirth { get; set; }
    }
}
