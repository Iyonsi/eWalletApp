namespace eWallet.API.EfCore_Models
{
    public class WalletCurrency : BaseEntity
    {
        public string WalletId { get; set; }
        public string CurrencyId { get; set; }
        public Wallet Wallet { get; set; }
        public Currency Currency { get; set; }
    }
}
