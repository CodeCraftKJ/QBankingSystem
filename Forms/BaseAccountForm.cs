using System;
using System.Windows.Forms;
using QBankingSystem.Models;

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
            accountInfoLabel.Text = currentAccount.GetType().Name;
            accountBalanceLabel.Text = $"Account Balance: ${currentAccount.GetBalance():F2}";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out double amount))
            {
                currentAccount.Deposit(amount);
                DisplayAccountInfo();
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawalButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(amountTextBox.Text, out double amount))
            {
                try
                {
                    currentAccount.Withdraw(amount);
                    DisplayAccountInfo();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            // Implement transfer logic here
            // Example: currentAccount.TransferTo(otherAccount, amount);
        }
    }
}
