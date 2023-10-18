namespace Movie.Domain.Abstractions
{
    public interface IBaseRepository<T> where T : class
    {
        public Task AddAsync(T entity); 
    }
}
