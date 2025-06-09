using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manegment_System
{
    public partial class addBook : Form
    {
        MainClass main = new MainClass();
        public addBook()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure to cancel", "Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = main.connec())
            {
                try
                {
                    if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox6.Text == "" || tmp.Text == "")
                    {
                        MessageBox.Show("Meesha banaan soo buuxi");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "AddBook";
                        cmd.Parameters.AddWithValue("@bid", "");
                        cmd.Parameters.AddWithValue("@bName", textBox1.Text);
                        cmd.Parameters.AddWithValue("@bAUName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@bPublication", textBox3.Text);
                        cmd.Parameters.AddWithValue("@bpDate", tmp.Text);
                        cmd.Parameters.AddWithValue("@bprice", textBox5.Text);
                        cmd.Parameters.AddWithValue("@bQuantity", textBox6.Text);
                        cmd.Parameters.AddWithValue("@type", "insert");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book is done", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        clr();
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Laba jeer lama soo celin karo magac book horey loo xareeyay");
                }

            }
        }

        private void clr()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
