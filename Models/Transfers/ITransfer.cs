
using System.Data.SqlClient;

namespace QBankingSystem.Models.Transfers
{
    public interface ITransfer
    {
        TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters);
    }
}
