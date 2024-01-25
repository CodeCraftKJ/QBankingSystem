using System;

namespace QBankingSystem.Models
{
    public class CurrencyAccount : Account
    {
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Currency Account - Balance: ${Balance}");
        }

        public override void SpecialAccountAbility()
        {
            Console.WriteLine("Special Ability: Handles multiple currencies.");
        }
    }
}
