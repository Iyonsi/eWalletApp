using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZiggyWalletFinalEdition.Models
{
    public class Wallet : BaseEntity
    {

        [Required]
        [MinLength(5, ErrorMessage = "Wallet Name should not be below 5 letters")]
        public string Name { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "Wallet Address should not be below 16 letters")]
        public string Address { get; set; }

        [Required]
        public float Balance { get; set; } = 0.00F;

        public bool IsMain { get; set; } = false;

        public AppUser AppUsers { get; set; }
        public string AppUserId { get; set; }
        public List<WalletCurrency> WalletCurrency { get; set; }

        public Wallet()
        {
            WalletCurrency = new List<WalletCurrency>();
        }
    }
}
