
namespace QBankingSystem.Models.Transfers
{
    public class TransferInfo
    {
        public string SourceAccountNumber { get; set; }
        public string TargetAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransferTitle { get; set; }

        public TransferInfo(string sourceAccountNumber, string targetAccountNumber, decimal amount, string transferTitle)
        {
            SourceAccountNumber = sourceAccountNumber;
            TargetAccountNumber = targetAccountNumber;
            Amount = amount;
            TransferTitle = transferTitle;
        }
    }

}
