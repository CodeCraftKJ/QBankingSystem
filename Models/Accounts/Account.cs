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

        public abstract void DisplayAccountInfo();

        public double GetBalance()
        {
            return Balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                return;
            }
        }
    }
}