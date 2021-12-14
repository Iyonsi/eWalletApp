using System.Collections.Generic;

namespace ZiggyWalletFinalEdition.Models
{
    public class TranxType : BaseEntity
    {
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
