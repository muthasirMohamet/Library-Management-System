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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Manegment_System
{
    public partial class returnBook : Form
    {
        string SID;
        MainClass main = new MainClass();
        public returnBook()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "returnBooks";
                cmd.Parameters.AddWithValue("@RID","");
                cmd.Parameters.AddWithValue("@STUDENTID", SID);
                cmd.Parameters.AddWithValue("@BOOKID", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@RDATE", tmp.Text);
                cmd.Parameters.AddWithValue("@ISSUEDATE", lblissuedate.Text);
                cmd.Parameters.AddWithValue("@Rstatus", status.Text);
                cmd.Parameters.AddWithValue("@type", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Return book has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                btnsave.Enabled = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void returnBook_Load(object sender, EventArgs e)
        {
            getBooks();
            //fillComboFaculty();
        }

        void getBooks()
        {
            using(SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select student.StudentID,StudentName,StudentSemester,StudentPhone,StudentEmail,BookName,issueBook.IssueDate from student inner join issueBook on issueBook.StudentID = student.StudentID inner join Book on book.BookID = issueBook.BookID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        ////private void fillComboFaculty()
        //{
        //    using (SqlConnection conn = main.connec())
        //    {
        //        SqlCommand cmd = new SqlCommand("Select bookId,BookName from Book", conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        comboBox2.DisplayMember = "bookName";
        //        comboBox2.ValueMember = "bookID";
        //        comboBox2.DataSource = dt;
        //    }
        //}

        

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //issueID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comsname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblsem.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblphone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblissuedate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
