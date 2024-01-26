using System;

namespace QBankingSystem.Models
{
    public class PersonalAccount : Account
    {
        public PersonalAccount(string accountNumber) : base(accountNumber)
        {
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Personal Account - Account Number: {AccountNumber} - Balance: ${GetBalance()}");
        }
    }
}
