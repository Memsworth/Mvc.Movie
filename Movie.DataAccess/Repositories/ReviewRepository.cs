using Movie.Domain.Abstractions;
using Movie.Domain.Models;

namespace Movie.DataAccess.Repositories
{
    internal class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MovieDbContext dbContext) : base(dbContext)
        {
        }
    }
}
