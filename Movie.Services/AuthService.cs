using Movie.Domain.Abstractions;
using Movie.Domain.Models;

namespace Movie.Services
{
    public class AuthService : IAuthService
    {
        public Task<BaseServiceResponse> Login(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }

        public Task<BaseServiceResponse> Register(UserRegistration userRegistration)
        {
            throw new NotImplementedException();
        }
    }
}
