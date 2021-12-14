using eWallet.API.EfCore_Models;
using System;


namespace eWallet.API.DTOs
{
    public class trxMsg
    {
        public string TrxId { get; set; } = Guid.NewGuid().ToString();

        public string Type { get; set; }

        public Currency Currency { get; set; }

        public decimal Amount { get; set; }

        public AppUser ToWallet { get; set; }

        public AppUser FromWallet { get; set; }
    }
}
