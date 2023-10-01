namespace Movie.Domain.Models;

public class Review
{
    public int Id { get; set; }
    public string ReviewText { get; set; }
    public int Rating { get; set; }
    public int userId { get; set; }
    public User User { get; set; }
    public int MovieId  { get; set; }
    public Movie Movie { get; set; }
}