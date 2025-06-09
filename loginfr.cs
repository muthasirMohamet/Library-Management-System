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
    public partial class loginfr : Form
    {
        MainClass main = new MainClass();
        public loginfr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = main.connec())
            {
                if (txtusername.Text == "")
                {
                    MessageBox.Show("Enter ther Username.");
                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("Enter the Password!");
                }else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Enter the user type!");
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("select * from Users where UsersName ='" + txtusername.Text + "' AND UsersPass = '" + txtpassword.Text + "' and usersType = '"+comboBox1.Text+"'", sqlconn);
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Login seccess!");
                            if (comboBox1.Text == "Student" || comboBox1.Text == "student")
                            {
                                Dstudent dst = new Dstudent();
                                dst.Show();
                                this.Hide();
                            }
                            else if (comboBox1.Text == "Super Admin" || comboBox1.Text == "Super Admin" || comboBox1.Text == "super admin" || comboBox1.Text == "super admin")
                            {
                                Mainform fr = new Mainform();
                                fr.Show();
                                this.Hide();
                            }
                            else if (comboBox1.Text == "ADMIN" || comboBox1.Text == "Admin" || comboBox1.Text == "admin" || comboBox1.Text == "admin")
                            {
                                Dadmin fr = new Dadmin();
                                fr.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Lamayaqan waxan aad soo galiday");
                            }
                        }
                        else
                        {
                            MessageBox.Show("'"+txtusername.Text+"' lama yaqaan user-kan!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waxaad wacdaa number kan, Si laguu cawiyo. \n+252617066302");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            
       

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtusername.Text == "User Name")
            {
                txtusername.Clear();
            }
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar += '*';
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox1.Text == "User Type")
            {
            }
        }
    }
}
