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
    public partial class Faculty_Information : Form
    {
        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public static DataTable facultyinfo = new DataTable();
        public static bool factracker = false;
        public Faculty_Information()
        {
            InitializeComponent();
        }

        private void Faculty_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       


        private void Getdata()
        {
            if (!File.Exists(facultydatabase))
            {
                MessageBox.Show("Error! Database not found.");
                return;
            }

            try
            {
                if (factracker)
                {
                    return;
                }
                string[] lines = File.ReadAllLines(facultydatabase);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');


                    if (parts.Length == 6)
                    {
                        facultyinfo.Rows.Add(
                            parts[0].Trim(), // Student No                                           
                            parts[2].Trim(), // Student ID
                            parts[3].Trim(), // Student Email
                            parts[4].Trim(), // Student Gender
                            parts[5].Trim()  // Course
                        );
                    }
                }
                factracker = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Showfaculty()
        {

            if (facultyinfo.Columns.Count==0)
            {

                facultyinfo.Columns.Add("Faculty Name");
                facultyinfo.Columns.Add("Faculty ID");
                facultyinfo.Columns.Add("Faculty Number");
                facultyinfo.Columns.Add("Faculty Email");
                facultyinfo.Columns.Add("Faculty Gender");
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Portal a = new Admin_Portal();
            a.Show();
            this.Hide();
        }

        private void Faculty_Information_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Faculty_Information_Load(object sender, EventArgs e)
        {
            Showfaculty();
            Getdata();
            facultyview1.DataSource = facultyinfo;
        }
    }
}
