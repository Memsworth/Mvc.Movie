using Movie.Domain.Abstractions;
using Movie.Domain.Dtos;
using Movie.Domain.Models;
namespace Movie.Services
{
    public class AuthService : IAuthService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public AuthService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;


        public async Task Register(RegistrationDto userRegistration)
        {
            //fix this later
            if (userRegistration is null) throw new Exception("registration is null");

            //This is where the meat is
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
