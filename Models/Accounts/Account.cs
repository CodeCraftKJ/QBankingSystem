using System;

namespace QBankingSystem.Models
{
    public abstract class Account : IAccount
    {
        protected double Balance { get; set; }
        public string AccountNumber { get; private set; }

        public Account(string accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public string GetAccountNumber()
        {
            return AccountNumber;
        }

        public double GetBalance()
        {
            return Balance;
        }
        public void SetBalance(double newBalance)
        {
            Balance = newBalance;
        }

    }
}