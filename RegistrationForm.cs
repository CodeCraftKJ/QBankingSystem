using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QBankingSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            txtUsername.Leave += (s, e) => ValidateUsername(txtUsername.Text);
            txtPassword.Leave += (s, e) => ValidatePassword(txtPassword.Text);
            txtConfirmPassword.Leave += (s, e) => ValidateConfirmPassword(txtPassword.Text, txtConfirmPassword.Text);
            txtName.Leave += (s, e) => ValidateName(txtName.Text);
            txtSurname.Leave += (s, e) => ValidateName(txtSurname.Text);
            txtEmail.Leave += (s, e) => ValidateEmail(txtEmail.Text);
            txtPhone.Leave += (s, e) => ValidatePhoneNumber(txtPhone.Text);
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
            // Check if the phone number is exactly 10 digits long
            if (!Regex.IsMatch(phoneNumber, @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Validate all fields before proceeding
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string firstName = txtName.Text;
            string lastName = txtSurname.Text;
            string phoneNumber = txtPhone.Text;
            string email = txtEmail.Text;

            // Check all fields for validation
            if (!(ValidateUsername(username) && ValidatePassword(password) &&
                ValidateConfirmPassword(password, confirmPassword) &&
                ValidateName(firstName) && ValidateName(lastName) &&
                ValidatePhoneNumber(phoneNumber) && ValidateEmail(email)))
            {
                // If any validation fails, stop the registration process
                return;
            }

            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";

            // Create a SqlConnection using the connection string
            using SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Open the database connection
                connection.Open();

                // Check if the username already exists in the database
                if (UsernameExists(connection, username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the new user into the Users table
                InsertUser(connection, username, password, firstName, lastName, phoneNumber, email);

                // Show a success message and close the registration form
                MessageBox.Show("Registration successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm LoginForm = new LoginForm();
                LoginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database connection or user insertion
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private static bool UsernameExists(SqlConnection connection, string username)
        {
            // Query the database to check if the username already exists
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void InsertUser(SqlConnection connection, string username, string password, string name, string surname, string phone, string email)
        {
            // The column names here must match the ones in your database table
            string query = "INSERT INTO Users (Username, Password, Name, Surname, Phone, Email) VALUES (@Username, @Password, @Name, @Surname, @Phone, @Email)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@Email", email);

                command.ExecuteNonQuery();
            }
        }
    }
}