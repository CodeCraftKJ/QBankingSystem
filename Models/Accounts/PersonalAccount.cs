using System;

namespace QBankingSystem.Models
{
    public class PersonalAccount : Account
    {
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Personal Account - Balance: ${Balance}");
        }

        public override void SpecialAccountAbility()
        {
            Console.WriteLine("Special Ability: Personalized service for account holders.");
        }
    }
}
