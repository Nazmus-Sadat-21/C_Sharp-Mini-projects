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
    public partial class Payment : Form
    {

        private string bus, name, phone, From, To, date, seats;
        private string selectedseat;
        private int totalfare;
        public Payment(string seat,int totalfare, string bus, string name, string phone, string From, string To, string date, string seats)
        {
            InitializeComponent();
            this.selectedseat = seat;
            this.totalfare = totalfare;
            this.bus = bus;
            this.name = name;
            this.phone = phone;
            this.From = From;
            this.To = To;
            this.date = date;
            this.seats = seats;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            Seats.Text = $"{Form1.selectedButtons.Count} ({selectedseat})";
            Totalamount.Text = $" {totalfare} TK";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (accno.Text==""||pin.Text=="")
            {
                MessageBox.Show("Please fillup your all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Voucher v  = new Voucher(bus, name, phone, From, To, date, seats);
            v.Show();
            this.Hide();

        }
    }
}
