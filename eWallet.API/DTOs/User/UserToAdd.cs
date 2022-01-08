﻿using System.ComponentModel.DataAnnotations;

namespace eWallet.API.DTOs
{
    public class UserToAdd
    {


        [Required]
        [MinLength(2, ErrorMessage = "First Name should not be below 2 letters")]
        public string FirstName { get; set; }

        [Required, Display(Name = "LastName")]
        [MinLength(2, ErrorMessage = "Last Name should not be below 2 letters")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Input a valid Email address")]
        public string Email { get; set; }

        [Required, Display(Name = "Phone")]
        [Phone(ErrorMessage = "Input a valid method for ")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}