using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manegment_System
{
    public partial class Dstudent : Form
    {
        public Dstudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dstudent_Load(object sender, EventArgs e)
        {
            loginfr fr = new loginfr();
            lblUsername.Text = fr.txtusername.Text;
            lblUsername.Show();

            DateTime dt = DateTime.Now;
            lbldate.Text = dt.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frstudentLibrary f = new frstudentLibrary();
            f.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frstudentDetails f1 = new frstudentDetails();
            f1.Show();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
