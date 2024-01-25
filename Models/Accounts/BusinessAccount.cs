using System;

namespace QBankingSystem.Models
{
    public class BusinessAccount : Account
    {
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Business Account - Balance: ${Balance}");
        }

        public override void SpecialAccountAbility()
        {
            Console.WriteLine("Special Ability: Business financing options available.");
        }
    }
}
