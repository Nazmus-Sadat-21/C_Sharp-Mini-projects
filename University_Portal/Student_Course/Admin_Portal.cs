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
    public partial class Admin_Portal : Form
    {
        public Admin_Portal()
        {
            InitializeComponent();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1("Admin Portal");
            f.Show();
            this.Hide();
        }

        private void Admin_Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentInfo_Click(object sender, EventArgs e)
        {
            Student_Information s= new Student_Information();
            s.Show();
            this.Hide();
        }

        private void coursereg_Click(object sender, EventArgs e)
        {
            Faculty_Information f  = new Faculty_Information();
            f.Show();
            this.Hide();
        }
    }
}
