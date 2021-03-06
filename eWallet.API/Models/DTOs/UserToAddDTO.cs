using eWallet.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eWallet.APIModels.DTOs
{
    public class UserToAddDTO
    {
        

        [Required]
        [StringLength(15, ErrorMessage = "First name should not be more than 15 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last name should not be more than 15 characters")]
        public string LastName { get; set; }

        [Required, Display(Name = "EmailAddress")]
        [EmailAddress(ErrorMessage = "Input a valid email address")]
        public string EmailAddress { get; set; }

        [Required, Display(Name = "PhoneNumber")]
        [Phone(ErrorMessage = "Input a valid email address")]
        public string PhoneNumber { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }


        [Required(ErrorMessage = " Password is requried")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " Password is requried")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ComfirmPassword { get; set; }
        public CreatWalletDTO Wallet { get; set; }
    }
}
