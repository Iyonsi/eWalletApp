using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eWallet.API.EfCore_Models
{
    public class Wallet : BaseEntity
    {

        [Required]
        [MinLength(5, ErrorMessage = "Wallet Name should be above 5 letters")]
        public string Name { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "Wallet Address should be above 8 letters")]
        public string Address { get; set; }

        [Required]
        public float Balance { get; set; } = 0.00F;

        public bool IsMain { get; set; } = false;

        public AppUser AppUsers { get; set; }
        public string AppUserId { get; set; }
        public List<WalletCurrency> WalletCurrency { get; set; } = new List<WalletCurrency>();

       
    }
}
