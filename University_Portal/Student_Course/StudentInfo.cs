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
using System.CodeDom.Compiler;
namespace Student_Course
{
    
    public partial class StudentInfo : Form
    {
        public static string database = @"D:\C#\University_Portal\database.txt";
        public static string infocg = " ";
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide(); 
            
        }

        private void StudentInfo_Load(object sender, EventArgs e)
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
                        heading2.Text = $"Welcome {parts[0]}";
                        infoid.Text = parts[2];
                        infoemail.Text = parts[4];
                        infophn.Text = parts[3];
                        infogen.Text = parts[5];
                        infocr.Text = Course.totalcr.ToString();
                        cg.Text = courseresult.result.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        public static void Reset()
        {
            infocg = " ";   
        }

    }
}
