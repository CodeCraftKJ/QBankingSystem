using System;

namespace QBankingSystem.Models.Transfers
{
    public class FastTransfer : Transfer
    {
        public override TransferResult ExecuteTransfer(TransferInfo transferInfo)
        {
            Console.WriteLine("Executing fast transfer...");
            return new TransferResult { IsSuccessful = true, Message = "Fast transfer successful" };
        }
    }
}
