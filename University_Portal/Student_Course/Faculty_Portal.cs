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
    public partial class Faculty_Portal : Form
    {

        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public Faculty_Portal()
        {
            InitializeComponent();
        }

        private void Faculty_Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1("Faculy Portal");
            f.Show();
            this.Hide(); 
        }

        private void studentInfo_Click(object sender, EventArgs e)
        {
            Facculty_Info f= new Facculty_Info();
            f.Show();
            this.Hide();
        }

        private void coursereg_Click(object sender, EventArgs e)
        {
            Course_Information c = new Course_Information();
            c.Show();
            this.Hide();
        }

        private void Faculty_Portal_Load(object sender, EventArgs e)
        {
            Getdata();
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

        
    }
}
