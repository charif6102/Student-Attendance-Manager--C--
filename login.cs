using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class login : Form
    {

        // Connection string to your SQL Server database
        private string connectionString = @"Data Source=DESKTOP-UCCV4EB;Initial Catalog=student_management;Integrated Security=True";
        public login()
        {
            InitializeComponent();
            register.Click += register_Click;
            register.MouseEnter += register_MouseEnter;
            register.MouseLeave += register_MouseLeave;
            passwordbox.PasswordChar = '*';
            passwordvalidation.PasswordChar = '*';
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

        }

        private void RegisterUser()
        {
            // Get the entered username and password
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text;

            // Check if username and password are not empty
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Check if the passwords match
                if (password == passwordvalidation.Text)
                {
                    // Insert the username and password into the login table
                    InsertLoginCredentials(username, password);
                    MessageBox.Show("Registration successful!");
                    // Clear registration-related controls
                    passwordvalidation.Visible = false;
                    btnlogin.Text = "Login";
                    register.Visible = true;
                }
                else
                {
                    // Passwords don't match, display error message
                    MessageBox.Show("Passwords do not match. Please enter the same password in both fields.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void LoginUser()
        {
            // Get the entered username and password
            string username = usernamebox.Text.Trim();
            string password = passwordbox.Text;

            // Check if username and password are not empty
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Check if the credentials exist in the database
                if (CheckLogin(username, password))
                {
                    MessageBox.Show("Login successful!");
                    // Open Form1 if login is successful
                    MENU form2 = new MENU();
                    form2.Show();

                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void InsertLoginCredentials(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO login (username, password) VALUES (@username, @password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private bool CheckLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void register_MouseEnter(object sender, EventArgs e)
        {
            // Change the font style and color when the mouse enters
            register.Font = new Font(register.Font, FontStyle.Bold);
            register.ForeColor = Color.Black;
        }

        private void register_MouseLeave(object sender, EventArgs e)
        {
            // Change the font style and color back when the mouse leaves
            register.Font = new Font(register.Font, FontStyle.Regular);
            register.ForeColor = Color.Black;
        }

        private void register_Click(object sender, EventArgs e)
        {
            // Change the label text to "Create your"
            label3.Text = "Create your";
            // Hide the "Register" label
            register.Visible = false;
            // Show the password validation textbox and label
            passwordvalidation.Visible = true;
            // Change the login button text to "Register"
            btnlogin.Text = "Register";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (btnlogin.Text == "Register")
            {
                // Register button clicked
                RegisterUser();
            }
            else
            {
                // Login button clicked
                LoginUser();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
