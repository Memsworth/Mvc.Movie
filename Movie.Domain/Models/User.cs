namespace Movie.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Role Role { get; set; }
    public IEnumerable<Review>? Reviews { get; set; }
    
}