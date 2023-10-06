namespace Movie.Domain.Abstractions
{
    internal interface IUnitOfWork
    {
        public IFilmRepository FilmRepository { get; }
        public IUserRepository UserRepository { get; }
        public IReviewRepository ReviewRepository { get; }
    }
}
