﻿using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.Dto.Requests
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; } = "";
        [Required]
        public string RefreshToken { get; set; } = "";

    }
}
