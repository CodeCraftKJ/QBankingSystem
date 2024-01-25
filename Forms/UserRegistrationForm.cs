using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QBankingSystem
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
            txtUsername.Leave += (s, e) => ValidateUsername(txtUsername.Text);
            txtPassword.Leave += (s, e) => ValidatePassword(txtPassword.Text);
            txtConfirmPassword.Leave += (s, e) => ValidateConfirmPassword(txtPassword.Text, txtConfirmPassword.Text);
            txtName.Leave += (s, e) => ValidateName(txtName.Text);
            txtSurname.Leave += (s, e) => ValidateName(txtSurname.Text);
            txtEmail.Leave += (s, e) => ValidateEmail(txtEmail.Text);
            txtPhone.Leave += (s, e) => ValidatePhoneNumber(txtPhone.Text);
            textPESEL.Leave += (s, e) => ValidatePESEL(textPESEL.Text);
        }

        private bool ValidateUsername(string username)
        {
            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username must contain only letters and numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidatePassword(string password)
        {
            if (!Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,}$"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase letters, lowercase letters, and numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateConfirmPassword(string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidateName(string name)
        {
            if (!Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name must contain only letters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValidatePESEL(string PESEL)
        {
            if (!Regex.IsMatch(PESEL, @"^\d{11}$"))
            {
                MessageBox.Show("Pesel number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private bool ValidateEmail(string email)
        {
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string phoneNumber = txtPhone.Text;
            string email = txtEmail.Text;
            string pesel = textPESEL.Text;

            if (!(ValidateUsername(username) && ValidatePassword(password) &&
                ValidateConfirmPassword(password, confirmPassword) &&
                ValidateName(firstName) && ValidateName(lastName) &&
                ValidatePhoneNumber(phoneNumber) && ValidateEmail(email) && ValidatePESEL(pesel)))
            {
                return;
            }

            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";

            using SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if (UsernameExists(connection, username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InsertUser(connection, username, password, firstName, lastName, phoneNumber, email,pesel);
                MessageBox.Show("Registration successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserLoginForm LoginForm = new UserLoginForm();
                LoginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private static bool UsernameExists(SqlConnection connection, string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void InsertUser(SqlConnection connection, string username, string password, string name, string surname, string phone, string email, string pesel)
        {
            string query = "INSERT INTO Users (Username, Password, Name, Surname, Phone, Email, PESEL) VALUES (@Username, @Password, @Name, @Surname, @Phone, @Email, @PESEL)";


            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PESEL", pesel);

                command.ExecuteNonQuery();
            }
        }
    }
}