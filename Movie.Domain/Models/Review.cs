namespace Movie.Domain.Models;

public class Review
{
    public int Id { get; set; }
    public string ReviewText { get; set; }
    public int Rating { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public int FilmId  { get; set; }
    public virtual Film Film { get; set; }
}