using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Manegment_System
{
    public partial class veiwBook : Form
    {
        MainClass main =new MainClass();
        public veiwBook()
        {
            InitializeComponent();
        }
         public void getviewbook()
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select bookName 'Book Name',bookpublication 'Book Publication',bookauthorName 'Book Authoe Name',bookpurchaseDate 'Book Purchase Date',bookprice 'Book Price',bookquantity 'Book Quantity' from book order by BookName ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[3].Width = 110;
                dataGridView1.Columns[4].Width = 85;
                dataGridView1.Columns[5].Width = 101;
            }
        }
        private void veiwBook_Load(object sender, EventArgs e)
        {
            getviewbook();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtsearch.Text == "Searching Books")
            {
                txtsearch.Clear();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure to cancel", "Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select bookName 'Book Name',bookpublication 'Book Publication',bookauthorName 'Book Authoe Name',bookpurchaseDate 'Book Purchase Date',bookprice 'Book Price',bookquantity 'Book Quantity' from book where bookName like '" + txtsearch.Text + "%' order by BookName ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Width = 200;
                dataGridView1.Columns[1].Width = 120;
                dataGridView1.Columns[2].Width = 125;
                dataGridView1.Columns[3].Width = 121;
                dataGridView1.Columns[4].Width = 85;
                dataGridView1.Columns[5].Width = 101;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = main.connec())
            {
                if(txtsearch.Text == " ")
                    {
                        MessageBox.Show("Soo gali id delete gareynayo '" + txtsearch.Text + "'");
                    }
                try
                {
                     if (MessageBox.Show("Mahubtaa inaad daleedeyso", "Checking delete item book", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                     {
                        SqlCommand cmd = new SqlCommand("delete from book where bookName = @id", sqlconn);
                        cmd.Parameters.AddWithValue("id", txtsearch.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("Waala delete gareeyay '" + txtsearch.Text + "'");
                        getviewbook();
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Sidaad u delete gareydo geli book id searching text");
                }
            }
        }
    }
}
