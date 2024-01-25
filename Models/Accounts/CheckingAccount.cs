using System;

namespace QBankingSystem.Models
{
    public class CheckingAccount : Account
    {
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account - Balance: ${Balance}");
        }

        public override void SpecialAccountAbility()
        {
            Console.WriteLine("Special Ability: Easily accessible for day-to-day transactions.");
        }
    }
}
