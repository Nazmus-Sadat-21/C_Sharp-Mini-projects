using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Bus_Ticket
{
    public partial class Register : Form
    {
        private string Username;
        public static string Userphone;
        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Username = UserName.Text;
            Userphone = UserPhone.Text;
            if (Username==""||Userphone=="")
            {
                MessageBox.Show("Please fillup your all information","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Form1 f = new Form1(Username,Userphone);
                f.Show();
                this.Hide();
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
