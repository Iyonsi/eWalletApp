using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Models
{
    public class Currency : BaseEntity
    {
        public string Id = Guid.NewGuid().ToString();
        public string CurrencyName { get; set; }
        public Char CurrencySymbol { get; set; }
        public string WalletId { get; set; }
        public ICollection <Wallet> Wallets { get; set; }
    }
} 
