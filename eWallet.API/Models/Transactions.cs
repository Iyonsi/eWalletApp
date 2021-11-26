using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Models
{
    public class Transactions
    {
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();
        public string Sender { get; set; }
        public string Desscription  { get; set; }
        public string TransactionType  { get; set; }
        public DateTime TransactionDate  { get; set; }
        public string Currency  { get; set; }
        public decimal Amount  { get; set; }
        public byte Status  { get; set; }
        public string Recipient { get; set; }

        public string WalletId { get; set; }
        public Wallet Wallet { get; set; }
    }
}
