using Movie.Domain.Abstractions;
using Movie.Domain.Models;

namespace Movie.DataAccess.Repositories
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(MovieDbContext dbContext) : base(dbContext)
        {
        }
    }
}
