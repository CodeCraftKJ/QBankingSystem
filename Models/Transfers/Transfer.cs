using System;
using System.Data.SqlClient;

namespace QBankingSystem.Models.Transfers
{
    public abstract class Transfer : ITransfer
    {
        public abstract TransferResult ExecuteTransfer(string connectionString, string insertQuery, SqlParameter[] parameters);

        protected void ExecuteSqlCommand(string connectionString, string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        protected bool DoesRecipientExist(string recipientAccountNumber, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BankAccount WHERE AccountNumber = @RecipientAccountNumber", connection))
                {
                    command.Parameters.AddWithValue("@RecipientAccountNumber", recipientAccountNumber);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        protected bool AreSufficientFunds(decimal transferAmount, string connectionString, string sourceAccountNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT Balance FROM BankAccount WHERE AccountNumber = @SourceAccountNumber", connection))
                {
                    command.Parameters.AddWithValue("@SourceAccountNumber", sourceAccountNumber);
                    decimal currentBalance = (decimal)command.ExecuteScalar();
                    return currentBalance >= transferAmount;
                }
            }
        }

        protected void UpdateBalances(string sourceAccountNumber, string recipientAccountNumber, decimal transferAmount, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand debitCommand = new SqlCommand("UPDATE BankAccount SET Balance = Balance - @TransferAmount WHERE AccountNumber = @SourceAccountNumber", connection, transaction))
                        {
                            debitCommand.Parameters.AddWithValue("@SourceAccountNumber", sourceAccountNumber);
                            debitCommand.Parameters.AddWithValue("@TransferAmount", transferAmount);
                            debitCommand.ExecuteNonQuery();
                        }

                        using (SqlCommand creditCommand = new SqlCommand("UPDATE BankAccount SET Balance = Balance + @TransferAmount WHERE AccountNumber = @RecipientAccountNumber", connection, transaction))
                        {
                            creditCommand.Parameters.AddWithValue("@RecipientAccountNumber", recipientAccountNumber);
                            creditCommand.Parameters.AddWithValue("@TransferAmount", transferAmount);
                            creditCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
