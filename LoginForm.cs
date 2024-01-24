using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QBankingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Create a connection string for Windows Authentication
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";

            // Create a SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Call the ValidateUser method to check credentials
                    bool isValidUser = ValidateUser(connection, username, password);

                    if (isValidUser)
                    {
                        // If the credentials are valid, show a success message and open the main dashboard
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // TODO: Open the main dashboard form and close the login form
                        AccountForm mainDashboard = new AccountForm();
                        mainDashboard.Show();
                        this.Hide(); // Hide the login form
                    }
                    else
                    {
                        // If the credentials are not valid, show an error message
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the database connection
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateUser(SqlConnection connection, string username, string password)
        {
            // Query the database to check if the username and password match
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                // Execute the query and check the result
                int count = (int)command.ExecuteScalar();

                return count > 0; // If count > 0, credentials are valid
            }
        }


        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Open the form to reset the password or create a new account
            MessageBox.Show("Link to password reset or registration not implemented yet.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
