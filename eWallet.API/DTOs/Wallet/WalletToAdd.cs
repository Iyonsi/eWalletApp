using eWallet.API.EfCore_Models;
using System;
namespace eWallet.API.DTOs
{
    public class WalletToAdd
    {
        public string Id { get; set; }
        public string Address { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }
        public Currency MainCurrency { get; set; }
    }
}
