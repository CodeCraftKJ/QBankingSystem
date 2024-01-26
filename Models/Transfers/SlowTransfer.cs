using System;
using System.Data.SqlClient;
using System.Threading;

namespace QBankingSystem.Models.Transfers
{
    public class SlowTransfer : Transfer
    {
        public override TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters)
        {
            try
            {
                Thread.Sleep(5000);
                ExecuteSqlCommand(connectionString, insertQuery, parameters);

                return new TransferResult { IsSuccessful = true, Message = "Slow transfer successful" };
            }
            catch (Exception ex)
            {
                return new TransferResult { IsSuccessful = false, Message = $"Slow transfer failed: {ex.Message}" };
            }
        }
    }
}
