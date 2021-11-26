using System;

namespace eWallet.API.Models
{
    public class BaseEntity
    {

        public string Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
