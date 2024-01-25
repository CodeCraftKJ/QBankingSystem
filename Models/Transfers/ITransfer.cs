
namespace QBankingSystem.Models.Transfers
{
    public interface ITransfer
    {
        TransferResult ExecuteTransfer(TransferInfo transferInfo);
    }
}
