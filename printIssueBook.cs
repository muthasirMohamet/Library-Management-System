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

namespace Library_Manegment_System
{
    public partial class printIssueBook : Form
    {
        MainClass main = new MainClass();
        public printIssueBook()
        {
            InitializeComponent();
        }

        private void printIssueBook_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select StudentName,StudentSemester,StudentPhone,StudentEmail,BookName,issueBook.IssueDate,issueBook.stutas\r\nfrom student\r\ninner join issueBook\r\non issueBook.StudentID = student.StudentID\r\ninner join Book\r\non book.BookID = issueBook.BookID", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
