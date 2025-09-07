using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Bus_Ticket
{
    public partial class Form1 : Form


    {

        private string  bus, From, To,seats = "";
        public static string type,time, date,coach;
        private Button btnselect = null;
        private int totalfare = 0;
        private int selectedFare = 0;

        private DataTable Bus  = new DataTable();

        private DataTable hanifBus = new DataTable();
        private DataTable shynoliBus = new DataTable();
        private DataTable greenBus = new DataTable();
        private DataTable deshBus = new DataTable();
        private DataTable shahBus = new DataTable();
        private DataTable uniqueBus = new DataTable();
        private DataTable soudiaBus = new DataTable();
        private DataTable enaBus = new DataTable();
        private DataTable shohagBus = new DataTable();

        private DataTable Fromdistrict = new DataTable();
        private DataTable Todistrict = new DataTable();
        private string name,phone;
        public Form1(string name,string userphone)
        {
            InitializeComponent();
            this.name = name;
            this.phone = userphone;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bus = Selectbus.Text;
            From  = from2.Text;
            To = to2.Text;
           

            HeadingName.Text = $"Welcome,{this.name}";

            BusNames();
            Selectbus.DataSource = Bus;
            Selectbus.DisplayMember = "Available Bus";

            FromDistrict();
            from2.DataSource = Fromdistrict;
            from2.DisplayMember = "Name";
            ToDistrict();
            to2.DataSource = Todistrict;
            to2.DisplayMember = "Name";


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void FromDistrict()
        {
            if (Fromdistrict.Columns.Count == 0)
            {
                Fromdistrict.Columns.Add("Name");
                
                
                 string[] districts = {
                "Bagerhat","Bandarban","Barguna","Barisal","Bhola","Bogura","Brahmanbaria","Chandpur",
                "Chattogram","Chuadanga","Cox's Bazar","Cumilla","Dhaka","Dinajpur","Faridpur","Feni",
                "Gaibandha","Gazipur","Gopalganj","Habiganj","Jamalpur","Jashore","Jhalokati","Jhenaidah",
                "Joypurhat","Khagrachari","Khulna","Kishoreganj","Kurigram","Kushtia","Lakshmipur","Lalmonirhat",
                "Madaripur","Magura","Manikganj","Meherpur","Moulvibazar","Munshiganj","Mymensingh","Naogaon",
                "Narail","Narayanganj","Narsingdi","Natore","Netrokona","Nilphamari","Noakhali","Pabna",
                "Panchagarh","Patuakhali","Pirojpur","Rajbari","Rajshahi","Rangamati","Rangpur","Satkhira",
                "Shariatpur","Sherpur","Sirajganj","Sunamganj","Sylhet","Tangail","Thakurgaon","Madaripur",
                "Gazipur","Natore","Narail","Kishoreganj"
                 };

                foreach (string d in districts)
                {
                    Fromdistrict.Rows.Add(d);
                }
            }
        }


        private void ToDistrict()
        {
            if (Todistrict.Columns.Count == 0)
            {
                Todistrict.Columns.Add("Name");


                string[] districts = {
                "Bagerhat","Bandarban","Barguna","Barisal","Bhola","Bogura","Brahmanbaria","Chandpur",
                "Chattogram","Chuadanga","Cox's Bazar","Cumilla","Dhaka","Dinajpur","Faridpur","Feni",
                "Gaibandha","Gazipur","Gopalganj","Habiganj","Jamalpur","Jashore","Jhalokati","Jhenaidah",
                "Joypurhat","Khagrachari","Khulna","Kishoreganj","Kurigram","Kushtia","Lakshmipur","Lalmonirhat",
                "Madaripur","Magura","Manikganj","Meherpur","Moulvibazar","Munshiganj","Mymensingh","Naogaon",
                "Narail","Narayanganj","Narsingdi","Natore","Netrokona","Nilphamari","Noakhali","Pabna",
                "Panchagarh","Patuakhali","Pirojpur","Rajbari","Rajshahi","Rangamati","Rangpur","Satkhira",
                "Shariatpur","Sherpur","Sirajganj","Sunamganj","Sylhet","Tangail","Thakurgaon","Madaripur",
                "Gazipur","Natore","Narail","Kishoreganj"
                 };

                foreach (string d in districts)
                {
                    Todistrict.Rows.Add(d);
                }
            }
        }




        private void BusNames()
        {
            Bus.Columns.Add("Available Bus");

            Bus.Rows.Add("Hanif Enterprise");
            Bus.Rows.Add("Shymoli Paribahan");
            Bus.Rows.Add("Green Line");
            Bus.Rows.Add("Ena Travels");
            Bus.Rows.Add("Desh Travels");
            Bus.Rows.Add("Soudia Enterprise");
            Bus.Rows.Add("Shohag Paribahan");
            Bus.Rows.Add("Unique");
            Bus.Rows.Add("Shah Fateh Ali");

        }

        private void hanif()
        {
            if (hanifBus.Columns.Count==0)
            {
                hanifBus.Columns.Add("Coach No");
                hanifBus.Columns.Add("Time");
                hanifBus.Columns.Add("Type");
                hanifBus.Columns.Add("Fare", typeof(int));

                hanifBus.Rows.Add("HNF-101", "08:00 AM", "NON AC", 800);
                hanifBus.Rows.Add("HNF-102", "09:30 AM", "AC", 1200);
                hanifBus.Rows.Add("HNF-103", "11:00 AM", "NON AC", 900);
                hanifBus.Rows.Add("HNF-104", "01:00 PM", "AC", 1350);
                hanifBus.Rows.Add("HNF-105", "02:30 PM", "NON AC", 750);
                hanifBus.Rows.Add("HNF-106", "04:00 PM", "AC", 1400);
                hanifBus.Rows.Add("HNF-107", "06:00 PM", "NON AC", 850);
                hanifBus.Rows.Add("HNF-108", "08:00 PM", "AC", 1450);
                hanifBus.Rows.Add("HNF-109", "10:00 PM", "NON AC", 700);
                hanifBus.Rows.Add("HNF-110", "11:30 PM", "AC", 1500);
            }

            viewAvailabletbus(hanifBus);




        }

        private void shymoli()
        {
            if (shahBus.Columns.Count==0)
            {

                shynoliBus.Columns.Add("Coach No");
                shynoliBus.Columns.Add("Time");
                shynoliBus.Columns.Add("Type");
                shynoliBus.Columns.Add("Fare", typeof(int));

                shynoliBus.Rows.Add("SYM-201", "07:30 AM", "NON AC", 750);
                shynoliBus.Rows.Add("SYM-202", "09:00 AM", "AC", 1250);
                shynoliBus.Rows.Add("SYM-203", "10:30 AM", "NON AC", 800);
                shynoliBus.Rows.Add("SYM-204", "12:00 PM", "AC", 1400);
                shynoliBus.Rows.Add("SYM-205", "02:00 PM", "NON AC", 850);
                shynoliBus.Rows.Add("SYM-206", "04:30 PM", "AC", 1450);
                shynoliBus.Rows.Add("SYM-207", "06:30 PM", "NON AC", 900);
                shynoliBus.Rows.Add("SYM-208", "08:30 PM", "AC", 1500);
                shynoliBus.Rows.Add("SYM-209", "10:30 PM", "NON AC", 700);
                shynoliBus.Rows.Add("SYM-210", "11:59 PM", "AC", 1350);
            }
            viewAvailabletbus(shynoliBus);
        }

        private void green()
        {
            if (greenBus.Columns.Count==0)
            {
                greenBus.Columns.Add("Coach No");
                greenBus.Columns.Add("Time");
                greenBus.Columns.Add("Type");
                greenBus.Columns.Add("Fare", typeof(int));

                greenBus.Rows.Add("GRN-301", "07:00 AM", "NON AC", 850);
                greenBus.Rows.Add("GRN-302", "09:00 AM", "AC", 1400);
                greenBus.Rows.Add("GRN-303", "11:00 AM", "NON AC", 900);
                greenBus.Rows.Add("GRN-304", "01:30 PM", "AC", 1450);
                greenBus.Rows.Add("GRN-305", "03:00 PM", "NON AC", 750);
                greenBus.Rows.Add("GRN-306", "05:00 PM", "AC", 1350);
                greenBus.Rows.Add("GRN-307", "07:00 PM", "NON AC", 800);
                greenBus.Rows.Add("GRN-308", "09:00 PM", "AC", 1500);
                greenBus.Rows.Add("GRN-309", "11:00 PM", "NON AC", 700);
                greenBus.Rows.Add("GRN-310", "11:59 PM", "AC", 1200);
            }
            viewAvailabletbus(greenBus);
        }

        private void desh()
        {
            if (deshBus.Columns.Count==0)
            {
                deshBus.Columns.Add("Coach No");
                deshBus.Columns.Add("Time");
                deshBus.Columns.Add("Type");
                deshBus.Columns.Add("Fare", typeof(int));

                deshBus.Rows.Add("DSH-401", "08:00 AM", "NON AC", 800);
                deshBus.Rows.Add("DSH-402", "09:30 AM", "AC", 1350);
                deshBus.Rows.Add("DSH-403", "11:00 AM", "NON AC", 750);
                deshBus.Rows.Add("DSH-404", "12:30 PM", "AC", 1400);
                deshBus.Rows.Add("DSH-405", "02:00 PM", "NON AC", 900);
                deshBus.Rows.Add("DSH-406", "03:30 PM", "AC", 1450);
                deshBus.Rows.Add("DSH-407", "05:00 PM", "NON AC", 850);
                deshBus.Rows.Add("DSH-408", "07:30 PM", "AC", 1500);
                deshBus.Rows.Add("DSH-409", "09:00 PM", "NON AC", 700);
                deshBus.Rows.Add("DSH-410", "10:30 PM", "AC", 1250);
            }
            viewAvailabletbus(deshBus);
        }

        private void shah()
        {
            if (shahBus.Columns.Count==0)
            {
                shahBus.Columns.Add("Coach No");
                shahBus.Columns.Add("Time");
                shahBus.Columns.Add("Type");
                shahBus.Columns.Add("Fare", typeof(int));

                shahBus.Rows.Add("SH-501", "07:00 AM", "NON AC", 750);
                shahBus.Rows.Add("SH-502", "08:30 AM", "AC", 1300);
                shahBus.Rows.Add("SH-503", "10:00 AM", "NON AC", 800);
                shahBus.Rows.Add("SH-504", "11:30 AM", "AC", 1400);
                shahBus.Rows.Add("SH-505", "01:00 PM", "NON AC", 900);
                shahBus.Rows.Add("SH-506", "03:00 PM", "AC", 1450);
                shahBus.Rows.Add("SH-507", "05:00 PM", "NON AC", 850);
                shahBus.Rows.Add("SH-508", "07:00 PM", "AC", 1500);
                shahBus.Rows.Add("SH-509", "09:00 PM", "NON AC", 700);
                shahBus.Rows.Add("SH-510", "11:00 PM", "AC", 1350);
            }
            viewAvailabletbus(shahBus);
        }

        private void unique()
        {
            if (uniqueBus.Columns.Count==0)
            {
                uniqueBus.Columns.Add("Coach No");
                uniqueBus.Columns.Add("Time");
                uniqueBus.Columns.Add("Type");
                uniqueBus.Columns.Add("Fare", typeof(int));

                uniqueBus.Rows.Add("UNQ-601", "06:30 AM", "NON AC", 750);
                uniqueBus.Rows.Add("UNQ-602", "08:30 AM", "AC", 1250);
                uniqueBus.Rows.Add("UNQ-603", "10:30 AM", "NON AC", 850);
                uniqueBus.Rows.Add("UNQ-604", "12:30 PM", "AC", 1400);
                uniqueBus.Rows.Add("UNQ-605", "02:30 PM", "NON AC", 900);
                uniqueBus.Rows.Add("UNQ-606", "04:30 PM", "AC", 1500);
                uniqueBus.Rows.Add("UNQ-607", "06:30 PM", "NON AC", 800);
                uniqueBus.Rows.Add("UNQ-608", "08:30 PM", "AC", 1350);
                uniqueBus.Rows.Add("UNQ-609", "10:30 PM", "NON AC", 700);
                uniqueBus.Rows.Add("UNQ-610", "11:59 PM", "AC", 1450);
            }
            viewAvailabletbus(uniqueBus);
        }

        private void soudia()
        {
            if (soudiaBus.Columns.Count==0)
            {
                soudiaBus.Columns.Add("Coach No");
                soudiaBus.Columns.Add("Time");
                soudiaBus.Columns.Add("Type");
                soudiaBus.Columns.Add("Fare", typeof(int));

                soudiaBus.Rows.Add("SD-701", "06:00 AM", "NON AC", 750);
                soudiaBus.Rows.Add("SD-702", "08:00 AM", "AC", 1250);
                soudiaBus.Rows.Add("SD-703", "10:00 AM", "NON AC", 850);
                soudiaBus.Rows.Add("SD-704", "12:00 PM", "AC", 1350);
                soudiaBus.Rows.Add("SD-705", "02:00 PM", "NON AC", 900);
                soudiaBus.Rows.Add("SD-706", "04:00 PM", "AC", 1450);
                soudiaBus.Rows.Add("SD-707", "06:00 PM", "NON AC", 800);
                soudiaBus.Rows.Add("SD-708", "08:00 PM", "AC", 1400);
                soudiaBus.Rows.Add("SD-709", "10:00 PM", "NON AC", 700);
                soudiaBus.Rows.Add("SD-710", "11:59 PM", "AC", 1500);
            }

            viewAvailabletbus(soudiaBus);
        }

        private void ena()
        {
            if (enaBus.Columns.Count==0)
            {
                enaBus.Columns.Add("Coach No");
                enaBus.Columns.Add("Time");
                enaBus.Columns.Add("Type");
                enaBus.Columns.Add("Fare", typeof(int));

                enaBus.Rows.Add("ENA-801", "06:00 AM", "NON AC", 750);
                enaBus.Rows.Add("ENA-802", "08:00 AM", "AC", 1300);
                enaBus.Rows.Add("ENA-803", "10:00 AM", "NON AC", 800);
                enaBus.Rows.Add("ENA-804", "12:00 PM", "AC", 1400);
                enaBus.Rows.Add("ENA-805", "02:00 PM", "NON AC", 850);
                enaBus.Rows.Add("ENA-806", "04:00 PM", "AC", 1450);
                enaBus.Rows.Add("ENA-807", "06:00 PM", "NON AC", 900);
                enaBus.Rows.Add("ENA-808", "08:00 PM", "AC", 1500);
                enaBus.Rows.Add("ENA-809", "10:00 PM", "NON AC", 700);
                enaBus.Rows.Add("ENA-810", "11:59 PM", "AC", 1350);
            }

            viewAvailabletbus(enaBus);
        }

        private void shohag()
        {
            if (shohagBus.Columns.Count==0)
            {
                shohagBus.Columns.Add("Coach No");
                shohagBus.Columns.Add("Time");
                shohagBus.Columns.Add("Type");
                shohagBus.Columns.Add("Fare", typeof(int));

                shohagBus.Rows.Add("SHG-901", "07:30 AM", "NON AC", 800);
                shohagBus.Rows.Add("SHG-902", "09:30 AM", "AC", 1350);
                shohagBus.Rows.Add("SHG-903", "11:30 AM", "NON AC", 750);
                shohagBus.Rows.Add("SHG-904", "01:30 PM", "AC", 1400);
                shohagBus.Rows.Add("SHG-905", "03:30 PM", "NON AC", 850);
                shohagBus.Rows.Add("SHG-906", "05:30 PM", "AC", 1450);
                shohagBus.Rows.Add("SHG-907", "07:30 PM", "NON AC", 900);
                shohagBus.Rows.Add("SHG-908", "09:30 PM", "AC", 1500);
                shohagBus.Rows.Add("SHG-909", "11:00 PM", "NON AC", 700);
                shohagBus.Rows.Add("SHG-910", "11:59 PM", "AC", 1200);
            }

            viewAvailabletbus(shohagBus);
        }


        private void viewAvailabletbus(DataTable buses)
        {
            Random rnd = new Random();
            int rowCount = rnd.Next(2,9); 

            DataTable randomTable = buses.AsEnumerable()
                                         .OrderBy(r => Guid.NewGuid())
                                         .Take(rowCount)
                                         .CopyToDataTable();



            availablebus.DataSource = randomTable;
            availablebus.ReadOnly = true;
            if(availablebus.Rows.Count > 0)
            {
                viewseat.Visible = true;
                coachno.Text = coach;
            }
        }

        

        private void book_Click(object sender, EventArgs e)
        {
            if (selectedButtons.Count==0)
            {
                MessageBox.Show("Please select your seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateSeatsString();

            date = journeydate.Value.ToString("dd/MM/yyyy");

            Payment p = new Payment(seats,totalfare, bus, name, phone, From, To, date, seats);
            p.Show();
            this.Hide();


           



        }

        private void viewseat_Click(object sender, EventArgs e)
        {
            seatpanel.Visible = true;

           

            randomseatbook();

              
            
        }

       

        private void selectbus()
        {
            if (Selectbus.Text == "Hanif Enterprise")
            {
                hanif();
            }
            else if (Selectbus.Text == "Shymoli Paribahan")
            {
                shymoli();
            }
            else if (Selectbus.Text == "Green Line")
            {
                green();
            }
            else if (Selectbus.Text == "Ena Travels")
            {
                ena();
            }
            else if (Selectbus.Text == "Desh Travels")
            {
                desh();
            }
            else if (Selectbus.Text == "Soudia Enterprise")
            {
               soudia();
            }
            else if (Selectbus.Text == "Shohag Paribahan")
            {
               shohag();
            }
            else if (Selectbus.Text == "Unique")
            {
                unique();
            }
            else if (Selectbus.Text == "Shah Fateh Ali")
            {
                shah();
            }
        }

        private void availablebus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure a row is clicked
            {
                DataGridViewRow row = availablebus.Rows[e.RowIndex];
                coach = row.Cells["Coach No"].Value.ToString();
                type = row.Cells["Type"].Value.ToString();
                time = row.Cells["Time"].Value.ToString();
                selectedFare = Convert.ToInt32(row.Cells["Fare"].Value); 
               
                
                foreach (Button btn in selectedButtons)
                {
                    btn.BackColor = Color.White;
                }

                coachno.Text = coach;

                selectedButtons.Clear();
                
                randomseatbook();

               
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            bus = Selectbus.Text;
            From = from2.Text;
            To = to2.Text;
            date= journeydate.Text;

            if (bus==""||from2.Text==""||to2.Text==""||date == "")
            {
                MessageBox.Show("Please fillup your all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                selectbus();
            }

        }



        public static List<Button> selectedButtons = new List<Button>();
        private void selectSeat(object sender, EventArgs e)
        {
            

            Button btn = (Button)sender;

            if (selectedButtons.Contains(btn))
            {
              
                btn.BackColor = Color.White;
                selectedButtons.Remove(btn);
            }
            else
            {
                
                btn.BackColor = Color.Green;
                selectedButtons.Add(btn);
            }

            //UpdateSeatsString();



        }

        private void UpdateSeatsString()
        {
            seats = "";
            foreach (Button btn in selectedButtons)
            {
                seats += $"{btn.Text} ";
            }

            totalfare = selectedFare*selectedButtons.Count;
            
        }

        private void randomseatbook()
        {
            Random rnd = new Random();

            foreach (Control ctrl in seatpanel.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("button"))
                {
                    if (rnd.Next(2) == 0)
                    {
                        btn.BackColor = Color.Gray;
                        btn.Enabled = false;
                    }
                    else
                    {
                        btn.BackColor = Color.White;
                        btn.Enabled = true;
                    }
                }
            }
        }

    }
}
