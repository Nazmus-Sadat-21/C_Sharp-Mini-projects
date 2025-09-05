using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Student_Course
{
    public partial class StudentPortal : Form
    {

        public static string database = @"D:\C#\University_Portal\database.txt";
        
        public StudentPortal()
        {
            InitializeComponent();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Course.Reset();
            Payment.Reset();
            courseresult.Reset();
            StudentInfo.Reset();
            Form1 f = new Form1("Student Portal");

            f.Show();
            this.Hide();
        }

        private void coursereg_Click(object sender, EventArgs e)
        {
            if (Payment.btntrack == true)
            {
                MessageBox.Show("Sorry! your registration is confrimed , you are not able to registration again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Course c = new Course();
                c.Show();
                this.Hide();
            }
        }

        private void reg_Click(object sender, EventArgs e)
        {
           if(Course.track2 == false)
            {
                MessageBox.Show("Please register your course first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }
        }

        private void studentInfo_Click(object sender, EventArgs e)
        {
            StudentInfo s = new StudentInfo();
            s.Show();
            this.Hide();
        }

        private void course_result_Click(object sender, EventArgs e)
        {
            if (Course.track2 == false)
            {
                MessageBox.Show("Please register your course first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Payment.btntrack==true) {

                courseresult c = new courseresult();
                c.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sorry you have to pay your tution fee first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            Getdata();
           
        }


        private void Getdata()
        {
            if (!File.Exists(database))
            {
                MessageBox.Show("Error! Database not found.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(database);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    
                    if (parts.Length == 6 && parts[1] == Form1.password && parts[2] == Form1.id)
                    {
                        heading.Text = $"Welcome {parts[0]}"; 
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentPortal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
