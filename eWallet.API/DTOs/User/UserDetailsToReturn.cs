using eWallet.API.EfCore_Models;
using System;
using System.Collections.Generic;

namespace eWallet.API.DTOs
{
    public class UserDetailsToReturn
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserRole { get; set; }


        public string PhoneNumber { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<Wallet> Wallets { get; set; }//navigation


        public DateTime CreatedDate { get; set; }
    }
}
