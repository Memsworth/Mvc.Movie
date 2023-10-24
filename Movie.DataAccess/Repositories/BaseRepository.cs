using Microsoft.EntityFrameworkCore;
using Movie.Domain.Abstractions;
using Movie.Domain.Models;

namespace Movie.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly MovieDbContext _dbContext;
        public BaseRepository(MovieDbContext dbContext) => _dbContext = dbContext;

        
        public async Task AddAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await _dbContext.AddAsync(entity);
        }

        public async Task<T?> FindByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetAsync()
        {
            return  await _dbContext.Set<T>().ToListAsync();
        }

    }
}
