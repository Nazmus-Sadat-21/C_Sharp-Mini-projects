using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Ticket_booking
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {
            name2.Text = Flight_Booking.username;
            email2.Text = Flight_Booking.useremail;
            mobile2.Text = Flight_Booking.userphone;
            form2.Text = Flight_Booking.form;
            to2.Text = Flight_Booking.to;
            deptuare2.Text = Flight_Booking.dep;
            return2.Text = Flight_Booking.ret;
            document2.Text = Flight_Booking.document1;
            passport2.Text = Flight_Booking.passno;
            exp2.Text = Flight_Booking.exp;
            seat2.Text = Flight_Booking.seats;
            bag2.Text = Flight_Booking.bag + " Kgs";
            amount2.Text = Flight_Booking.planefare;
            payment2.Text = Flight_Booking.paymentmethod2;


        }

        private void back_Click(object sender, EventArgs e)
        {
            
            
            Flight_Booking f = new Flight_Booking();
            f.Show();
            this.Visible = false;
        }

        private void pay_Click(object sender, EventArgs e)
        {
           
           
            Payment payment = new Payment();    
            payment.Show();
            this.Visible = false;

        }
    }
}
