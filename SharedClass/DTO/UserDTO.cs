﻿using SharedClass.DTO;
using System.ComponentModel.DataAnnotations;

namespace SharedClass.DTO
{
    public class UserDTO
    {
        public string? Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]

        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
