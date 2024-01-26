using System;
using System.Windows.Forms;
namespace QBankingSystem.Forms
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();

            // Pre-fill user information into the form based on QBankingSystem.User properties
            string pesel = QBankingSystem.CurUser.PESEL; // Assuming PESEL is a property in the User class

            // You can fetch user information based on PESEL here and populate the form fields accordingly
            // Example:
            string firstName = QBankingSystem.CurUser.Name;
            string lastName = QBankingSystem.CurUser.Surname;
            string sourceAccount = QBankingSystem.CurUser.Username;

            peselTextBox.Text = pesel;
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            sourceAccountTextBox.Text = sourceAccount;

            // You can also set other default values or handle other logic here
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string pesel = peselTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string sourceAccount = sourceAccountTextBox.Text;
            string targetAccount = targetAccountTextBox.Text;
            decimal amount = decimal.Parse(amountTextBox.Text);
            string transferTitle = transferTitleTextBox.Text;

            // Perform the transfer logic here
            // You can access the fetched user information for additional details

            // Close the form
            this.Close();
        }

        private void confirmTransferButton_Click(object sender, EventArgs e)
        {

        }
    }
}
