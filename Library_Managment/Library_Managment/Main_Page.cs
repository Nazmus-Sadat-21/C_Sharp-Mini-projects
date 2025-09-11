using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Library_Managment
{
    public partial class Main_Page : Form
    {
        string bookid, bookname, author, category;
        int quantity;

        DataTable selectbooks = new DataTable();
        public Main_Page()
        {
            InitializeComponent();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            Heading.Text = $"Welcome,{Form1.loginname}";
            BookList();
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            Form1 f= new Form1();
            f.Show();
            this.Hide();
        }



        private void BookList()
        {
            try
            {


                string conPath = DataBase.conString;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"select * from BookInfo ";
                cmd.ExecuteNonQuery();


                DataTable  dt  = new DataTable();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                Booklist.DataSource = dt;
                Booklist.Refresh();



                con.Close();
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Main_Page_FormClosing(object sender, FormClosingEventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            selectedBook();
            SelectedBook.DataSource = selectbooks;
            SelectedBook.Refresh();

            quantity--;

        }

       
        private void remove_Click(object sender, EventArgs e)
        {
            if (SelectedBook.CurrentRow == null)
            {
                MessageBox.Show("Select a book to remove.");
                return;
            }

            string bookId = selectbooks.Rows[SelectedBook.CurrentRow.Index]["ID"].ToString();
            selectbooks.Rows.RemoveAt(SelectedBook.CurrentRow.Index);

            IncreaseBookQuantity(bookId); // add back quantity
            BookList(); // refresh table
        }

        private void Booklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure a row is clicked
            {
                DataGridViewRow row = Booklist.Rows[e.RowIndex];
                bookid= row.Cells["BookID"].Value.ToString();
                bookname = row.Cells["BookName"].Value.ToString();
                author = row.Cells["AuthorName"].Value.ToString();
                category = row.Cells["Category"].Value.ToString();
                quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

            }
       }

        private void borrow_Click(object sender, EventArgs e)
        {
            if (selectbooks.Rows.Count == 0)
            {
                MessageBox.Show("Select a book to Borrow.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                MessageBox.Show("Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 f = new Form1();
                f.Show();

            }
        }

        private void selectedBook()
        {
            if (selectbooks.Columns.Count==0)
            {
                selectbooks.Columns.Add("ID");
                selectbooks.Columns.Add("Name");
                selectbooks.Columns.Add("Author");
                selectbooks.Columns.Add("Category");

               
            }

            if(quantity > 0)
            {      
                selectbooks.Rows.Add($"{bookid}", $"{bookname}", $"{author}", $"{category}");
                UpdateBookQuantity(bookid); // Deduct from database
                BookList(); // Refresh main book list after update
            }
             else
            {
                MessageBox.Show("This book is out of stock!");
            }
        }

        private void UpdateBookQuantity(string id)


        {
            try
            {
                

                string conPath = DataBase.conString;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"UPDATE BookInfo SET Quantity = Quantity - 1 WHERE BookID = {id} AND Quantity > 0";
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book quantity: " + ex.Message);
            }
        }

        private void IncreaseBookQuantity(string id)
        {
            try
            {

                string conPath = DataBase.conString;
                var con = new SqlConnection();
                con.ConnectionString = conPath;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"UPDATE BookInfo SET Quantity = Quantity + 1 WHERE BookID = {id} AND Quantity > 0";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error increasing book quantity: " + ex.Message);
            }
        }



    }
}
