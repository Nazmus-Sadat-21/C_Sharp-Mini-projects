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
    public partial class Course_Information : Form
    {
        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public static DataTable showcourse  = new DataTable();  
        public static bool coursetraker = false;
        public Course_Information()
        {
            InitializeComponent();
        }

        private void AvailableCourse()
        {
            if (showcourse.Columns.Count == 0)
            {
                showcourse.Columns.Add("Course No", typeof(int));
                showcourse.Columns.Add("Course Name");
                showcourse.Columns.Add("Section");
                showcourse.Columns.Add("Course Credit", typeof(int));

                showcourse.Rows.Add(1, "INTRODUCTION TO PROGRAMMING","A", 3);
                showcourse.Rows.Add(2, "OBJECT ORIENTED PROGRAMMING 1 (JAVA)","F", 3);
                showcourse.Rows.Add(3, "DATA STRUCTURE", "K", 3);
                showcourse.Rows.Add(4, "NTRODUCTION TO DATABASE","O", 3);
                showcourse.Rows.Add(5, "ALGORITHMS","H", 3);
                showcourse.Rows.Add(6, "OBJECT ORIENTED PROGRAMMING 2 (C#)", "G", 3);
                showcourse.Rows.Add(7, "OBJECT ORIENTED ANALYSIS AND DESIGN","KK", 3);
                showcourse.Rows.Add(8, "ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM", "Y", 3);
                showcourse.Rows.Add(9, "SOFTWARE ENGINEERING", "M", 3);
                showcourse.Rows.Add(10, "COMPILER DESIGN", "P", 3);
                showcourse.Rows.Add(11, "THEORY OF COMPUTATION", "T",3);
                showcourse.Rows.Add(12, "COMPUTER NETWORKS", "R", 3);
                showcourse.Rows.Add(13, "OPERATING SYSTEM", "Z", 3);
                showcourse.Rows.Add(14, "COMPUTER GRAPHICS", "L", 3);
                showcourse.Rows.Add(15, "MICROPROCESSOR AND EMBEDDED SYSTEMS", "U", 3);
                showcourse.Rows.Add(16, "DATA STRUCTURE LAB", "EE", 1);
                showcourse.Rows.Add(17, "COMPUTER AIDED DESIGN & DRAFTING", "N", 1);
                showcourse.Rows.Add(18, "PRINCIPLES OF ECONOMICS", "SS", 2);
                showcourse.Rows.Add(19, "ALGORITHM LAB", "B", 1);
                showcourse.Rows.Add(20, "INTRODUCTION TO PROGRAMMING LAB", "C", 1);
            }
        }

        private void Addcourse()
        {

            if (coursetraker)
            {
                courseview4.DataSource = showcourse;
                return;
            }
            AvailableCourse();

                //DataTable randomTable = showcourse.Clone();
                Random rnd = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    int index = rnd.Next(showcourse.Rows.Count);
            //    randomTable.ImportRow(showcourse.Rows[index]);
            //}

            // Shuffle the rows and take 5 unique rows
                DataTable randomTable = showcourse.AsEnumerable()
                                              .OrderBy(r => Guid.NewGuid()) // random order
                                              .Take(5)                     // take first 5 rows
                                              .CopyToDataTable();           // convert back to DataTabl



                courseview4.DataSource = randomTable;
                courseview4.ReadOnly = true;
                courseview4.Columns["Course No"].Width = 80;
                //courseview.Columns["Course Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                courseview4.Columns["Course Name"].Width = 150;
                courseview4.Columns["Section"].Width = 100;
                courseview4.Columns["Course Credit"].Width = 100;

                showcourse = randomTable;
                coursetraker = true;


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
                string[] lines = File.ReadAllLines(facultydatabase);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');


                    if (parts.Length == 6 && parts[1] == Form1.password && parts[2] == Form1.id)
                    {
                        n1.Text = parts[0];
                        i1.Text = parts[2];
                        c1.Text = "5";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Course_Information_Load(object sender, EventArgs e)
        {
            
            Getdata();
            AvailableCourse();
            Addcourse();
           

        }

        private void back2_Click(object sender, EventArgs e)
        {
            
            Faculty_Portal f = new Faculty_Portal();
            f.Show();
            this.Hide();
        }

        private void Course_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        
    }
}
