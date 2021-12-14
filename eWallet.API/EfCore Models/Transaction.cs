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
        public string SenderWalletId { get; set; }

        [Required]
        public string RecipientWalletId { get; set; }

        public Wallet Wallets { get; set; }
        public string WalletId { get; set; }
        public string StatusId { get; set; }
        public Status Status { get; set; }
        public string TranxTypeId { get; set; }
        public TransactionType TranxType { get; set; }
    }

}
