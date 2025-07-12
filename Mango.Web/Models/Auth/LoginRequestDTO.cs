﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Web.Models.Auth
{
    public class LoginRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
