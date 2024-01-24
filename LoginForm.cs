using System;
using System.Windows.Forms;

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
            // Here, you'd typically validate the credentials against a database or other storage
            // For now, let's just check if the fields are not empty

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                // Display an error message if either field is empty
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // TODO: Validate credentials against a database or user repository
                bool isValidUser = ValidateUser(username, password);

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
        }

        private bool ValidateUser(string username, string password)
        {
            // TODO: Implement actual user validation logic here (e.g., check against a database)
            // For now, let's assume the credentials are valid
            return true;
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Open the form to reset the password or create a new account
            MessageBox.Show("Link to password reset or registration not implemented yet.", "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
