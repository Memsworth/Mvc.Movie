using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie.Domain.Abstractions;
using Movie.Domain.Dtos;
using Movie.Services;

namespace Movie.App.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly AuthService _authService;
        public RegistrationModel(AuthService authService) => _authService = authService;

        [BindProperty]
        public RegistrationDto Registration { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _authService.Register(Registration);
                return RedirectToPage("./Index");

            }

            return Page();
        }
        public void OnGet()
        {
        }
    }
}
