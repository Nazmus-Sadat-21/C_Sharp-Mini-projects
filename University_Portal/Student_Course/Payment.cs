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
   
    public partial class Payment : Form
    {
        public static string amount,method2;
        public static bool btntrack = false, track3 = false;
       
        public Payment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void method_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (accno.Text == "" || pin.Text == "")
            {
                MessageBox.Show("Please fillup all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Payment Successful ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registration.totalfee =0;
                StudentPortal p = new StudentPortal();
                p.Show();
                btntrack = true;
                track3 = true;
                this.Hide();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            textBox1.Text = amount;
            method.Text = method2;
        }

        public static void Reset()
        {
            btntrack = false;
            track3 = false;
        }
    }
}
