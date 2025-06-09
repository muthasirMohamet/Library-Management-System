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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mahubtaa inaad kabaxeydid","Hubin",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBook book = new addBook();
            book.Show();
            book.MdiParent = this;
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veiwBook view = new veiwBook();
            view.Show();
            view.MdiParent = this;
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateBook update = new updateBook();
            update.Show();
            update.MdiParent = this;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent student = new AddStudent();
            student.Show();
            student.MdiParent = this;
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStudent student = new viewStudent();
            student.Show();
            student.MdiParent = this;
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueBook book = new issueBook();
            book.Show();
            book.MdiParent = this;
        }

        private void returnbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnBook book = new returnBook();
            book.Show();
            book.MdiParent = this;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            string x = DateTime.Now.ToString();
            label1.Text = x;
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogRegistretion log = new LogRegistretion();
            log.Show();
            log.MdiParent = this;
        }
    }
}
