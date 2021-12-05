using eWallet.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eWallet.APIModels
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(15, ErrorMessage = "First name should not be more than 15 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Last name should not be more than 15 characters")]
        public string LastName { get; set; }

        [Required, Display(Name = "EmailAddress")]
        [EmailAddress( ErrorMessage = "Input a valid email address")] 
        public string Email { get; set; }

        [Required, Display(Name = "PhoneNumber")]
        [Phone(ErrorMessage = "Input a valid email address")]
        public string PhoneNumber { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Date_of_Birth { get; set; }
       

        [Required(ErrorMessage =" Password is requried")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public byte PasswordHash { get; set; }

        [Required(ErrorMessage = " Password is requried")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public byte PasswordSalt { get; set; }

        public List<Roles> Role { get; set; }

        public ICollection<Wallet> Wallets { get; set; }
    }
}
