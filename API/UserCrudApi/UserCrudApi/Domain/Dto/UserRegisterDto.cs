﻿using System.ComponentModel.DataAnnotations;

namespace UserCrudApi.Domain.Dto
{
    public class UserRegisterDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
