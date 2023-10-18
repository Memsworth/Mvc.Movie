using Movie.Domain.Models;
using Movie.Domain.Abstractions;

namespace Movie.DataAccess.Repositories
{
    internal class FilmRepository : BaseRepository<Film>, IFilmRepository
    {
        public FilmRepository(MovieDbContext dbContext) : base(dbContext)
        {
        }
    }
}
