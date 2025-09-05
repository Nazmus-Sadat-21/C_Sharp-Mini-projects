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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Student_Course
{
    public partial class SignUp : Form
    {
        public static string name1, id1, email1, phone1, gender1,pass1,repass1;

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public static string database = @"D:\C#\University_Portal\database.txt";
        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (Home.studentlog == true)
            {

                name1 = username2.Text;
                id1 = userid2.Text;
                email1 = email2.Text;
                phone1 = phone.Text;
                gender1 = comboBox1.Text;
                pass1 = Convert.ToString(password1.Text);
                repass1 = Convert.ToString(repassword1.Text);

                if (Name == "" || id1 == "" | email1 == "" || phone1 == "" || gender1 == "" || pass1 == "" || repass1 == "")
                {
                    MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass1 != repass1)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UserExists(id1))
                {
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (SaveUser(name1, pass1, id1, phone1, email1, gender1))
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1("SignUp");
                    f.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else if (Home.facultylog == true)
            {
                name1 = username2.Text;
                id1 = userid2.Text;
                email1 = email2.Text;
                phone1 = phone.Text;
                gender1 = comboBox1.Text;
                pass1 = Convert.ToString(password1.Text);
                repass1 = Convert.ToString(repassword1.Text);

                if (Name == "" || id1 == "" | email1 == "" || phone1 == "" || gender1 == "" || pass1 == "" || repass1 == "")
                {
                    MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass1 != repass1)
                {
                    MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UserExists2(id1))
                {
                    MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (SaveUser2(name1, pass1, id1, phone1, email1, gender1))
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1("");
                    f.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Back1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1("");
            f.Show();
            this.Close();
        }


        private bool UserExists(string username)
        {
            if (!File.Exists(database))
                return false;

            string[] lines = File.ReadAllLines(database);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 1 && parts[0] == username)
                    return true;
            }
            return false;
        }

        private bool SaveUser(string username, string password,string userid,string phone,string email,string gender)
        {
            try
            {
                // Simple encryption (not secure for production - use proper hashing)
                

                using (StreamWriter writer = new StreamWriter(database, true))
                {
                    writer.WriteLine($"{username}|{password}|{userid}|{phone}|{email}|{gender}");
                    writer.WriteLine();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        private bool UserExists2(string username)
        {
            if (!File.Exists(facultydatabase))
                return false;

            string[] lines = File.ReadAllLines(facultydatabase);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 1 && parts[0] == username)
                    return true;
            }
            return false;
        }



        private bool SaveUser2(string username, string password, string userid, string phone, string email, string gender)
        {
            try
            {
                


                using (StreamWriter writer = new StreamWriter(facultydatabase, true))
                {
                    writer.WriteLine($"{username}|{password}|{userid}|{phone}|{email}|{gender}");
                   
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
