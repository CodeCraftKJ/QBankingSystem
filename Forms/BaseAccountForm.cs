using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QBankingSystem.Models;
using QBankingSystem.Models.Transfers;

namespace QBankingSystem.Forms
{
    public partial class BaseAccountForm : Form
    {
        private IAccount currentAccount;

        public BaseAccountForm(IAccount account)
        {
            InitializeComponent();
            currentAccount = account;
            DisplayAccountInfo();
        }

        private void DisplayAccountInfo()
        {
            accountBalanceLabel.Text = $"Account Balance: ${currentAccount.GetBalance():F2}";
            accountNumberLabel.Text = $"Account Number: {currentAccount.GetAccountNumber()}";
            string accountTypeText;
            switch (currentAccount)
            {
                case BusinessAccount _:
                    accountTypeText = "Business Account";
                    break;
                case CheckingAccount _:
                    accountTypeText = "Checking Account";
                    break;
                case CurrencyAccount _:
                    accountTypeText = "Currency Account";
                    break;
                case PersonalAccount _:
                    accountTypeText = "Personal Account";
                    break;
                case SavingsAccount _:
                    accountTypeText = "Savings Account";
                    break;
                default:
                    accountTypeText = "Unknown Account Type";
                    break;
            }
            accountTypeLabel.Text = $"Account Type: {accountTypeText}";
        }
        public void UpdateDisplayedBalance(double newBalance)
        {
            accountBalanceLabel.Text = $"Account Balance: ${newBalance:F2}";
        }
        private void makeTransferButton_Click_1(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(currentAccount, this);
            transferForm.ShowDialog();
        }
        private List<TransferInfo> GetTransferHistory(IAccount account)
        {
            string serverName = "DESKTOP-K1A5G55\\SQLEXPRESS";
            string databaseName = "QBankingSystemDB";

            string connectionString = $"Server={serverName};Database={databaseName};Integrated Security=True;";

            List<TransferInfo> transferHistory = new List<TransferInfo>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Source, Target, Amount, Title, TransferDate, Status FROM Transfers WHERE Source = @AccountNumber OR Target = @AccountNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", account.GetAccountNumber());

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransferInfo transfer = new TransferInfo(
                                    reader["Source"].ToString(),
                                    reader["Target"].ToString(),
                                    Convert.ToDecimal(reader["Amount"]),
                                    reader["Title"].ToString(),
                                    Convert.ToDateTime(reader["TransferDate"]),
                                    Convert.ToBoolean(reader["Status"])
                                );

                                transferHistory.Add(transfer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching transfer history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return transferHistory;
        }
        private void GTHbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var transferHistory = GetTransferHistory(currentAccount);

                StringBuilder csvContent = new StringBuilder();
                csvContent.AppendLine("Source, Target, Amount, Title, TransferDate, Status");

                foreach (var transfer in transferHistory)
                {
                    string csvLine = $"{transfer.Source}, {transfer.Target}, {transfer.Amount:F2}, {transfer.Title}, {transfer.TransferDate}, {transfer.Status}";
                    csvContent.AppendLine(csvLine);
                }

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "TransferHistory.csv");

                File.WriteAllText(filePath, csvContent.ToString());

                MessageBox.Show($"CSV file generated successfully: {filePath}", "CSV Generation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating CSV: {ex.Message}", "CSV Generation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadTransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string[] lines = File.ReadAllLines(filePath);
                    List<TransferInfo> transfersToExecute = new List<TransferInfo>();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i];
                        string[] values = line.Split(',');
                        if (values.Length == 6)
                        {
                            string source = values[0].Trim();
                            string target = values[1].Trim();
                            if (source == currentAccount.GetAccountNumber())
                            {
                                decimal amount = decimal.Parse(values[2].Trim(), new CultureInfo("de-DE"));
                                string title = values[3].Trim();
                                DateTime transferDate = DateTime.Parse(values[4].Trim());
                                bool status = bool.Parse(values[5].Trim());

                                TransferInfo transfer = new TransferInfo(source, target, amount, title, transferDate, status);
                                transfersToExecute.Add(transfer);
                            }
                            else
                            {
                                MessageBox.Show($"Invalid source account in line {i + 1}. Transfer skipped.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Invalid format in line {i + 1}. Transfer skipped.", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    int successfulTransfersCount = 0;
                    int failedTransfersCount = 0;

                    foreach (var transfer in transfersToExecute)
                    {
                        string sourceAccountNumber = transfer.Source;
                        string targetAccount = transfer.Target;
                        decimal amount = transfer.Amount;
                        string transferTitle = transfer.Title;

                        ITransfer transferType;
                        if (transfer.Status)
                        {
                            transferType = new FastTransfer();
                        }
                        else
                        {
                            transferType = new SlowTransfer();
                        }

                        string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
                        string insertQuery = "INSERT INTO Transfers (Source, Target, Amount, Title, TransferDate, Status) VALUES (@Source, @Target, @Amount, @Title, @TransferDate, @Status)";
                        SqlParameter[] parameters =
                        {
                            new SqlParameter("@Source", sourceAccountNumber),
                            new SqlParameter("@Target", targetAccount),
                            new SqlParameter("@Amount", amount),
                            new SqlParameter("@Title", transferTitle),
                            new SqlParameter("@TransferDate", DateTime.Now),
                            new SqlParameter("@Status", transfer.Status),
                         };

                        TransferResult result = transferType.ExecuteTransfer(connectionString, insertQuery, parameters);

                        if (result.IsSuccessful)
                        {
                            currentAccount.SetBalance(currentAccount.GetBalance() - (double)amount);
                            UpdateDisplayedBalance(currentAccount.GetBalance());
                            successfulTransfersCount++;
                        }
                        else
                        {
                            failedTransfersCount++;
                        }
                    }
                    MessageBox.Show($"Transfers loaded and executed successfully. Successful transfers: {successfulTransfersCount}, Failed transfers: {failedTransfersCount}", "Transfer Execution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading and executing transfers: {ex.Message}", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TakeLoan_Click(object sender, EventArgs e)
        {
            LoanForm Loanform = new LoanForm(currentAccount, this);
            Loanform.ShowDialog();
        }
    }
}
