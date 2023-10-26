using Movie.DataAccess.Dtos;
using Movie.Domain.Abstractions;
using Movie.Domain.Models;
namespace Movie.Services
{
    public class AuthService
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
