namespace Movie.Domain.Abstractions
{
    internal interface IBaseRepository<T> where T : class
    {
        public Task<T> AddAsync(int id); 
    }
}
