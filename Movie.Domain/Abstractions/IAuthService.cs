using Movie.Domain.Models;
using Movie.Domain.Models.Dtos;

namespace Movie.Domain.Abstractions
{
    public interface IAuthService
    {
        public Task<BaseServiceResponse> Login(LoginDto userLogin);
        public Task Register(RegistrationDto userRegistration);
    }
}
