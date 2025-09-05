using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Course
{
    public partial class Form1 : Form
    {
        public static string name;
        public static string password;
        public static string id;
        public static string database = @"D:\C#\University_Portal\database.txt";
        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public Form1(string title)
        {
            InitializeComponent();
            this.Text = title;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Home.adminlog==true)
            {
                userid.Text = "Admin";
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (Home.studentlog == true)
            {
                
                id = userid.Text;
                password = userpass.Text;

                if (id == "" || password == "")
                {
                    MessageBox.Show("Please Fillup all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string studentName = ValidateLogin(id, password);

                    if (studentName != null) // login success
                    {
                        name = studentName; // store globally
                        MessageBox.Show($"Login successful! Welcome {studentName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        StudentPortal s = new StudentPortal();
                        s.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid userid or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        userid.Text = "";
                        userpass.Text = "";
                    }

                }


            }
            else if (Home.facultylog == true)
            {
                
                id = userid.Text;
                password = userpass.Text;

                if (id == "" || password == "")
                {
                    MessageBox.Show("Please Fillup all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string facultyName = ValidateLogin2(id, password);

                    if (facultyName != null) // login success
                    {
                        name = facultyName; // store globally
                        MessageBox.Show($"Login successful! Welcome {facultyName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Faculty_Portal f = new Faculty_Portal();
                        f.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid userid or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        userid.Text = "";
                        userpass.Text = "";
                    }

                }




            }
            else if (Home.adminlog==true) {
                
                id = userid.Text;
                password = userpass.Text;
                userid.Text = "Admin";

                if (id == "" || password == "")
                {
                    MessageBox.Show("Please Fillup all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(id!="Admin" || password != "12345")
                {
                    MessageBox.Show("Invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    MessageBox.Show($"Login successful! Welcome Admin", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Portal a = new Admin_Portal();
                    a.Show();
                    this.Hide();
                }
                


            }
        }

        private void loginbtn_MouseHover(object sender, EventArgs e)
        {
            loginbtn.BackColor = Color.RoyalBlue;
        }

        private void loginbtn_MouseLeave(object sender, EventArgs e)
        {
            loginbtn.BackColor = Color.CornflowerBlue;
        }

        private void signuptext_Click(object sender, EventArgs e)
        {
            SignUp s= new SignUp();
            s.Show();
            this.Hide();
        }

        private string ValidateLogin(string userid, string password)
        {
            if (!File.Exists(database))
                return null;

            try
            {
                string[] lines = File.ReadAllLines(database);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 6 && parts[1] == password && parts[2] == userid )
                    {
                        return parts[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private string ValidateLogin2(string userid, string password)
        {
            if (!File.Exists(facultydatabase))
                return null;

            try
            {
                string[] lines = File.ReadAllLines(facultydatabase);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 6 && parts[1] == password && parts[2] == userid)
                    {
                        return parts[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




        private void logout_Click(object sender, EventArgs e)
        {
            Home h  = new Home();
            h.Show();
            this.Hide();
            Home.studentlog = false;
            Home.facultylog = false;
            Home.adminlog = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
