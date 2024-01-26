using System;

namespace QBankingSystem.Models.Transfers
{
    public class TransferInfo
    {
        public string Source { get; set; }
        public string Target { get; set; }
        public decimal Amount { get; set; }
        public string Title { get; set; }
        public DateTime TransferDate { get; set; }
        public bool Status { get; set; }

        public TransferInfo(string source, string target, decimal amount, string title, DateTime transferDate, bool status)
        {
            Source = source;
            Target = target;
            Amount = amount;
            Title = title;
            TransferDate = transferDate;
            Status = status;
        }
    }
}
