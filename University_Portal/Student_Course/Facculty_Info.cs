using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Student_Course
{
    public partial class Facculty_Info : Form
    {
        public static string facultydatabase = @"D:\C#\University_Portal\facultydatabase";
        public static string roomno;
        public static bool roomtracker = false;
        public Facculty_Info()
        {
            InitializeComponent();
        }

        private void Facculty_Info_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        private void RoomNumber()
        {
            if (roomtracker)
            {
                room.Text = roomno;
                return;
            }
            Random rnd = new Random();
            int random = rnd.Next(1, 9);
            int random2 = rnd.Next(1, 9);
            string s;
            if (random % 2 == 0)
            {
                s = "S";
            }
            else
            {
                s = "N";
            }
            room.Text = $"D{s}{random}0{random2}";
            roomno = room.Text;
            roomtracker = true;
        }
        private void Getdata()
        {
            if (!File.Exists(facultydatabase))
            {
                MessageBox.Show("Error! Database not found.");
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(facultydatabase);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');


                    if (parts.Length == 6 && parts[1] == Form1.password && parts[2] == Form1.id)
                    {
                        
                        heading2.Text = $"Welcome {parts[0]}";
                        infoid.Text = parts[2];
                        infoemail.Text = parts[4];
                        infophn.Text = parts[3];
                        infogen.Text = parts[5];
                        RoomNumber();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back2_Click(object sender, EventArgs e)
        {
            Faculty_Portal f = new Faculty_Portal();
            f.Show();
            this.Hide();
        }

        private void Facculty_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
