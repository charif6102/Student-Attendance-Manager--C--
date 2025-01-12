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
    public partial class markpresence : Form
    {
        // Connection string to your SQL Server database
        private string connectionString = @"Data Source=DESKTOP-E5OF3R7;Initial Catalog=student_management;Integrated Security=True";

        public markpresence()
        {
            InitializeComponent();
            PopulateStudentBox();
        }

        private void PopulateStudentBox()
        {
            try
            {
                // Open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select all students from grp5
                    string query = "SELECT first_name, last_name FROM student";

                    // Create a SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the SQL query and get a SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in studentBox
                            studentBox.Items.Clear();

                            // Iterate through the result set
                            while (reader.Read())
                            {
                                // Concatenate firstname and lastname and add to studentBox
                                string fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                studentBox.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void prsentbtn_Click(object sender, EventArgs e)
        {
           
        }


        private void absentbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Check if a class number is selected
            if (classnumber.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a class number.");
                return;
            }

            // Get the class number entered by the user
            int classNumber;
            if (!int.TryParse(classnumber.Text, out classNumber))
            {
                MessageBox.Show("Please enter a valid class number.");
                return;
            }

            try
            {
                // Open a connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Iterate through the items in the Present box
                    foreach (string student in presnetBox.Items)
                    {
                        // Split the student name into first name and last name
                        string[] names = student.Split(' ');
                        string firstName = names[0];
                        string lastName = names[1];

                        // Insert the student into the PresentStudent table
                        string insertQuery = "INSERT INTO PresentStudent (first_name, last_name, NumberOfClasses) VALUES (@first_name, @last_name, @NumberOfClasses)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@first_name", firstName);
                            command.Parameters.AddWithValue("@last_name", lastName);
                            command.Parameters.AddWithValue("@NumberOfClasses", classNumber);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Iterate through the items in the Absent box
                    foreach (string student in absentBox.Items)
                    {
                        // Split the student name into first name and last name
                        string[] names = student.Split(' ');
                        string firstName = names[0];
                        string lastName = names[1];

                        // Insert the student into the AbsentStudent table
                        string insertQuery = "INSERT INTO AbsentStudent (first_name, last_name, NumberOfClasses) VALUES (@first_name, @last_name, @NumberOfClasses)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@first_name", firstName);
                            command.Parameters.AddWithValue("@last_name", lastName);
                            command.Parameters.AddWithValue("@NumberOfClasses", classNumber);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Check if all students have been selected
                    if (studentBox.Items.Count == 0)
                    {
                        // Proceed with saving the data
                        try
                        {
                            // Your existing code for saving data goes here

                            MessageBox.Show("Data saved successfully.");
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        // If studentBox is not empty, not all students have been selected
                        MessageBox.Show("Please select all students before saving.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void prsentbtn_Click_1(object sender, EventArgs e)
        {
            // Get the selected student from studentBox
            string selectedStudent = (string)studentBox.SelectedItem;

            // Check if a student is selected
            if (selectedStudent != null)
            {
                // Add the selected student to presentBox
                presnetBox.Items.Add(selectedStudent);

                // Remove the selected student from studentBox
                studentBox.Items.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to mark as present.");
            }
        }

        private void absentbtn_Click_1(object sender, EventArgs e)
        {
            // Get the selected student from studentBox
            string selectedStudent = (string)studentBox.SelectedItem;

            // Check if a student is selected
            if (selectedStudent != null)
            {
                // Add the selected student to absentBox
                absentBox.Items.Add(selectedStudent);

                // Remove the selected student from studentBox
                studentBox.Items.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to mark as absent.");
            }
        }
    }
}
