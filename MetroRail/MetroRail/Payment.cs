using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroRail
{

    public partial class Payment : Form
    {
        public static bool paytracker = false;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            amount.Text = Form1.fare.ToString() + " TK";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (pin.Text=="")
            {
                MessageBox.Show("Please enter your PIN", "Information",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Hide();
            paytracker = true;
        }
    }
}
