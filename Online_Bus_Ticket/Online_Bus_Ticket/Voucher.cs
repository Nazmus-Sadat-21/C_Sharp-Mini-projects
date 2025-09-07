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
    public partial class Voucher : Form
    {
        private string bus, name, phone, From, To, date, seats;


        public Voucher(string bus,string name , string phone,string From,string To,string date, string seats)
        {
            InitializeComponent();
            this.bus = bus;
            this.name = name;
            this.phone = phone;
            this.From = From;
            this.To = To;
            this.date = date;
            this.seats = seats;
        }

        public Voucher() {
            InitializeComponent();

        }



        private void Voucher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void Voucher_Load(object sender, EventArgs e)
        {
            VoucherHeading.Text = bus;
            VoucherName.Text = name;
            Vouchernumber.Text = phone;
            Voucherform.Text = From;
            Voucherto.Text = To;
            Voucherdate.Text = $"{date} ({Form1.time})";
            VoucherSeat.Text = $"{seats} ({Form1.type})";
            coachno2.Text = Form1.coach;
        }


    }
}
