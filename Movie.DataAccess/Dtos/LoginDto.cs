﻿using System.ComponentModel.DataAnnotations;

namespace Movie.DataAccess.Dtos
{
    public class LoginDto
    {
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
