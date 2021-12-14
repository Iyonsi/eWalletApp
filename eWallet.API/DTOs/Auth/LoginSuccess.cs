namespace eWallet.API.DTOs
{
    public class LoginSuccess
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public bool LoginStatus { get; set; } = false;
    }
}
