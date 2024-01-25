using System;

namespace QBankingSystem.Models
{
    public abstract class Account : IAccount
    {
        protected double Balance { get; set; }

        public abstract void DisplayAccountInfo();
        public abstract void SpecialAccountAbility();

        public double GetBalance() 
        { 
            return Balance; 
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit of ${amount} to {GetType().Name}.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal of ${amount} from {GetType().Name}.");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in {GetType().Name}.");
            }
        }

        protected Account()
        {
            Balance = 0;
        }
    }
}
