using Movie.Domain.Models;

namespace Movie.Domain.Abstractions
{
    public interface IAuthService
    {

        public Task<BaseServiceResponse> Login(UserLogin userLogin);
        public Task<BaseServiceResponse> Register(UserRegistration userRegistration);
    }
}
