﻿namespace eWallet.API.EfCore_Models
{
    public class CurrencyToAdd
    {

        public string Name { get; set; }
        public string wallet { get; set; }
        public decimal Balance { get; set; }
        public bool IsMain { get; set; } = false;
    }
}