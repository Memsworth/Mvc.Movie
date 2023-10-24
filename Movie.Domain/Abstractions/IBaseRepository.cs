using Movie.Domain.Models;

namespace Movie.Domain.Abstractions
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        public Task AddAsync(T entity); 
        public Task<T?> FindByIdAsync(int id);
        public Task<List<T>> GetAsync();
    }
}
