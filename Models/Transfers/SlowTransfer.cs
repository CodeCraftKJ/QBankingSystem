using System;

namespace QBankingSystem.Models.Transfers
{
    public class SlowTransfer : Transfer
    {
        public override TransferResult ExecuteTransfer(TransferInfo transferInfo)
        {
            Console.WriteLine("Executing slow transfer...");
            System.Threading.Thread.Sleep(5000);
            return new TransferResult { IsSuccessful = true, Message = "Slow transfer successful" };
        }
    }
}
