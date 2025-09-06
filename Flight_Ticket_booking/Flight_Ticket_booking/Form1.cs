namespace Flight_Ticket_booking
{
    public partial class Flight_Booking : Form
    {

        public static string username, userphone, useremail, form, to, seats, bag, document1, paymentmethod2, planefare, passno, exp, dep, ret;
        public static bool document, paymentmethod;
        public static DateTime expdate, deptuare, Return;
        public static int totalAmount;


        public Flight_Booking()
        {
            InitializeComponent();
           
        }



        private void label14_Click(object sender, EventArgs e)
        {
            //totalAmount = int.Parse(seat1.Value.ToString()) * 6500;
            //planefare1.Text = totalAmount + "TK";
            //planefare = planefare1.Text;
        }


        private void UpdateFare()
        {
            totalAmount = (int)seat1.Value * 6500;
            seats = seat1.Value.ToString();
            planefare = totalAmount + " Tk";
            planefare1.Text = planefare; 
        }

        private void Flight_Booking_Load(object sender, EventArgs e)
        {
            UpdateFare();

        }


        private void seat1_ValueChanged(object sender, EventArgs e)
        {
            UpdateFare();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Update();
           
            username = name1.Text;
            userphone = mbl1.Text;
            useremail = email1.Text;
            form = form1.Text;
            to = to1.Text;
            seats = seat1.Value.ToString();
            bag = bag1.Value.ToString();
            document1 = passport1.Text;            
            passno = passno1.Text;
            expdate = expdate1.Value;
            exp = expdate1.Value.ToLongDateString();
            dep = monthCalendar1.SelectionStart.ToLongDateString();
            ret = monthCalendar2.SelectionStart.ToLongDateString();



            this.Visible = false;
            Info Info = new Info();
            Info.Show();


        }



        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                paymentmethod2 = radioButton2.Text;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                paymentmethod2 = radioButton3.Text;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                paymentmethod2 = radioButton4.Text;
            }
        }

        
    }
}
