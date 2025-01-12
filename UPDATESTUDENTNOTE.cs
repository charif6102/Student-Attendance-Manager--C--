using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_management
{
    public partial class UPDATESTUDENTNOTE : Form
    {
        private string connectionString = @"Data Source=DESKTOP-E5OF3R7;Initial Catalog=student_management;Integrated Security=True";

        public UPDATESTUDENTNOTE()
        {
            InitializeComponent();
            PopulateStudentBox();
            studentBox.SelectedIndexChanged += studentBox_SelectedIndexChanged;
        }

        private void PopulateStudentBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT first_name, last_name FROM student";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            studentBox.Items.Clear();
                            while (reader.Read())
                            {
                                string fullName = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                                studentBox.Items.Add(fullName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentBox.SelectedItem != null)
            {
                string selectedStudentFullName = studentBox.SelectedItem.ToString();
                string[] names = selectedStudentFullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM student WHERE first_name = @firstName AND last_name = @lastName";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@firstName", firstName);
                            command.Parameters.AddWithValue("@lastName", lastName);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    firstnamebox.Text = reader["first_name"].ToString();
                                    lastnamebox.Text = reader["last_name"].ToString();
                                    OOPnote.Text = reader["oop_note"].ToString();
                                    IntInfoSystemsnot.Text = reader["int_information_systems_note"].ToString();
                                    IntDatabasenote.Text = reader["int_database_note"].ToString();
                                    IntCompNetworknote.Text = reader["int_computer_networks_note"].ToString();
                                    GraphTheornote.Text = reader["graph_theory_note"].ToString();
                                    LanguageTheorynote.Text = reader["language_theory_note"].ToString();
                                    Englishnote.Text = reader["english_note"].ToString();
                                    projectnote.Text = reader["project_note"].ToString();
                                    gradebox.Text = reader["gradeValue"].ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (studentBox.SelectedItem != null)
            {
                string selectedStudentFullName = studentBox.SelectedItem.ToString();
                string[] names = selectedStudentFullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM student WHERE first_name = @firstName AND last_name = @lastName";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@firstName", firstName);
                            command.Parameters.AddWithValue("@lastName", lastName);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                studentBox.Items.Remove(selectedStudentFullName);
                                ClearTextBoxes();
                                MessageBox.Show("Student deleted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("No student found with the selected name.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void ClearTextBoxes()
        {
            firstnamebox.Text = string.Empty;
            lastnamebox.Text = string.Empty;
            OOPnote.Text = string.Empty;
            IntInfoSystemsnot.Text = string.Empty;
            IntDatabasenote.Text = string.Empty;
            IntCompNetworknote.Text = string.Empty;
            GraphTheornote.Text = string.Empty;
            LanguageTheorynote.Text = string.Empty;
            Englishnote.Text = string.Empty;
            projectnote.Text = string.Empty;
            gradebox.Text = string.Empty;
        }

        private void updatenote_Click(object sender, EventArgs e)
        {
            if (studentBox.SelectedItem != null)
            {
                string selectedStudentFullName = studentBox.SelectedItem.ToString();
                string[] names = selectedStudentFullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                // Parse and validate numeric values
                if (decimal.TryParse(OOPnote.Text, out decimal oopNote) &&
                    decimal.TryParse(IntInfoSystemsnot.Text, out decimal intInfoSystemsNote) &&
                    decimal.TryParse(IntDatabasenote.Text, out decimal intDatabaseNote) &&
                    decimal.TryParse(IntCompNetworknote.Text, out decimal intCompNetworksNote) &&
                    decimal.TryParse(GraphTheornote.Text, out decimal graphTheoryNote) &&
                    decimal.TryParse(LanguageTheorynote.Text, out decimal languageTheoryNote) &&
                    decimal.TryParse(Englishnote.Text, out decimal englishNote) &&
                    decimal.TryParse(projectnote.Text, out decimal projectNote))
                {
                    // Check if all values are within the range 0 to 20
                    if (IsValidRange(oopNote) &&
                        IsValidRange(intInfoSystemsNote) &&
                        IsValidRange(intDatabaseNote) &&
                        IsValidRange(intCompNetworksNote) &&
                        IsValidRange(graphTheoryNote) &&
                        IsValidRange(languageTheoryNote) &&
                        IsValidRange(englishNote) &&
                        IsValidRange(projectNote))
                    {
                        // Calculate the grade value
                        decimal gradeValue = ((englishNote * 1) +
                                             (languageTheoryNote * 3) +
                                             (graphTheoryNote * 3) +
                                             (intCompNetworksNote * 5) +
                                             (intDatabaseNote * 3) +
                                             (intInfoSystemsNote * 3) +
                                             (oopNote * 6) +
                                             (projectNote * 6)) / 30;

                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string query = "UPDATE student SET " +
                                               "oop_note = @oopNote, " +
                                               "int_information_systems_note = @intInfoSystemsNote, " +
                                               "int_database_note = @intDatabaseNote, " +
                                               "int_computer_networks_note = @intCompNetworksNote, " +
                                               "graph_theory_note = @graphTheoryNote, " +
                                               "language_theory_note = @languageTheoryNote, " +
                                               "english_note = @englishNote, " +
                                               "project_note = @projectNote, " +
                                               "gradeValue = @gradeValue " +
                                               "WHERE first_name = @firstName AND last_name = @lastName";

                                using (SqlCommand command = new SqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@oopNote", oopNote);
                                    command.Parameters.AddWithValue("@intInfoSystemsNote", intInfoSystemsNote);
                                    command.Parameters.AddWithValue("@intDatabaseNote", intDatabaseNote);
                                    command.Parameters.AddWithValue("@intCompNetworksNote", intCompNetworksNote);
                                    command.Parameters.AddWithValue("@graphTheoryNote", graphTheoryNote);
                                    command.Parameters.AddWithValue("@languageTheoryNote", languageTheoryNote);
                                    command.Parameters.AddWithValue("@englishNote", englishNote);
                                    command.Parameters.AddWithValue("@projectNote", projectNote);
                                    command.Parameters.AddWithValue("@gradeValue", gradeValue);
                                    command.Parameters.AddWithValue("@firstName", firstName);
                                    command.Parameters.AddWithValue("@lastName", lastName);

                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Update the gradebox with the new grade value
                                        gradebox.Text = gradeValue.ToString("F2");

                                        MessageBox.Show("Student notes updated successfully!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No student found with the selected name.");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter notes between 0 and 20.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid numeric values for the notes.");
                }
            }
            else
            {
                MessageBox.Show("Please select a student to update.");
            }
        }

        // Helper method to check if a value is within the range 0 to 20
        private bool IsValidRange(decimal value)
        {
            return value >= 0 && value <= 20;
        }
    }
}

