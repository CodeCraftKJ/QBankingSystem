using System;

namespace QBankingSystem.Models
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Savings Account - Account Number: {AccountNumber} - Balance: ${GetBalance()}");
        }
    }
}
