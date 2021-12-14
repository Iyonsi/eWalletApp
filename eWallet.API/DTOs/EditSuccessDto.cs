namespace eWallet.API.EfCore_Models
{
    public class EditSuccessDto
    {
        public bool Status { get; set; }
        public string UserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
