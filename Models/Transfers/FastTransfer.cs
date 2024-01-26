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
                string recipientAccountNumber = parameters[1].Value.ToString();
                if (!DoesRecipientExist(recipientAccountNumber, connectionString))
                {
                    return new TransferResult { IsSuccessful = false, Message = "Recipient account does not exist" };
                }
                decimal transferAmount = (decimal)parameters[2].Value;
                string sourceAccountNumber = parameters[0].Value.ToString();
                if (!AreSufficientFunds(transferAmount, connectionString, sourceAccountNumber))
                {
                    return new TransferResult { IsSuccessful = false, Message = "Insufficient funds in the source account" };
                }

                ExecuteSqlCommand(connectionString, insertQuery, parameters);

                UpdateBalances(sourceAccountNumber, recipientAccountNumber, transferAmount, connectionString);

                return new TransferResult { IsSuccessful = true, Message = "Fast transfer successful" };
            }
            catch (Exception ex)
            {
                return new TransferResult { IsSuccessful = false, Message = $"Fast transfer failed: {ex.Message}" };
            }
        }
    }
}
