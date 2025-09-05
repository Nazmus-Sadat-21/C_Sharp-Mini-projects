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
    public partial class Course : Form
    {

        public static string database = @"D:\C#\University_Portal\database.txt";
        public static int totalcr=0;
        public static bool track2 = false;
        public DataTable showcourse = new DataTable();
        public static DataTable selectcourse = new DataTable();
        public static DataTable viewcourse = new DataTable();
        private DataTable originalShowCourse = new DataTable();

        public Course()
        {
            InitializeComponent();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            //name1.Text = Form1.name;
            //id1.Text = Form1.id;

            Getdata();

            course();
            selectcourseview();

            originalShowCourse = showcourse.Copy();


            listBox1.DataSource = showcourse;
            listBox1.DisplayMember = "Course Name";

            listBox2.DataSource = selectcourse;           
            listBox2.DisplayMember = "Course Name";

           

        }

        private void course()
        {
            // Prevent duplicate column error
            if (showcourse.Columns.Count == 0)
            {
                showcourse.Columns.Add("Course No", typeof(int));
                showcourse.Columns.Add("Course Name");
                showcourse.Columns.Add("Section");
                showcourse.Columns.Add("Course Credit", typeof(int));

                showcourse.Rows.Add(1, "INTRODUCTION TO PROGRAMMING", "A", 3);
                showcourse.Rows.Add(2, "OBJECT ORIENTED PROGRAMMING 1 (JAVA)", "F", 3);
                showcourse.Rows.Add(3, "DATA STRUCTURE", "K", 3);
                showcourse.Rows.Add(4, "NTRODUCTION TO DATABASE", "O", 3);
                showcourse.Rows.Add(5, "ALGORITHMS", "H" , 3);
                showcourse.Rows.Add(6, "OBJECT ORIENTED PROGRAMMING 2 (C#)", "G", 3);
                showcourse.Rows.Add(7, "OBJECT ORIENTED ANALYSIS AND DESIGN","ZZ", 3);
                showcourse.Rows.Add(8, "ARTIFICIAL INTELLIGENCE AND EXPERT SYSTEM", "Y", 3);
                showcourse.Rows.Add(9, "SOFTWARE ENGINEERING", "M", 3);
                showcourse.Rows.Add(10, "COMPILER DESIGN", "P", 3);
                showcourse.Rows.Add(11, "THEORY OF COMPUTATION", "T", 3);
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



        private void selectcourseview()
        {
            if (selectcourse.Columns.Count == 0)
            {
                selectcourse.Columns.Add("Course No", typeof(int));
                selectcourse.Columns.Add("Course Name");
                selectcourse.Columns.Add("Section");
                selectcourse.Columns.Add("Course Credit", typeof(int));
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0 && listBox1.SelectedIndex >= 0) {

                int courseCredit = Convert.ToInt32(showcourse.Rows[listBox1.SelectedIndex]["Course Credit"]);
                selectcourse.ImportRow(showcourse.Rows[listBox1.SelectedIndex]);
                showcourse.Rows[listBox1.SelectedIndex].Delete();

               
                totalcr += courseCredit;
                credit.Text = totalcr.ToString();
                search.Text = "";

            }
           
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0 && listBox2.SelectedIndex >= 0)
            {
                
                int courseCredit = Convert.ToInt32(selectcourse.Rows[listBox2.SelectedIndex]["Course Credit"]);

                showcourse.ImportRow(selectcourse.Rows[listBox2.SelectedIndex]);
                selectcourse.Rows[listBox2.SelectedIndex].Delete();

                
                totalcr -= courseCredit;

                if (totalcr < 0)
                {
                    totalcr = 0;
                }

                credit.Text = totalcr.ToString();

                search.Text = "";
            }
        }



        private void confrim_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 0) {

                MessageBox.Show("Please select atleast one course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure to confrim these course", "Confrimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {

                    courseview.DataSource = selectcourse;

                    courseview.Columns["Course No"].Width = 80;
                    //courseview.Columns["Course Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                    courseview.Columns["Course Name"].Width = 150;
                    courseview.Columns["Section"].Width = 100;
                    courseview.Columns["Course Credit"].Width = 100;
                    //courseview.Enabled = false;
                    //listBox1.Enabled = false;
                    //listBox2.Enabled = false;
                    courseview.ReadOnly = true;   // for DataGridView
                    listBox1.SelectionMode = SelectionMode.None;
                    listBox2.SelectionMode = SelectionMode.None;
                    add.Enabled = false;
                    remove.Enabled = false;
                    confrim.Enabled = false;

                    search.Text = "";
                    search.Enabled = false;                    


                }
                else { }
                
            }

        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (courseview.ColumnCount == 0)
            {
                MessageBox.Show("Please confrim atleast one course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                track2 = true;
               StudentPortal s = new StudentPortal();
                s.Show();
                this.Hide();

            }
        }



        private void search_TextChanged(object sender, EventArgs e)
        {

            // Filter the showcourse based on search text
            string searchText = search.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(searchText))
            {
                // If search is empty, show all available courses (excluding those already selected)
                showcourse.Rows.Clear();
                foreach (DataRow row in originalShowCourse.Rows)
                {
                    // Only add courses that are not already in selectcourse
                    if (!IsCourseAlreadySelected(Convert.ToInt32(row["Course No"])))
                    {
                        showcourse.ImportRow(row);
                    }
                }
            }
            else
            {
                // Filter courses based on search text
                showcourse.Rows.Clear();
                foreach (DataRow row in originalShowCourse.Rows)
                {
                    string courseName = row["Course Name"].ToString().ToUpper();

                    // Only add courses that match search AND are not already selected
                    if (courseName.Contains(searchText) && !IsCourseAlreadySelected(Convert.ToInt32(row["Course No"])))
                    {
                        showcourse.ImportRow(row);
                    }
                }
            }
       }


        // Helper method to check if a course is already selected
        private bool IsCourseAlreadySelected(int courseNo)
        {
            foreach (DataRow row in selectcourse.Rows)
            {
                if (Convert.ToInt32(row["Course No"]) == courseNo)
                {
                    return true;
                }
            }
            return false;
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
                        name1.Text = parts[0];
                        id1.Text = parts[2];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Course_FormClosing(object sender, FormClosingEventArgs e)
        {
            track2 = true;
            Application.Exit();
        }

        public static void Reset()
        {
            track2 = false;
            totalcr = 0;                
            selectcourse = new DataTable();
        }

    }
}
