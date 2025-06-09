using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Manegment_System
{
    public partial class updateBook : Form
    {
        public string bookid;
        MainClass main =new MainClass();
        public updateBook()
        {
            InitializeComponent();
        }

        private void GetbookDetails()
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select BookID 'Book ID',BookName 'Book Name',BookAuthorName 'Book Author Name',BookPublication 'Book Publication',BookPurchaseDate 'Book Purchase date',BookPrice 'Book Price',BookQuantity 'Book Quantity'\r\nfrom book", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 110;
                dataGridView1.Columns[4].Width = 115;
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are sure to cancel","Checking",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void updateBook_Load(object sender, EventArgs e)
        {
            GetbookDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || tmp.Text == "")
                    {
                        MessageBox.Show("Meesha banaan soo buuxi");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "AddBook";
                        cmd.Parameters.AddWithValue("@bid", bookid);
                        cmd.Parameters.AddWithValue("@bName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@bAUName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@bPublication", textBox3.Text);
                        cmd.Parameters.AddWithValue("@bpDate", tmp.Text);
                        cmd.Parameters.AddWithValue("@bprice", textBox5.Text);
                        cmd.Parameters.AddWithValue("@bQuantity", textBox6.Text);
                        cmd.Parameters.AddWithValue("@type", "update");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book is Updated", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        GetbookDetails();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Laba jeer lama soo celin karo magac book horey loo xareeyay");
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tmp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
