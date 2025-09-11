using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Managment
{
    public partial class Form1 : Form
    {
        public static string loginname, loginpass;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp s= new SignUp();
            s.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginname = Loginname.Text;
            loginpass = Loginpas.Text;

            if (loginname == "" || loginpass == "")
            {
                MessageBox.Show("Please Fill up your all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                try
                {
                    string conPath = DataBase.conString;
                    SqlConnection con = new SqlConnection(conPath);
                    con.Open();

                    string query = $"SELECT * FROM UserInfo WHERE Name='{loginname}' AND Password='{loginpass}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main_Page m= new Main_Page();
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loginname = "";
                        loginpass = "";
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }

        }
    }
}
