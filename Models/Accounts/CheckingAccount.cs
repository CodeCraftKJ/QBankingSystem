using System;

namespace QBankingSystem.Models
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account - Account Number: {AccountNumber} - Balance: ${GetBalance()}");
        }
    }
}
