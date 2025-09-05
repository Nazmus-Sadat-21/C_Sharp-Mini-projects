using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course
{
    public partial class Home : Form
    { 
        public static bool adminlog = false;
        public static bool studentlog = false;
        public static bool facultylog = false;
        public Home()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            adminlog = true;
            Form1 f = new Form1("Admin LogIn");
            f.Show();
            
            this.Hide();
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            studentlog = true;
            Form1 f = new Form1("Student LogIn");
            f.Show();
            
           
            this.Hide();
        }

        private void FacultyLogin_Click(object sender, EventArgs e)
        {
            facultylog = true;
            Form1 f = new Form1("Faculty LogIn");
            f.Show();
           
            this.Hide();
        }

       

        private void Home_ForeColorChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
