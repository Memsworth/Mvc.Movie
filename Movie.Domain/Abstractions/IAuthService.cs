using Movie.Domain.Dtos;

namespace Movie.Domain.Abstractions
{
    public interface IAuthService
    {
        public Task Register(RegistrationDto userRegistration);
    }
}
