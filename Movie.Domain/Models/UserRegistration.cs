namespace Movie.Domain.Models
{
    public class UserRegistration : UserLogin
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DateOfBirth { get; set; }
    }
}
