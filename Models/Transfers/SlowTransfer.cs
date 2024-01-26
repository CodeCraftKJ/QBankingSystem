using System;
using System.Data.SqlClient;

namespace QBankingSystem.Models.Transfers
{
    public class SlowTransfer : Transfer
    {
        public override TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters)
        {
            try
            {
                // Check if the recipient account exists
                string recipientAccountNumber = parameters[1].Value.ToString(); // Assuming it's the second parameter
                if (!DoesRecipientExist(recipientAccountNumber, connectionString))
                {
                    return new TransferResult { IsSuccessful = false, Message = "Recipient account does not exist" };
                }

                // Check if there are sufficient funds
                decimal transferAmount = (decimal)parameters[2].Value; // Assuming it's the third parameter
                string sourceAccountNumber = parameters[0].Value.ToString(); // Assuming it's the first parameter
                if (!AreSufficientFunds(transferAmount, connectionString, sourceAccountNumber))
                {
                    return new TransferResult { IsSuccessful = false, Message = "Insufficient funds in the source account" };
                }

                // Execute the SQL command to perform the transfer
                ExecuteSqlCommand(connectionString, insertQuery, parameters);

                // Update balances
                UpdateBalances(sourceAccountNumber, recipientAccountNumber, transferAmount, connectionString);

                return new TransferResult { IsSuccessful = true, Message = "Slow transfer successful" };
            }
            catch (Exception ex)
            {
                return new TransferResult { IsSuccessful = false, Message = $"Slow transfer failed: {ex.Message}" };
            }
        }
    }
}

