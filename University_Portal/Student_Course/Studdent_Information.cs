using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Student_Course
{
    public partial class Student_Information : Form
    {
        public static string database = @"D:\C#\University_Portal\database.txt";
        public static DataTable studentinfo = new DataTable();
        public static bool stutracker  = false;
        public Student_Information()
        {
            InitializeComponent();
        }

        private void ShowStudent()
        {
            if (studentinfo.Columns.Count == 0)
            {
                
               
                studentinfo.Columns.Add("Student Name");
                studentinfo.Columns.Add("Student ID");
                studentinfo.Columns.Add("Student Number");
                studentinfo.Columns.Add("Student Email");
                studentinfo.Columns.Add("Student Gender");

                
            }




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
                if (stutracker)
                {
                    return;
                }
                string[] lines = File.ReadAllLines(database);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');

                    
                    if (parts.Length == 6)
                    {
                        studentinfo.Rows.Add(
                            parts[0].Trim(), // Student No
                                             // Student Name
                            parts[2].Trim(), // Student ID
                            parts[3].Trim(), // Student Email
                            parts[4].Trim(), // Student Gender
                            parts[5].Trim()  // Course
                        );
                       
                    }
                }
                stutracker = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back2_Click(object sender, EventArgs e)
        {
            
            Admin_Portal A = new Admin_Portal();    
            A.Show();
            this.Hide();
        }

        private void Student_Information_Load(object sender, EventArgs e)
        {
            ShowStudent();
            Getdata();
            studentview.DataSource = studentinfo;
        }

        private void Student_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
