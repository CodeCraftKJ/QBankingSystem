using System;

namespace QBankingSystem.Models
{
    public class SavingsAccount : Account
    {
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Savings Account - Balance: ${Balance}");
        }

        public override void SpecialAccountAbility()
        {
            Console.WriteLine("Special Ability: Interest is earned on savings.");
        }
    }
}
