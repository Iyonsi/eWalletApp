using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eWallet.API.EfCore_Models
{
    public class Currency :BaseEntity
    {
        [Required]
        [MinLength(3, ErrorMessage = "Currency Name should be more than 3 letters")]
        public string Name { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "ShortCode should not be below 2 letters")]
        public string ShortCode { get; set; }


        public float Balance { get; set; } = 0.00F;
        public bool IsMain { get; set; } = false;

        public List<WalletCurrency> WalletCurrency { get; set; } = new List<WalletCurrency>();
    }
}
