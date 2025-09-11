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

namespace Library_Managment
{

    public partial class SignUp : Form
    {
        string name, email, pass, phone;
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = UserName.Text;
            email = UserEmail.Text;
            phone = UserPhone.Text;
            pass = UserPass.Text;

            if (name ==""||email==""||phone==""||pass=="")
            {
                MessageBox.Show("Please Fill up your all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {


                    string conPath = DataBase.conString;
                    var con = new SqlConnection();
                    con.ConnectionString = conPath;
                    con.Open();

                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"INSERT INTO UserInfo  VALUES ('{name}','{email}','{phone}','{pass}')";
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("SignUp SuccessFul", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                Form1 f= new Form1();
                f.Show();
                this.Hide();

            }



        }
    }
}
