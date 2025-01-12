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
    public partial class consultpresence : Form
    {
        private string connectionString = @"Data Source=DESKTOP-E5OF3R7;Initial Catalog=student_management;Integrated Security=True";

        public consultpresence()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Clear existing items in the list boxes
            absentBox.Items.Clear();
            presnetBox.Items.Clear();

            // Get the selected class number from the combo box
            string selectedClassNumber = classnumber.SelectedItem?.ToString();

            // Check if a class number is selected
            if (!string.IsNullOrEmpty(selectedClassNumber))
            {
                // Retrieve absent students for the selected class number
                RetrieveAbsentStudents(selectedClassNumber);

                // Retrieve present students for the selected class number
                RetrievePresentStudents(selectedClassNumber);
            }
            else
            {
                MessageBox.Show("Please select a class number.");
            }
        }

        private void RetrieveAbsentStudents(string classNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to retrieve absent students for the selected class number
                    string query = "SELECT DISTINCT first_name, last_name FROM AbsentStudent WHERE NumberOfClasses = @classNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classNumber", classNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Concatenate firstname and lastname and add to absentBox
                                string fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                absentBox.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving absent students: " + ex.Message);
            }
        }

        private void RetrievePresentStudents(string classNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to retrieve present students for the selected class number
                    string query = "SELECT first_name, last_name FROM PresentStudent WHERE NumberOfClasses = @classNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classNumber", classNumber);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Concatenate firstname and lastname and add to presnetBox
                                string fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                presnetBox.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving present students: " + ex.Message);
            }
        }
    }
}
