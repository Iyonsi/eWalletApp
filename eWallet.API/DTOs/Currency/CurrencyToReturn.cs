namespace eWallet.API.EfCore_Models
{
    public class CurrencyToReturn
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public float Balance { get; set; }
        public bool IsMain { get; set; } = false;
    }
}
