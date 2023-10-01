using Microsoft.EntityFrameworkCore;
using Movie.Domain.Models;

namespace Movie.DataAccess;

public class MovieDbContext : DbContext
{
    public MovieDbContext(DbContextOptions options) : base (options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Domain.Models.Movie> Movies { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}