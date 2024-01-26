using QBankingSystem.Forms;
using QBankingSystem.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QBankingSystem
{
    public partial class UserAccountForm : Form
    {
        public UserAccountForm()
        {
            InitializeComponent();
            LoadUserData();
            DisplayUserData();
            LoadUserAccounts();
            lstAccounts.DoubleClick += lstAccounts_DoubleClick;
        }

        private void LoadUserData()
        {
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT UserID, Name, Surname, Phone, Email, PESEL FROM Users WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", CurUser.Username);
                    command.Parameters.AddWithValue("@Password", CurUser.Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CurUser.UserID = Convert.ToInt32(reader["UserID"]);
                            CurUser.Name = reader["Name"].ToString();
                            CurUser.Surname = reader["Surname"].ToString();
                            CurUser.Phone = reader["Phone"].ToString();
                            CurUser.Email = reader["Email"].ToString();
                            CurUser.PESEL = reader["PESEL"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User not found or password is incorrect.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                }
            }
        }
        private void DisplayUserData()
        {
            labName.Text = "Name: " + CurUser.Name;
            labSurname.Text = "Surname: " + CurUser.Surname;
            labPESEL.Text = "PESEL: " + CurUser.PESEL;
        }
        private void LoadUserAccounts()
        {
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM BankAccount WHERE OwnerPESEL = @PESEL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PESEL", CurUser.PESEL);
                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                        lstAccounts.DataSource = dataTable;
                        lstAccounts.DisplayMember = "AccountNumber";
                        lstAccounts.ValueMember = "AccountID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GenerateAccountNumber(string accountTypePrefix)
        {
            int length = 15;
            string characters = "0123456789";
            Random random = new Random();
            return accountTypePrefix + new string(Enumerable.Repeat(characters, length - accountTypePrefix.Length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountType = cmbAccountType.SelectedItem.ToString();
            string accountTypePrefix = "";

            switch (accountType)
            {
                case "Business Account":
                    accountTypePrefix = "BUS";
                    break;
                case "Checking Account":
                    accountTypePrefix = "CHK";
                    break;
                case "Currency Account":
                    accountTypePrefix = "CUR";
                    break;
                case "Personal Account":
                    accountTypePrefix = "PER";
                    break;
                case "Savings Account":
                    accountTypePrefix = "SAV";
                    break;
                default:
                    break;
            }

            string accountNumber = GenerateAccountNumber(accountTypePrefix);
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO BankAccount (AccountNumber, OwnerPESEL, Balance, AccountType) VALUES (@AccountNumber, @OwnerPESEL, 0.00, @AccountType)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        command.Parameters.AddWithValue("@OwnerPESEL", CurUser.PESEL);
                        command.Parameters.AddWithValue("@AccountType", accountType);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New account created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create a new account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadUserAccounts();
            }
        }


        private void lstAccounts_DoubleClick(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedItem != null)
            {
                string selectedAccountNumber = lstAccounts.GetItemText(lstAccounts.SelectedItem);

                IAccount selectedAccount = DownloadAccountInfoFromServer(selectedAccountNumber);

                if (selectedAccount != null)
                {
                    BaseAccountForm baseAccountForm = new BaseAccountForm(selectedAccount);
                    baseAccountForm.ShowDialog();
                }
            }
        }

        private IAccount DownloadAccountInfoFromServer(string accountNumber)
        {
            try
            {
                string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT AccountType, Balance FROM BankAccount WHERE AccountNumber = @AccountNumber";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string accountType = reader["AccountType"].ToString();
                                double balance = Convert.ToDouble(reader["Balance"]);
                                IAccount selectedAccount = null;

                                switch (accountType)
                                {
                                    case "Business Account":
                                        selectedAccount = new BusinessAccount(accountNumber);
                                        break;
                                    case "Checking Account":
                                        selectedAccount = new CheckingAccount(accountNumber);
                                        break;
                                    case "Currency Account":
                                        selectedAccount = new CurrencyAccount(accountNumber);
                                        break;
                                    case "Personal Account":
                                        selectedAccount = new PersonalAccount(accountNumber);
                                        break;
                                    case "Savings Account":
                                        selectedAccount = new SavingsAccount(accountNumber);
                                        break;
                                    default:
                                        break;
                                }

                                if (selectedAccount != null)
                                {
                                    selectedAccount.SetBalance(balance);
                                }

                                return selectedAccount;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error downloading account information: " + ex.Message);
                return null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserAccounts();
        }
    }
}