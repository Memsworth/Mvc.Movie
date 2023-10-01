using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Movie.DataAccess;

public class MovieDesignTimeFactory : IDesignTimeDbContextFactory<MovieDbContext>
{
    public MovieDbContext CreateDbContext(string[] args)
    {
        var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        var dbPath = Path.Join(folderPath, "Movie.db");

        var optionBuilder = new DbContextOptionsBuilder<MovieDbContext>();
        optionBuilder.UseSqlite($"Data Source={dbPath}");   
        return new MovieDbContext(optionBuilder.Options);    }
}