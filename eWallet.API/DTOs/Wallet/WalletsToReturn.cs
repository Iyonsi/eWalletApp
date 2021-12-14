using eWallet.API.EfCore_Models;
using System.Collections.Generic;


namespace eWallet.API.DTOs
{
    public class WalletsToReturn
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Balance { get; set; }
        public bool IsMain { get; set; } = false;
        public string UserId { get; set; }
        public AppUser User { get; set; }
        public List<Currency> Currencies { get; set; }


    }
}
