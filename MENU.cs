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
    public partial class MENU : Form
    {
       
        public MENU()
        {
            InitializeComponent();
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void ModifyStudentbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void addStudentBtn_Click_1(object sender, EventArgs e)
        {
            ADDSTUDENT form3 = new ADDSTUDENT();
            form3.Show();
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            SCHEDULE form6 = new SCHEDULE();
            form6.Show();
        }

        private void modifyStudentBtn_Click_1(object sender, EventArgs e)
        {
            UPDATESTUDENTNOTE form4 = new UPDATESTUDENTNOTE();
            form4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            markpresence form1 = new markpresence();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultpresence form2 = new consultpresence();
            form2.Show();
        }
    }
}
