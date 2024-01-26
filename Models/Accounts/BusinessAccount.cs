using System;

namespace QBankingSystem.Models
{
    public class BusinessAccount : Account
    {
        public BusinessAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Business Account - Account Number: {AccountNumber} - Balance: ${GetBalance()}");
        }
    }
}
