﻿using eWallet.API.EfCore_Models;


namespace eWallet.API.DTOs
{
    public class TransactionstoReturn
    {

        public string Id { get; set; }
        public decimal? Amount { get; set; }
        public TransactionType TranxType { get; set; }
        public string Description { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public Status Status { get; set; }

    }
}