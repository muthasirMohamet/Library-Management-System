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
    public partial class Dadmin : Form
    {
        public Dadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook add = new addBook();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            issueBook add = new issueBook();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            returnBook rt = new returnBook();
            rt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
