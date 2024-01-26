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

        private void makeTransferButton_Click_1(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.ShowDialog();
        }
    }
}
