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
    public partial class viewStudent : Form
    {
        MainClass main = new MainClass();
        public viewStudent()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure to cancel", "Checking", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtsearch_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtsearch.Text == "Searching Students")
            {
                txtsearch.Clear();
            }
        }

        //private void fillstudentID()
        //{
        //    using (SqlConnection conn = main.connec())
        //    {
        //        SqlCommand cmd = new SqlCommand("Select studentID,studentName from student", conn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dgvStudent.DisplayMember = "studentName";
        //        dgvStudent.ValueMember = "studentID";
        //        dgvStudent.DataSource = dt;
        //    }
        //}
        private void viewStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select StudentID 'Student ID',StudentName 'Student Name',StudentSemester 'Student Semester',StudentPhone 'Student Phone',StudentEmail 'Student Email'\r\nfrom student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudent.DataSource = dt;
                dgvStudent.Columns[0].Width = 100;
                dgvStudent.Columns[1].Width = 160;
                dgvStudent.Columns[2].Width = 150;
                dgvStudent.Columns[3].Width = 150;
                dgvStudent.Columns[4].Width = 175;
            }
        }
    }
}
