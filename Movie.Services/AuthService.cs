using Movie.Domain.Abstractions;
using Movie.Domain.Models;
using Movie.Domain.Models.Dtos;

namespace Movie.Services
{
    public class AuthService : IAuthService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public AuthService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

        public Task<BaseServiceResponse> Login(LoginDto userLogin)
        {
            throw new NotImplementedException();
        }

        public async Task Register(RegistrationDto userRegistration)
        {
            if (userRegistration is not null)
            {
                await _unitOfWork.UserRepository.AddAsync(new User
                {
                    Email = userRegistration.Email,
                    HashedPassowrd = userRegistration.Password,
                    Name = userRegistration.Name,
                    DateOfBirth = userRegistration.DateOfBirth,
                    CreatedDate = DateTime.Now,
                    Role = Role.User
                });
            }
            
        }
    }
}
