namespace QBankingSystem.Models
{
    public interface IAccount
    {
        double GetBalance();

        void SetBalance(double newBalance);
        string GetAccountNumber();
    }
}
