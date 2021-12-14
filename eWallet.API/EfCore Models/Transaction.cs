using eWallet.API.Models;
using System.ComponentModel.DataAnnotations;

namespace eWallet.API.EfCore_Models
{
    public class Transaction : BaseEntity
    {

        [Required]
        public float Amount { get; set; } = 0.00F;

        public string Description { get; set; }


        [Required]
        [MinLength(8, ErrorMessage = "SenderName should not be below 2 letters")]
        public string SenderWalletId { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Reciepient Wallet should not be below 2 letters")]
        public string RecipientWalletId { get; set; }

        public Wallet Wallets { get; set; }
        public string WalletId { get; set; }
        public string StatusId { get; set; }
        public Status Status { get; set; }
        public string TranxTypeId { get; set; }
        public TranxType TranxType { get; set; }
    }

}
