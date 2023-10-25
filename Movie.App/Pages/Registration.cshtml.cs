using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie.Domain.Abstractions;
using Movie.Domain.Models.Dtos;

namespace Movie.App.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly IAuthService _authService;
        public RegistrationModel(IAuthService authService) => _authService = authService;

        [BindProperty]
        public RegistrationDto Registration { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Registration is not null && ModelState.IsValid)
            {
                await _authService.Register(Registration);
                return RedirectToPage("./Index");
            }

            return RedirectToPage("./Error");
        }
        public void OnGet()
        {
        }
    }
}
