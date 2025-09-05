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
    public partial class courseresult : Form
    {
        public static string database = @"D:\C#\University_Portal\database.txt";
        public static DataTable  courseResult  = new DataTable();
        public static double semescg=0,result=0;
        private static bool resultGenerated = false;
        public courseresult()
        {
            InitializeComponent();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
            
        }


        private void course_Result()
        {
            if (resultGenerated)   // ✅ already generated, no need to run again
                return;

            double totalcredit = 0;

            // Prevent duplicate columns on reload
            if (courseResult.Columns.Count == 0)
            {
                // Copy all columns from Course.selectcourse
                foreach (DataColumn col in Course.selectcourse.Columns)
                {
                    courseResult.Columns.Add(col.ColumnName, col.DataType);
                }

                // Add Mark and Grade
                courseResult.Columns.Add("Mark", typeof(double));
                courseResult.Columns.Add("Grade", typeof(string));
            }

            // Clear previous rows to avoid duplication when loading again
            courseResult.Rows.Clear();

            // Example: Assign random marks and grades for demonstration
            Random rnd = new Random();

            foreach (DataRow row in Course.selectcourse.Rows)
            {
                DataRow newRow = courseResult.NewRow();

                // Copy existing data
                foreach (DataColumn col in Course.selectcourse.Columns)
                {
                    newRow[col.ColumnName] = row[col.ColumnName];
                }


                int courseCredit = Convert.ToInt32(row["Course Credit"]);
               

                // Add random marks (0–100 for demo)
                double mark = rnd.Next(50, 101);
                newRow["Mark"] = mark;

                // Assign grade based on mark
                if (mark >= 90)
                {
                    newRow["Grade"] = "A+";
                    totalcredit += courseCredit * 4.00;
                }
                else if (mark >= 85 && mark<90)
                {
                    newRow["Grade"] = "A";
                    totalcredit += courseCredit * 3.75;
                }
                else if (mark >= 80 && mark<85)
                {
                    newRow["Grade"] = "B+";
                    totalcredit += courseCredit * 3.50;
                }
                else if (mark >= 75 && mark<80)
                {
                    newRow["Grade"] = "B";
                    totalcredit += courseCredit * 3.25;
                }
                else if (mark >=70 && mark<75 )
                {
                    newRow["Grade"] = "C+";
                    totalcredit += courseCredit * 3.00;
                }
                else if (mark >= 65 && mark<70)
                {
                    newRow["Grade"] = "C";
                    totalcredit += courseCredit * 2.75;
                }
                else if (mark >= 60 && mark<65)
                {
                    newRow["Grade"] = "D+";
                    totalcredit += courseCredit * 2.50;
                }
                else if (mark >= 50 && mark<60)
                {
                    newRow["Grade"] = "D";
                    totalcredit += courseCredit * 2.25;
                }
                else if (mark <50)
                {
                    newRow["Grade"] = "F";
                    totalcredit += courseCredit * 0;
                }

                semescg = totalcredit / Course.totalcr;
                result = Math.Round(semescg, 2, MidpointRounding.AwayFromZero);
                // Add row to result table
                courseResult.Rows.Add(newRow);
            }
            resultGenerated = true;
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
                        n.Text = parts[0];
                        i.Text = parts[2];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void courseresult_Load(object sender, EventArgs e)
        {
            Getdata();
            c.Text = Course.totalcr.ToString();
            
            course_Result();
            courseview3.DataSource = courseResult;
            cgpa.Text = result.ToString();
           

        }

        private void courseresult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public static void Reset()
        {
            courseResult = new DataTable();
            semescg = 0;
            result = 0;               
            resultGenerated = false;
        }

    }
}
