using System.IO;
using System.Text.Json;


namespace BankAccount
{
    public partial class Form1 : Form
    {


        List<Bankaccount> banks = new List<Bankaccount>();
        private string filePath = "bankdata.json";

        // Save data
        public Form1()
        {
            InitializeComponent();
            LoadData();   // load saved accounts when app starts
            Bankgrid.DataSource = banks;
        }
        private void SaveData()
        {
            string json = JsonSerializer.Serialize(banks);
            File.WriteAllText(filePath, json);
        }

        // Load data
        private void LoadData()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                banks = JsonSerializer.Deserialize<List<Bankaccount>>(json) ?? new List<Bankaccount>();
            }
        }






       
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (ownertext.Text == "")
            {
                return;
            }
            else
            {
                Bankaccount bank = new Bankaccount(ownertext.Text);
                banks.Add(bank);
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                
                ownertext.Text = "";
                SaveData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bankgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {

                Bankaccount select = Bankgrid.SelectedRows[0].DataBoundItem as Bankaccount;

                string message = select.Depositeamount((double)Amount.Value); ;
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                Amount.Value = 0;
                MessageBox.Show(message);
                SaveData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bankgrid.SelectedRows.Count == 1 && Amount.Value > 0)
            {

                Bankaccount select = Bankgrid.SelectedRows[0].DataBoundItem as Bankaccount;

                string message = select.Withdrawamount((double)Amount.Value);
                Bankgrid.DataSource = null;
                Bankgrid.DataSource = banks;
                Amount.Value = 0;
                MessageBox.Show(message);
                SaveData();

            }
        }

        
    }
}

