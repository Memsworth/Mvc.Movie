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
            //fix this later
            if (userRegistration is null) throw new Exception("registration is null");

            var user = (await _unitOfWork.UserRepository.GetAsync()).FirstOrDefault(x => x.Email == userRegistration.Email.ToLower());

            if (user is not null) throw new Exception("Username or email is already in use");
            
            await _unitOfWork.UserRepository.AddAsync(new User
            {
                Email = userRegistration.Email.ToLower(),
                HashedPassowrd = BCrypt.Net.BCrypt.HashPassword(userRegistration.Password),
                Name = userRegistration.Name,
                DateOfBirth = userRegistration.DateOfBirth,
                CreatedDate = DateTime.Now,
                Role = Role.User
            });

            await _unitOfWork.CommitAsync();
        }
    }
}
