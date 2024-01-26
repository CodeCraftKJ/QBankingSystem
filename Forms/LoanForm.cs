using QBankingSystem.Models;
using QBankingSystem.Models.Transfers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QBankingSystem.Forms
{
    public partial class LoanForm : Form
    {
        private readonly IAccount account;
        private readonly string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
        IAccount sourceAccount;
        BaseAccountForm baseAccountForm;

        public LoanForm(IAccount account, BaseAccountForm baseForm)
        {
            InitializeComponent();
            sourceAccount = account;
            baseAccountForm = baseForm;

            loanAmountTextBox.TextChanged += CalculateProposedInterest;
            loanTermTextBox.TextChanged += CalculateProposedInterest;
            interestRateTextBox.TextChanged += CalculateProposedInterest;
        }

        private void CalculateProposedInterest(object sender, EventArgs e)
        {
            if (double.TryParse(loanAmountTextBox.Text, out double loanAmount) &&
                int.TryParse(loanTermTextBox.Text, out int loanTerm) &&
                double.TryParse(interestRateTextBox.Text, out double interestRate))
            {
                double proposedInterest = (loanAmount * interestRate * loanTerm) / 1200.0;

                proposedInterestLabel.Text = "Proposed Interest: $" + proposedInterest.ToString("0.00");
            }
        }

        private void takeLoanButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(loanAmountTextBox.Text, out decimal loanAmount) &&
                int.TryParse(loanTermTextBox.Text, out int loanTerm) &&
                decimal.TryParse(interestRateTextBox.Text, out decimal interestRate))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    FastTransfer fastTransfer = new FastTransfer();

                    TransferResult transferResult = fastTransfer.ExecuteTransfer(
                        connectionString,
                        "INSERT INTO Transfers (Source, Target, Amount, Title, TransferDate, Status) " +
                        "VALUES (@Source, @Target, @Amount, @Title, @TransferDate, @Status)",
                        new SqlParameter[]
                        {
                    new SqlParameter("@Source", "000000000"),
                    new SqlParameter("@Target", account.GetAccountNumber()),
                    new SqlParameter("@Amount", loanAmount),
                    new SqlParameter("@Title", "Loan"),
                    new SqlParameter("@TransferDate", DateTime.Now),
                    new SqlParameter("@Status", 1) 
                        });

                    if (transferResult.IsSuccessful)
                    {
                        string insertQuery = "INSERT INTO Loans (AccountNumber, LoanAmount, LoanTerm, InterestRate) " +
                            "VALUES (@AccountNumber, @LoanAmount, @LoanTerm, @InterestRate)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@AccountNumber", account.GetAccountNumber());
                            cmd.Parameters.AddWithValue("@LoanAmount", loanAmount);
                            cmd.Parameters.AddWithValue("@LoanTerm", loanTerm);
                            cmd.Parameters.AddWithValue("@InterestRate", interestRate);

                            cmd.ExecuteNonQuery();
                        }

                        sourceAccount.SetBalance(sourceAccount.GetBalance() + (double)loanAmount);
                        baseAccountForm.UpdateDisplayedBalance(sourceAccount.GetBalance());

                        MessageBox.Show("Loan successful", "Loan Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(transferResult.Message, "Loan Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
