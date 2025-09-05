using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Student_Course
{
    public partial class Registration : Form
    {
        public static string database = @"D:\C#\University_Portal\database.txt";
        public static DataTable course = new DataTable();
        public static double totalfee = 0;
        public static string paymentmethod,fee2;
        public static bool track = true ;
        public Registration()
        {
            InitializeComponent();
        }

        private void back2_Click(object sender, EventArgs e)
        {
            StudentPortal s = new StudentPortal();
            s.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            Getdata();
            c.Text = Course.totalcr.ToString();
            viewcourses();
            tutionfee();

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

        private void viewcourses()
        {
            courseview2.DataSource = Course.selectcourse;
            courseview2.ReadOnly = true;
            courseview2.Columns["Course No"].Width = 50;
            //courseview.Columns["Course Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            courseview2.Columns["Course Name"].Width = 150;
            courseview2.Columns["Course Credit"].Width = 80;
        }

        private void tutionfee()
        {
            if (Payment.track3 == true)
            {
                fee.Text = "0 TK";
            }
            else
            {
                totalfee = Convert.ToDouble(Course.totalcr * 6000);
                fee.Text = $"{totalfee} TK";
            }
           
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void confrim_Click(object sender, EventArgs e)
        {
            if (Payment.track3==true)
            {
                MessageBox.Show("You have already paid your tution fee", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            payment();
            if (track == true)
            {
                
                Payment.amount = fee.Text;
                Payment p = new Payment();
                Payment.track3 = false;
                p.Show();
                this.Hide();
            }
          

        }

        private void payment()
        {
            if (radioButton1.Checked == true)
            {

                paymentmethod = radioButton1.Text;
                track = true;
                Payment.method2 = paymentmethod;

            }
            else if (radioButton2.Checked == true)
            {

                paymentmethod = radioButton2.Text;
                track = true;
                Payment.method2 = paymentmethod;

            }
            else if (radioButton3.Checked == true)
            {

                paymentmethod = radioButton3.Text;
                track = true;
                Payment.method2 = paymentmethod;

            }
            else
            {
                MessageBox.Show("Please select any payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                track = false;
            }
        }

    }
}
