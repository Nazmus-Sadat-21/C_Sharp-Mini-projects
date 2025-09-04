using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        private int sec = 0,min=0,hr=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sec = 0;
            min = 0;
            hr = 0; 
            Timer.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hr++;
                }
            }

            string h = hr < 10 ? "0" + hr : hr.ToString();
            string m = min < 10 ? "0" + min : min.ToString();
            string s = sec < 10 ? "0" + sec : sec.ToString();
            Timer.Text = $"{h}:{m}:{s}";

        }
    }
}
