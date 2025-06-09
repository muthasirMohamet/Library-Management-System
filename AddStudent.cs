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
    public partial class AddStudent : Form
    {
        MainClass main = new MainClass();
        public AddStudent()
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddorEditStudent";
                cmd.Parameters.AddWithValue("@SID", "");
                cmd.Parameters.AddWithValue("@SNAME", txtname.Text);
                cmd.Parameters.AddWithValue("@SSemester", comsem.Text);
                cmd.Parameters.AddWithValue("@SPHONE", txtphone.Text);
                cmd.Parameters.AddWithValue("@SEMAIL", txtemail.Text);
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
            
        }
    }
}
