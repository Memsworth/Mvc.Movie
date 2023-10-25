﻿using System.ComponentModel.DataAnnotations;

namespace Movie.Domain.Models.Dtos
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
