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
    public partial class frstudentLibrary : Form
    {
        loginfr fr = new loginfr();
        MainClass main = new MainClass();
        public frstudentLibrary()
        {
            InitializeComponent();
        }
        

        private void frstudentLibrary_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select StudentName,StudentSemester,StudentPhone,StudentEmail,BookName,IssueDate from student inner join issueBook on student.StudentID = issueBook.StudentID inner join Book on issueBook.BookID = Book.BookID where student.StudentID = 2 ", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
