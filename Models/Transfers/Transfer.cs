
namespace QBankingSystem.Models.Transfers
{
    public abstract class Transfer : ITransfer
    {
        public abstract TransferResult ExecuteTransfer(TransferInfo transferInfo);
    }
}
