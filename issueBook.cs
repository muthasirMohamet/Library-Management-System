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
    public partial class issueBook : Form
    {
        MainClass main =new MainClass();
        public issueBook()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to cancel","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "issueBooks";
                cmd.Parameters.AddWithValue("@ISSUEID", "");
                cmd.Parameters.AddWithValue("@STUDENTID", txtsid.Text);
                cmd.Parameters.AddWithValue("@BOOKID", txtbname.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ISSUEDATE", dt.Text);
                cmd.Parameters.AddWithValue("@Istatus", lblstatus.Text);
                cmd.Parameters.AddWithValue("@type", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTexBox();
                conn.Close();
                btnsave.Enabled = true;
            }
        }

        private void clearTexBox()
        {
            txtsid.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillComboFaculty()
        {
            using (SqlConnection conn = main.connec())
            {
                SqlCommand cmd = new SqlCommand("Select bookId,BookName from Book", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtbname.DisplayMember = "bookName";
                txtbname.ValueMember = "bookID";
                txtbname.DataSource = dt;
            }
        }

        private void issueBook_Load(object sender, EventArgs e)
        {
            fillComboFaculty();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printIssueBook pr = new printIssueBook();
            pr.Show();
        }
    }
}
