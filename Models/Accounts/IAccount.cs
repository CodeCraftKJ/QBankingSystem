namespace QBankingSystem.Models
{
    public interface IAccount
    {
        void DisplayAccountInfo();
        void Deposit(double amount);
        void Withdraw(double amount);
        double GetBalance();
        string GetAccountNumber();
    }
}
