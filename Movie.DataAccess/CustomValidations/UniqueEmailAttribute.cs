using Movie.Domain.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Movie.DataAccess.CustomValidations
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        private readonly IUnitOfWork _unitOfWork;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var emailInput = value as string;
            if (string.IsNullOrEmpty(emailInput)) 
            {
                return ValidationResult.Success;
            }



            var userEmail = _unitOfWork.UserRepository.GetAsync().Result.FirstOrDefault(x=> x.Email == emailInput.ToLower());

            if (userEmail is null) { return ValidationResult.Success; }

            return new ValidationResult("Email is already in use");
        }
    }
}
