using System.ComponentModel.DataAnnotations;

namespace Movie.Domain.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ImageUrl { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public List<Review>? Reviews { get; set; }   
}