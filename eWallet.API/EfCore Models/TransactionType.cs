using System.Collections.Generic;

namespace eWallet.API.EfCore_Models
{
    public class TransactionType : BaseEntity
    {
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
