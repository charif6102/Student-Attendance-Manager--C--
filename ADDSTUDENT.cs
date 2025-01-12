using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_management
{
    public partial class ADDSTUDENT : Form
    {
        // Connection string for your SQL Server database
        private string connectionString = @"Data Source=DESKTOP-E5OF3R7;Initial Catalog=student_management;Integrated Security=True";

        public ADDSTUDENT()
        {
            InitializeComponent();
        }

        private void AddStudentbtn_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(firstnamebox.Text) ||
                string.IsNullOrWhiteSpace(lastnamebox.Text) ||
                string.IsNullOrWhiteSpace(OOPnote.Text) ||
                string.IsNullOrWhiteSpace(IntInfoSystemsnot.Text) ||
                string.IsNullOrWhiteSpace(IntDatabasenote.Text) ||
                string.IsNullOrWhiteSpace(IntCompNetworknote.Text) ||
                string.IsNullOrWhiteSpace(GraphTheornote.Text) ||
                string.IsNullOrWhiteSpace(LanguageTheorynote.Text) ||
                string.IsNullOrWhiteSpace(Englishnote.Text) ||
                string.IsNullOrWhiteSpace(projectnote.Text)) // Check project note box
            {
                MessageBox.Show("Please fill in all the text boxes.");
                return; // Exit the method
            }

            // Validate that the notes are between 0 and 20
            if (!IsValidGrade(OOPnote.Text) ||
                !IsValidGrade(IntInfoSystemsnot.Text) ||
                !IsValidGrade(IntDatabasenote.Text) ||
                !IsValidGrade(IntCompNetworknote.Text) ||
                !IsValidGrade(GraphTheornote.Text) ||
                !IsValidGrade(LanguageTheorynote.Text) ||
                !IsValidGrade(Englishnote.Text) ||
                !IsValidGrade(projectnote.Text)) // Validate project note
            {
                MessageBox.Show("Please enter valid notes between 0 and 20.");
                return; // Exit the method
            }

            // Get values from text boxes
            string firstName = firstnamebox.Text;
            string lastName = lastnamebox.Text;
            string oopNote = OOPnote.Text;
            string intInformationSystemsNote = IntInfoSystemsnot.Text;
            string intDatabaseNote = IntDatabasenote.Text;
            string intComputerNetworksNote = IntCompNetworknote.Text;
            string graphTheoryNote = GraphTheornote.Text;
            string languageTheoryNote = LanguageTheorynote.Text;
            string englishNote = Englishnote.Text;
            string projectNote = projectnote.Text; // Get project note

            try
            {
                // Calculate the grade value
                double gradeValue = ((Convert.ToDouble(englishNote) * 1) +
                                     (Convert.ToDouble(languageTheoryNote) * 3) +
                                     (Convert.ToDouble(graphTheoryNote) * 3) +
                                     (Convert.ToDouble(intComputerNetworksNote) * 5) +
                                     (Convert.ToDouble(intDatabaseNote) * 3) +
                                     (Convert.ToDouble(intInformationSystemsNote) * 3) +
                                     (Convert.ToDouble(oopNote) * 6) +
                                     (Convert.ToDouble(projectNote) * 6)) / 30; // Add project note calculation

                // Establish connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open connection
                    connection.Open();

                    // Create SQL INSERT query
                    string query = "INSERT INTO Student (first_name, last_name, OOP_Note, Int_Information_Systems_Note, " +
                                   "Int_Database_Note, Int_Computer_Networks_Note, Graph_Theory_Note, Language_Theory_Note, " +
                                   "English_Note, project_note, gradeValue) " + // Add project_note to the query
                                   "VALUES (@first_name, @last_name, @OOPNote, @IntInformationSystemsNote, @IntDatabaseNote, " +
                                   "@IntComputerNetworksNote, @GraphTheoryNote, @LanguageTheoryNote, @EnglishNote, @ProjectNote, @gradeValue)";

                    // Create SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the query
                        command.Parameters.AddWithValue("@first_name", firstName);
                        command.Parameters.AddWithValue("@last_name", lastName);
                        command.Parameters.AddWithValue("@OOPNote", oopNote);
                        command.Parameters.AddWithValue("@IntInformationSystemsNote", intInformationSystemsNote);
                        command.Parameters.AddWithValue("@IntDatabaseNote", intDatabaseNote);
                        command.Parameters.AddWithValue("@IntComputerNetworksNote", intComputerNetworksNote);
                        command.Parameters.AddWithValue("@GraphTheoryNote", graphTheoryNote);
                        command.Parameters.AddWithValue("@LanguageTheoryNote", languageTheoryNote);
                        command.Parameters.AddWithValue("@EnglishNote", englishNote);
                        command.Parameters.AddWithValue("@ProjectNote", projectNote); // Add projectNote parameter
                        command.Parameters.AddWithValue("@gradeValue", gradeValue); // Add gradeValue parameter

                        // Execute the query
                        command.ExecuteNonQuery();

                        // Set the calculated grade value to the gradebox
                        gradebox.Text = gradeValue.ToString();

                        // Inform the user that the student has been added
                        MessageBox.Show("Student added successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Function to validate grade input
        private bool IsValidGrade(string grade)
        {
            if (int.TryParse(grade, out int result))
            {
                return result >= 0 && result <= 20;
            }
            return false;
        }
    }
}
