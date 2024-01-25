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
                    command.Parameters.AddWithValue("@Username", User.Username);
                    command.Parameters.AddWithValue("@Password", User.Password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User.UserID = Convert.ToInt32(reader["UserID"]);
                            User.Name = reader["Name"].ToString();
                            User.Surname = reader["Surname"].ToString();
                            User.Phone = reader["Phone"].ToString();
                            User.Email = reader["Email"].ToString();
                            User.PESEL = reader["PESEL"].ToString();
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
            labName.Text = "Name: " + User.Name;
            labSurname.Text = "Surname: " + User.Surname;
            labPESEL.Text = "PESEL: " + User.PESEL;
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
                        command.Parameters.AddWithValue("@PESEL", User.PESEL);
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

        private string GenerateAccountNumber()
        {
            int length = 10;
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(characters, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = GenerateAccountNumber();
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO BankAccount (AccountNumber, OwnerPESEL, Balance) VALUES (@AccountNumber, @OwnerPESEL, 0.00)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        command.Parameters.AddWithValue("@OwnerPESEL", User.PESEL);
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

        private void button1_Click(object sender, EventArgs e)
        {
                LoadUserAccounts();
        }
    }
}
