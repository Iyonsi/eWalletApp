using eWallet.API.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eWallet.API.EfCore_Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MinLength(2, ErrorMessage = "First Name should be above below 2 letters")]
        public string FirstName { get; set; }

        [Required, Display(Name = "LastName")]
        [MinLength(2, ErrorMessage = "Last Name should be below above 2 letters")]
        public string LastName { get; set; }

        public byte[] PasswordSalt { get; set; }

        public List<Wallet> Wallets { get; set; } = new List<Wallet>(); // 1 to many

        // noob User ==> Only one Wallet, and one Currency
        // Elite User ==> Multiple wallets, and each of this wallet can have multiple currencies

    }
}
