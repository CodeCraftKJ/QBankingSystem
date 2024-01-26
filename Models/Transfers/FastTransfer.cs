using System;
using System.Data.SqlClient;

namespace QBankingSystem.Models.Transfers
{
    public class FastTransfer : Transfer
    {
        public override TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters)
        {
            try
            {
                ExecuteSqlCommand(connectionString, insertQuery, parameters);

                return new TransferResult { IsSuccessful = true, Message = "Fast transfer successful" };
            }
            catch (Exception ex)
            {
                return new TransferResult { IsSuccessful = false, Message = $"Fast transfer failed: {ex.Message}" };
            }
        }
    }
}
