﻿using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationAPI.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}