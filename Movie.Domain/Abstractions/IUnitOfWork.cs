namespace Movie.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        public IFilmRepository FilmRepository { get; }
        public IUserRepository UserRepository { get; }
        public IReviewRepository ReviewRepository { get; }
    }
}
