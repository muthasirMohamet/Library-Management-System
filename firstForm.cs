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
    public partial class firstForm : Form
    {
        public firstForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if (panel2.Width >= 350)
            {
                timer1.Stop();

                loginfr lForm = new loginfr();
                lForm.Show();
                this.Hide();

            }
        }

    }
}
