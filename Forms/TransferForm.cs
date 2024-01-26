using QBankingSystem.Models;
using QBankingSystem.Models.Transfers;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QBankingSystem.Forms
{
    public partial class TransferForm : Form
    {
        private IAccount sourceAccount;
        private BaseAccountForm baseAccountForm;
        private bool isFastTransfer = false;

        public TransferForm(IAccount source, BaseAccountForm baseForm)
        {
            InitializeComponent();

            sourceAccount = source;
            baseAccountForm = baseForm;

            string pesel = CurUser.PESEL;
            string username = CurUser.Username;

            string firstName = CurUser.Name;
            string lastName = CurUser.Surname;
            string sourceAccountNumber = sourceAccount.GetAccountNumber();

            peselTextBox.Text = pesel;
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            sourceAccountTextBox.Text = sourceAccountNumber;
            usernameTextBox.Text = username;
            sourceAccountTextBox.ReadOnly = true;
        }

        private void FastTransferButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FastTransferButton.Checked)
            {
                isFastTransfer = true;
            }
            else
            {
                isFastTransfer = false;
            }
        }

        private void confirmTransferButton_Click(object sender, EventArgs e)
        {
            string sourceAccountNumber = sourceAccountTextBox.Text;
            string targetAccount = targetAccountTextBox.Text;
            string amountText = amountTextBox.Text;
            string transferTitle = transferTitleTextBox.Text;

            decimal amount;
            if (decimal.TryParse(amountText, out amount) && amount>=0)
            {
                ITransfer transferType;
                if (isFastTransfer)
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
                        new SqlParameter("@Status", isFastTransfer)
                 };

                TransferResult result = transferType.ExecuteTransfer(connectionString, insertQuery, parameters);

                if (result.IsSuccessful)
                {
                    MessageBox.Show(result.Message, "Transfer Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sourceAccount.SetBalance(sourceAccount.GetBalance() - (double)amount);
                    baseAccountForm.UpdateDisplayedBalance(sourceAccount.GetBalance());
                }
                else
                {
                    MessageBox.Show(result.Message, "Transfer Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid amount entered. Please enter a valid decimal number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
