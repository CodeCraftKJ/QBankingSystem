using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QBankingSystem
{

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PESEL { get; set; }
    }

    public partial class AccountForm : Form
    {

        private User currentUser; // Create a User object to store user data

        public AccountForm(string username, string password)
        {
            InitializeComponent();

            // Retrieve the user's data from the database based on username and password
            currentUser = GetUserFromDatabase(username, password);

            if (currentUser != null)
            {
                DisplayUserData(); // Call a method to display the user's data
                LoadUserAccounts(); // Call a method to load user accounts from the database
            }
            else
            {
                MessageBox.Show("User data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if user data is not found
            }
        }

        private User GetUserFromDatabase(string username, string password)
        {
            // Create a connection string for Windows Authentication
            string connectionString = "Server=DESKTOP-K1A5G55\\SQLEXPRESS;Database=QBankingSystemDB;Integrated Security=True;";

            // Create a SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Query to fetch user data based on username and password
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query and fetch the user data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a User object and populate it with data from the database
                                User user = new User
                                {
                                    Name = reader["Name"].ToString(),
                                    Surname = reader["Surname"].ToString(),
                                    PESEL = reader["PESEL"].ToString(),
                                };
                                return user;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during the database connection
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Return null if user data is not found
        }

        private void DisplayUserData()
        {
            // Display user data in labels
            labName.Text = "Name: " + currentUser.Name;
            labSurname.Text = "Surname: " + currentUser.Surname;
            labPESEL.Text = "PESEL: " + currentUser.PESEL;
        }

        private void LoadUserAccounts()
        {
            // Implement the code to load user accounts from the database here
            // Similar to the code you provided earlier
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // TODO: Implement logic to create a new account for the user
            // For now, let's assume we open a form to create a new account
            // You can create a new form for this purpose
            // Example: NewAccountForm newAccountForm = new NewAccountForm(currentUser.PESEL);
            // newAccountForm.Show();
        }
    }
}
