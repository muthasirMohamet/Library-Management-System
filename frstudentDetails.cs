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
    public partial class frstudentDetails : Form
    {
        MainClass main = new MainClass();
        public frstudentDetails()
        {
            InitializeComponent();
        }

        private void frstudentDetails_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = main.connec())
            {
                SqlDataAdapter da = new SqlDataAdapter("select StudentName,StudentSemester,StudentPhone,StudentEmail from student", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
