using System.ComponentModel.DataAnnotations;

namespace Movie.Domain.Models;

public class Film
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ImageUrl { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public virtual ICollection<Review>? Reviews { get; set; }   
}