using System;

namespace QBankingSystem.Models
{
    public class CurrencyAccount : Account
    {
        public CurrencyAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Currency Account - Account Number: {AccountNumber} - Balance: ${GetBalance()}");
        }
    }
}
