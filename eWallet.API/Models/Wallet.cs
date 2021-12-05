using eWallet.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Models
{
    public class Wallet
    {
        public string Id = Guid.NewGuid().ToString();
        public string WalletType { get; set; }
        public Currency Currencies { get; set; }
        public byte Status { get; set; } = 0;
        public List<Transactions> Transactions { get; set; }
        public string UserId { get; set; }
        public User user { get; set; }

    }
}
