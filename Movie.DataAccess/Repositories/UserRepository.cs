using Movie.Domain.Abstractions;
using Movie.Domain.Models;

namespace Movie.DataAccess.Repositories
{
    internal class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MovieDbContext dbContext) : base(dbContext)
        {
        }
    }
}
