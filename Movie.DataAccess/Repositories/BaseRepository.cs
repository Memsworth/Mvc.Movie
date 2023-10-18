using Movie.Domain.Abstractions;

namespace Movie.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly MovieDbContext _dbContext;
        public BaseRepository(MovieDbContext dbContext) => _dbContext = dbContext;

        
        public async Task AddAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await _dbContext.AddAsync(entity);
        }
    }
}
