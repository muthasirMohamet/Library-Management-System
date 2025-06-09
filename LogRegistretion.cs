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
    public partial class LogRegistretion : Form
    {
        MainClass main = new MainClass();
        public LogRegistretion()
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
                cmd.CommandText = "AddEditUsers";
                cmd.Parameters.AddWithValue("@uid", "");
                cmd.Parameters.AddWithValue("@UName", txtuserlogin.Text);
                cmd.Parameters.AddWithValue("@UType", comusertype.Text);
                cmd.Parameters.AddWithValue("@UserPass", txtuserpass.Text);
                cmd.Parameters.AddWithValue("@type", "insert");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Users has been saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTexBox();
                conn.Close();
                btnsave.Enabled = true;
            }
        }

        private void clearTexBox()
        {
            txtuserlogin.Clear();
            txtuserpass.Clear();
            comusertype.Items.Clear();
        }
    }
}
