using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroRail
{
    public partial class Form1 : Form
    {
        public bool crntstation = false;
        public bool deststation = false;
       
        public int crntamount = 0;
        public int destamount = 0;
        public static int fare = 0;
        public int totalfare = 0;

        private Button lastClickedButton = null;
        private Button currentStationButton = null;
        private Button selectedSeatButton = null;

        private Dictionary<Button, int> stationIndex = new Dictionary<Button, int>();

        private int[,] fareMatrix =
        {
            // UN  US  PL  MR  AG  FG  SB  DU  MJ  KL
            {  0, 20, 20, 40, 40, 60, 60, 80, 80,100 }, // Uttara North
            { 20,  0, 20, 20, 40, 40, 60, 60, 80, 80 }, // Uttara South
            { 20, 20,  0, 20, 20, 40, 40, 60, 60, 80 }, // Pallabi
            { 40, 20, 20,  0, 20, 20, 40, 40, 60, 60 }, // Mirpur-10
            { 40, 40, 20, 20,  0, 20, 20, 40, 40, 60 }, // Agargaon
            { 60, 40, 40, 20, 20,  0, 20, 20, 40, 40 }, // Farmgate
            { 60, 60, 40, 40, 20, 20,  0, 20, 20, 40 }, // Shahbag
            { 80, 60, 60, 40, 40, 20, 20,  0, 20, 20 }, // Dhaka University
            { 80, 80, 60, 60, 40, 40, 20, 20,  0, 20 }, // Motijheel
            {100, 80, 80, 60, 60, 40, 40, 20, 20,  0 }  // Komlapur
        };





        public Form1()
        {
            InitializeComponent();
            stationIndex[Unorth] = 0;
            stationIndex[Usouth] = 1;
            stationIndex[pallabi] = 2;
            stationIndex[mirpur] = 3;
            stationIndex[agargaon] = 4;
            stationIndex[farmgate] = 5;
            stationIndex[shahbag] = 6;
            stationIndex[DU] = 7;
            stationIndex[motijheel] = 8;
            stationIndex[komlapur] = 9;
        }

        private void ticket_hover(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.BackColor = Color.Green;
            //btn.ForeColor = Color.White;
        }
        private void ticket_leave(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            //btn.BackColor = Color.WhiteSmoke;
            //btn.ForeColor = Color.Black;
        }


        private void Station_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            
            if (lastClickedButton != null && lastClickedButton != clickedBtn && lastClickedButton != currentStationButton)
            {
                lastClickedButton.BackColor = Color.WhiteSmoke;
                lastClickedButton.ForeColor = Color.Black;
            }

            if (!crntstation) 
            {
                crntstation = true;
                heading.Text = "Select your destination";
                
                clickedBtn.BackColor = Color.Yellow;
                clickedBtn.ForeColor = Color.Black;
                clickedBtn.Enabled = false;

                currentStationButton = clickedBtn; 
                crntamount = stationIndex[clickedBtn];

                destination.Text = $"{clickedBtn.Text}\n To  ";
                updatevalue();

            }
            else 
            {
                clickedBtn.BackColor = Color.Red;
                clickedBtn.ForeColor = Color.White;

                destamount = stationIndex[clickedBtn];
               
                destination.Text = $"{currentStationButton.Text}\n To \n{clickedBtn.Text}";
                lastClickedButton = clickedBtn;
               
            }

        }

        


        private void updatevalue()
        {
            if (currentStationButton == null) return;

            int stationIdx = stationIndex[currentStationButton];

            un.Text = fareMatrix[stationIdx, 0] + " TK";
            us.Text = fareMatrix[stationIdx, 1] + " TK";
            plb.Text = fareMatrix[stationIdx, 2] + " TK";
            mrp.Text = fareMatrix[stationIdx, 3] + " TK";
            agrn.Text = fareMatrix[stationIdx, 4] + " TK";
            frmgt.Text = fareMatrix[stationIdx, 5] + " TK";
            shbg.Text = fareMatrix[stationIdx, 6] + " TK";
            dku.Text = fareMatrix[stationIdx, 7] + " TK";
            mtjhl.Text = fareMatrix[stationIdx, 8] + " TK";
            kmlpr.Text = fareMatrix[stationIdx, 9] + " TK";

            crntamount = stationIdx; // update current station index
        }


       

        private void seat_select(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lastClickedButton == null) 
            {
                MessageBox.Show("Please select your destination first", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

           
            if (selectedSeatButton != null && selectedSeatButton != btn)
            {
                selectedSeatButton.BackColor = Color.WhiteSmoke;
                selectedSeatButton.ForeColor = Color.Black;
            }

          
            selectedSeatButton = btn;
            btn.BackColor = Color.Green;
            btn.ForeColor = Color.White;

          
            int seatCount = Convert.ToInt32(btn.Tag); 
            fare = fareMatrix[crntamount, destamount] * seatCount;
            totalAmount.Text = $"Total Amount\n {fare} TK";
        }

        private void pay_Click(object sender, EventArgs e)
        {
            
            if (fare == 0)
            {
                MessageBox.Show("Please select your destination and tickets first", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            Payment p = new Payment();
            p.ShowDialog(); 

          
            if (Payment.paytracker==true)
            {
               
                pictureBox1.Visible = true;
               
                fare = 0;
                totalAmount.Text = "Total Amount\n 0 TK";
                crntstation = false;
                deststation = false;

               
                if (currentStationButton != null)
                {
                    currentStationButton.Enabled = true;
                    currentStationButton.BackColor = Color.WhiteSmoke;
                    currentStationButton.ForeColor = Color.Black;
                    currentStationButton = null;
                }

                if (lastClickedButton != null)
                {
                    lastClickedButton.BackColor = Color.WhiteSmoke;
                    lastClickedButton.ForeColor = Color.Black;
                    lastClickedButton = null;
                }

                if (selectedSeatButton != null)
                {
                    selectedSeatButton.BackColor = Color.WhiteSmoke;
                    selectedSeatButton.ForeColor = Color.Black;
                    selectedSeatButton = null;
                }

                Payment.paytracker = false; 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            fare = 0;
            totalAmount.Text = "Total Amount\n 0 TK";
            crntstation = false;
            deststation = false;
            destination.Text = "";

            if (currentStationButton != null)
            {
                currentStationButton.Enabled = true;
                currentStationButton.BackColor = Color.WhiteSmoke;
                currentStationButton.ForeColor = Color.Black;
                currentStationButton = null;
            }

            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = Color.WhiteSmoke;
                lastClickedButton.ForeColor = Color.Black;
                lastClickedButton = null;
            }

            if (selectedSeatButton != null)
            {
                selectedSeatButton.BackColor = Color.WhiteSmoke;
                selectedSeatButton.ForeColor = Color.Black;
                selectedSeatButton = null;
            }
        }
    }
}

